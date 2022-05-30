using Expense_Manager.Models;

namespace Expense_Manager
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LoggedInUser = new System.Windows.Forms.Label();
            this.AddTrans = new System.Windows.Forms.Button();
            this.TransactionTable = new System.Windows.Forms.DataGridView();
            this.transactionDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionCategoryBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.transactionAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Balance = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveTransaction = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountFromBox = new System.Windows.Forms.TextBox();
            this.AmountToBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryFilter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TypeFilter = new System.Windows.Forms.ComboBox();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.ResetFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logged in as user:";
            // 
            // LoggedInUser
            // 
            this.LoggedInUser.AutoSize = true;
            this.LoggedInUser.Location = new System.Drawing.Point(141, 39);
            this.LoggedInUser.Name = "LoggedInUser";
            this.LoggedInUser.Size = new System.Drawing.Size(87, 15);
            this.LoggedInUser.TabIndex = 1;
            this.LoggedInUser.Text = "PLACEHOLDER";
            // 
            // AddTrans
            // 
            this.AddTrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTrans.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddTrans.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddTrans.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTrans.Location = new System.Drawing.Point(12, 255);
            this.AddTrans.Name = "AddTrans";
            this.AddTrans.Size = new System.Drawing.Size(803, 45);
            this.AddTrans.TabIndex = 2;
            this.AddTrans.Text = "Add transaction";
            this.AddTrans.UseVisualStyleBackColor = false;
            this.AddTrans.Click += new System.EventHandler(this.AddTrans_Click);
            // 
            // TransactionTable
            // 
            this.TransactionTable.AllowUserToAddRows = false;
            this.TransactionTable.AllowUserToDeleteRows = false;
            this.TransactionTable.AllowUserToOrderColumns = true;
            this.TransactionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionTable.AutoGenerateColumns = false;
            this.TransactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionDescriptionDataGridViewTextBoxColumn,
            this.TransactionCategoryBox,
            this.transactionAmountDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewComboBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn});
            this.TransactionTable.DataSource = this.transactionBindingSource;
            this.TransactionTable.Location = new System.Drawing.Point(12, 306);
            this.TransactionTable.Name = "TransactionTable";
            this.TransactionTable.RowHeadersWidth = 51;
            this.TransactionTable.RowTemplate.Height = 25;
            this.TransactionTable.Size = new System.Drawing.Size(803, 261);
            this.TransactionTable.TabIndex = 3;
            this.TransactionTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionTable_CellClick);
            this.TransactionTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionTable_CellValueChanged);
            this.TransactionTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransactionTable_KeyPress);
            // 
            // transactionDescriptionDataGridViewTextBoxColumn
            // 
            this.transactionDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TransactionDescription";
            this.transactionDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.transactionDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionDescriptionDataGridViewTextBoxColumn.Name = "transactionDescriptionDataGridViewTextBoxColumn";
            this.transactionDescriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.transactionDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // TransactionCategoryBox
            // 
            this.TransactionCategoryBox.DataPropertyName = "TransactionCategory";
            this.TransactionCategoryBox.HeaderText = "Category";
            this.TransactionCategoryBox.Name = "TransactionCategoryBox";
            this.TransactionCategoryBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionCategoryBox.Width = 150;
            // 
            // transactionAmountDataGridViewTextBoxColumn
            // 
            this.transactionAmountDataGridViewTextBoxColumn.DataPropertyName = "TransactionAmount";
            this.transactionAmountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.transactionAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionAmountDataGridViewTextBoxColumn.Name = "transactionAmountDataGridViewTextBoxColumn";
            this.transactionAmountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.transactionAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactionTypeDataGridViewComboBoxColumn
            // 
            this.transactionTypeDataGridViewComboBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewComboBoxColumn.HeaderText = "Type";
            this.transactionTypeDataGridViewComboBoxColumn.MinimumWidth = 6;
            this.transactionTypeDataGridViewComboBoxColumn.Name = "transactionTypeDataGridViewComboBoxColumn";
            this.transactionTypeDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionTypeDataGridViewComboBoxColumn.Width = 150;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.transactionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.transactionDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(Expense_Manager.Models.Transaction);
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(141, 68);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(87, 15);
            this.Balance.TabIndex = 5;
            this.Balance.Text = "PLACEHOLDER";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDataToolStripMenuItem,
            this.importDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.exportDataToolStripMenuItem.Text = "Export data";
            this.exportDataToolStripMenuItem.Click += new System.EventHandler(this.ExportDataToolStripMenuItem_Click);
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.importDataToolStripMenuItem.Text = "Import data";
            this.importDataToolStripMenuItem.Click += new System.EventHandler(this.ImportDataToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(0, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Current balance:";
            // 
            // RemoveTransaction
            // 
            this.RemoveTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveTransaction.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveTransaction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveTransaction.Location = new System.Drawing.Point(683, 39);
            this.RemoveTransaction.Name = "RemoveTransaction";
            this.RemoveTransaction.Size = new System.Drawing.Size(132, 81);
            this.RemoveTransaction.TabIndex = 10;
            this.RemoveTransaction.Text = "Remove transaction";
            this.RemoveTransaction.UseVisualStyleBackColor = false;
            this.RemoveTransaction.Click += new System.EventHandler(this.RemoveTransaction_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBox.Location = new System.Drawing.Point(12, 167);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(213, 23);
            this.SearchBox.TabIndex = 11;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Filter.Location = new System.Drawing.Point(7, 105);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(67, 32);
            this.Filter.TabIndex = 12;
            this.Filter.Text = "Filter";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount from";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Amount to";
            // 
            // AmountFromBox
            // 
            this.AmountFromBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountFromBox.Location = new System.Drawing.Point(12, 220);
            this.AmountFromBox.Name = "AmountFromBox";
            this.AmountFromBox.Size = new System.Drawing.Size(100, 23);
            this.AmountFromBox.TabIndex = 16;
            this.AmountFromBox.TextChanged += new System.EventHandler(this.AmountFromBox_TextChanged);
            // 
            // AmountToBox
            // 
            this.AmountToBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountToBox.Location = new System.Drawing.Point(125, 220);
            this.AmountToBox.Name = "AmountToBox";
            this.AmountToBox.Size = new System.Drawing.Size(100, 23);
            this.AmountToBox.TabIndex = 17;
            this.AmountToBox.TextChanged += new System.EventHandler(this.AmountToBox_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Category";
            // 
            // CategoryFilter
            // 
            this.CategoryFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryFilter.FormattingEnabled = true;
            this.CategoryFilter.Location = new System.Drawing.Point(244, 167);
            this.CategoryFilter.Name = "CategoryFilter";
            this.CategoryFilter.Size = new System.Drawing.Size(121, 23);
            this.CategoryFilter.TabIndex = 19;
            this.CategoryFilter.SelectedIndexChanged += new System.EventHandler(this.CategoryFilter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Type";
            // 
            // TypeFilter
            // 
            this.TypeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TypeFilter.FormattingEnabled = true;
            this.TypeFilter.Location = new System.Drawing.Point(244, 220);
            this.TypeFilter.Name = "TypeFilter";
            this.TypeFilter.Size = new System.Drawing.Size(121, 23);
            this.TypeFilter.TabIndex = 21;
            this.TypeFilter.SelectedIndexChanged += new System.EventHandler(this.TypeFilter_SelectedIndexChanged);
            // 
            // DateFrom
            // 
            this.DateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrom.Location = new System.Drawing.Point(387, 167);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(200, 23);
            this.DateFrom.TabIndex = 22;
            this.DateFrom.ValueChanged += new System.EventHandler(this.DateFrom_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Date From";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Date to";
            // 
            // DateTo
            // 
            this.DateTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTo.Location = new System.Drawing.Point(387, 220);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(200, 23);
            this.DateTo.TabIndex = 25;
            this.DateTo.ValueChanged += new System.EventHandler(this.DateTo_ValueChanged);
            // 
            // ResetFilter
            // 
            this.ResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetFilter.Location = new System.Drawing.Point(619, 174);
            this.ResetFilter.Name = "ResetFilter";
            this.ResetFilter.Size = new System.Drawing.Size(183, 54);
            this.ResetFilter.TabIndex = 26;
            this.ResetFilter.Text = "Reset Filter";
            this.ResetFilter.UseVisualStyleBackColor = true;
            this.ResetFilter.Click += new System.EventHandler(this.ResetFilter_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 579);
            this.Controls.Add(this.ResetFilter);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.TypeFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CategoryFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AmountToBox);
            this.Controls.Add(this.AmountFromBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.RemoveTransaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.TransactionTable);
            this.Controls.Add(this.AddTrans);
            this.Controls.Add(this.LoggedInUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "MainWindow";
            this.Text = "Expense Manager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label LoggedInUser;
        private Button AddTrans;
        public DataGridView TransactionTable;
        public BindingSource transactionBindingSource;
        public Label Balance;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exportDataToolStripMenuItem;
        private ToolStripMenuItem importDataToolStripMenuItem;
        private Label label2;
        private DataGridViewTextBoxColumn transactionDescriptionDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn TransactionCategoryBox;
        private DataGridViewTextBoxColumn transactionAmountDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn transactionTypeDataGridViewComboBoxColumn;
        private DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private Button RemoveTransaction;
        private TextBox SearchBox;
        private Label Filter;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox AmountFromBox;
        private TextBox AmountToBox;
        private Label label6;
        private ComboBox CategoryFilter;
        private Label label7;
        private ComboBox TypeFilter;
        private DateTimePicker DateFrom;
        private Label label8;
        private Label label9;
        private DateTimePicker DateTo;
        private Button ResetFilter;
    }
}