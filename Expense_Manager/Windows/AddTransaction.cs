using Expense_Manager.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Expense_Manager
{
    public partial class AddTransaction : Form
    {
        public AddTransaction(MainWindow MainWindow, int AccountID)
        {
            InitializeComponent();
            this.AccountID = AccountID;
            this.MainWindow = MainWindow;
            db = new();
        }

        DataContext db;
        readonly int AccountID;
        MainWindow MainWindow;

        private void AddTrans_Click(object sender, EventArgs e)
        {
            if (SaveTransaction())
            {
                UpdateMainWindow();
                MessageBox.Show("Transaction added successfully");
            }
        }

        private bool SaveTransaction()
        {
            if (db.Transactions == null || db.Users == null)
            {
                throw new Exception("Database transactions or users are null");
            }
            try
            {
                if (Convert.ToDecimal(AmountBox.Text) <= 0)
                {
                    MessageBox.Show("Amount must be greater than 0");
                    return false;
                }
                var transaction = new Transaction
                {
                    AccountID = AccountID,
                    TransactionDescription = DescriptionBox.Text,
                    TransactionCategory = Enum.Parse<TransactionCategory>(CategoryBox.Text),
                    TransactionAmount = Convert.ToDecimal(AmountBox.Text),
                    TransactionType = IncomeBox.Checked ? TransactionType.Income : TransactionType.Expense
                };

                db.Transactions.Add(transaction);
                db.SaveChanges();
                return true;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please fill in all the fields correctly");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in all the fields correctly");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please fill in all the fields correctly");
            }
            finally
            {
                DescriptionBox.Text = "";
                CategoryBox.Text = "None";
                AmountBox.Text = "";
            }
            return false;
        }
        
        private void UpdateMainWindow()
        {
            if (db.Transactions == null || db.Users == null)
            {
                throw new Exception("Database transactions or users are null");
            }
            db.Transactions.Load();
            MainWindow.transactionBindingSource.DataSource = db.Transactions.Local.ToBindingList().Where(t => t.AccountID == AccountID);
            MainWindow.TransactionTable.Refresh();
            MainWindow.Balance.Text = db.Users.First(u => u.Id == AccountID).GetBalance();
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            CategoryBox.DataSource = Enum.GetValues(typeof(TransactionCategory));
        }
    }
}
