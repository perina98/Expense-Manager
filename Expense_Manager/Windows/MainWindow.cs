using Expense_Manager.Data;
using Expense_Manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Expense_Manager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            db = new DataContext();
            filter = new Filter();
        }

        DataContext db;
        Filter filter;
        public int LoggedUser { get; set; }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new();
            loginWindow.ShowDialog();

            if (loginWindow.DialogResult == DialogResult.OK)
            {
                ShowMainWindow(loginWindow);
            }
        }

        private void ShowMainWindow(LoginWindow loginWindow)
        {
            if (db.Transactions == null || db.Users == null)
            {
                throw new Exception("Database transactions or users are null");
            }
            
            LoggedUser = loginWindow.LoggedUser;

            if (db.Users.First(u => u.Id == loginWindow.LoggedUser).Username == null)
            {
                throw new Exception("Logged user username is null");
            }
            LoggedInUser.Text = db.Users.First(u => u.Id == loginWindow.LoggedUser).Username.ToString();

            Balance.Text = db.Users.First(u => u.Id == loginWindow.LoggedUser).GetBalance();

            db.Transactions.Load();
            transactionBindingSource.DataSource = db.Transactions.Local.ToBindingList().Where(t => t.AccountID == LoggedUser);
            transactionTypeDataGridViewComboBoxColumn.DataSource = Enum.GetValues(typeof(TransactionType));
            TransactionCategoryBox.DataSource = Enum.GetValues(typeof(TransactionCategory));
            TransactionTable.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";

            TypeFilter.DataSource = Enum.GetValues(typeof(TransactionType));
            CategoryFilter.DataSource = Enum.GetValues(typeof(TransactionCategory));

            TransactionTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ResetTransactionsFilter();

            Show();
        }

        private void ResetTransactionsFilter() {
            filter = new Filter();
            filter.FilterTable(this);

            SearchBox.Text = "";
            AmountFromBox.Text = "";
            AmountToBox.Text = "";
            DateFrom.Value = DateTime.Now.AddDays(-31);
            DateTo.Value = DateTime.Now;
            CategoryFilter.SelectedIndex = -1;
            TypeFilter.SelectedIndex = -1;
        }

        private void AddTrans_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new(this,LoggedUser);
            addTransaction.ShowDialog();
            TransactionTable.Refresh();
            ResetTransactionsFilter();
        }

        private void TransactionTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (db != null && db.Transactions != null && db.Users != null)
            {
                if (TransactionTable.EndEdit())
                {
                    db.SaveChanges();

                    db.Transactions.Load();
                    transactionBindingSource.DataSource = db.Transactions.Local.ToBindingList().Where(t => t.AccountID == LoggedUser);
                    Balance.Text = db.Users.First(u => u.Id == LoggedUser).GetBalance();
                }
            }
        }

        private void ExportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataProcessor.Export(this);
        }

        private void ImportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataProcessor.Import(this);
        }

        private void TransactionTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                var date = TransactionTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (date != null)
                {
                    var dateTimePicker = new DateTimePicker
                    {
                        Format = DateTimePickerFormat.Custom,
                        CustomFormat = "dd.MM.yyyy",
                        Value = DateTime.Parse(date)
                    };
                    TransactionTable.Controls.Add(dateTimePicker);
                    dateTimePicker.Location = TransactionTable.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                    dateTimePicker.Size = TransactionTable.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Size;
                    dateTimePicker.CloseUp += (s, args) =>
                    {
                        try
                        {
                            TransactionTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dateTimePicker.Value.ToString("dd.MM.yyyy");
                            TransactionTable.EndEdit();
                            db.SaveChanges();
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            dateTimePicker.Dispose();
                        }
                        finally
                        {
                            dateTimePicker.Dispose();
                        }
                    };
                }
            }
        }

        private void RemoveTransaction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete selected transactions?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (db.Transactions == null || db.Users == null)
                {
                    throw new Exception("Database not initialized");
                }
                //using (DataContext db = new())
                //{
                foreach (DataGridViewRow row in TransactionTable.SelectedRows)
                {
                    var trans = db.Transactions.First(t => t.TransactionID == ((Transaction)row.DataBoundItem).TransactionID);
                    db.Transactions.Remove(trans);
                }
                db.SaveChanges();
                db.Transactions.Load();
                transactionBindingSource.DataSource = db.Transactions.Local.ToBindingList().Where(t => t.AccountID == LoggedUser);
                //}

                TransactionTable.Refresh();
                Balance.Text = db.Users.First(u => u.Id == LoggedUser).GetBalance();
                ResetTransactionsFilter();
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            filter.Description = SearchBox.Text;
            filter.FilterTable(this);
        }

        private void AmountFromBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter.AmountFrom = decimal.Parse(AmountFromBox.Text);
                filter.FilterTable(this);
            }
            catch (FormatException)
            {
                ResetTransactionsFilter();
            }
            catch (OverflowException)
            {
                ResetTransactionsFilter();
            }
        }

        private void AmountToBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter.AmountTo = decimal.Parse(AmountToBox.Text);
                filter.FilterTable(this);
            }
            catch (FormatException)
            {
                ResetTransactionsFilter();
            }
            catch (OverflowException)
            {
                ResetTransactionsFilter();
            }
        }

        private void CategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryFilter.SelectedItem != null)
            {
                filter.TransactionCategory = (TransactionCategory)CategoryFilter.SelectedItem;
                filter.FilterTable(this);
            }
        }

        private void TypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeFilter.SelectedItem != null)
            {
                filter.TransactionType = (TransactionType)TypeFilter.SelectedItem;
                filter.FilterTable(this);
            }
        }

        private void DateTo_ValueChanged(object sender, EventArgs e)
        {
            filter.DateTo = DateTo.Value;
            filter.FilterTable(this);
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {
            filter.DateFrom = DateFrom.Value;
            filter.FilterTable(this);
        }

        private void ResetFilter_Click(object sender, EventArgs e)
        {
            ResetTransactionsFilter();
        }

        private void TransactionTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                RemoveTransaction_Click(sender, e);
            }
        }
    }
}