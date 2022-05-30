namespace Expense_Manager
{
    partial class AddTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Description = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.MoveBox = new System.Windows.Forms.GroupBox();
            this.ExpenseBox = new System.Windows.Forms.RadioButton();
            this.IncomeBox = new System.Windows.Forms.RadioButton();
            this.AddTrans = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.MoveBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(25, 37);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(67, 15);
            this.Description.TabIndex = 0;
            this.Description.Text = "Description";
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(25, 161);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(51, 15);
            this.Amount.TabIndex = 1;
            this.Amount.Text = "Amount";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionBox.Location = new System.Drawing.Point(25, 55);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(279, 23);
            this.DescriptionBox.TabIndex = 3;
            // 
            // AmountBox
            // 
            this.AmountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountBox.Location = new System.Drawing.Point(25, 179);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(279, 23);
            this.AmountBox.TabIndex = 4;
            // 
            // MoveBox
            // 
            this.MoveBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveBox.Controls.Add(this.ExpenseBox);
            this.MoveBox.Controls.Add(this.IncomeBox);
            this.MoveBox.Location = new System.Drawing.Point(25, 235);
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.Size = new System.Drawing.Size(279, 73);
            this.MoveBox.TabIndex = 5;
            this.MoveBox.TabStop = false;
            this.MoveBox.Text = "Move";
            // 
            // ExpenseBox
            // 
            this.ExpenseBox.AutoSize = true;
            this.ExpenseBox.Location = new System.Drawing.Point(143, 33);
            this.ExpenseBox.Name = "ExpenseBox";
            this.ExpenseBox.Size = new System.Drawing.Size(68, 19);
            this.ExpenseBox.TabIndex = 1;
            this.ExpenseBox.Text = "Expense";
            this.ExpenseBox.UseVisualStyleBackColor = true;
            // 
            // IncomeBox
            // 
            this.IncomeBox.AutoSize = true;
            this.IncomeBox.Checked = true;
            this.IncomeBox.Location = new System.Drawing.Point(48, 33);
            this.IncomeBox.Name = "IncomeBox";
            this.IncomeBox.Size = new System.Drawing.Size(65, 19);
            this.IncomeBox.TabIndex = 0;
            this.IncomeBox.TabStop = true;
            this.IncomeBox.Text = "Income";
            this.IncomeBox.UseVisualStyleBackColor = true;
            // 
            // AddTrans
            // 
            this.AddTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTrans.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddTrans.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTrans.ForeColor = System.Drawing.SystemColors.Control;
            this.AddTrans.Location = new System.Drawing.Point(86, 324);
            this.AddTrans.Name = "AddTrans";
            this.AddTrans.Size = new System.Drawing.Size(143, 43);
            this.AddTrans.TabIndex = 6;
            this.AddTrans.Text = "Add Transaction";
            this.AddTrans.UseVisualStyleBackColor = false;
            this.AddTrans.Click += new System.EventHandler(this.AddTrans_Click);
            // 
            // Category
            // 
            this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(25, 97);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(55, 15);
            this.Category.TabIndex = 7;
            this.Category.Text = "Category";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(25, 115);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(279, 23);
            this.CategoryBox.TabIndex = 9;
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 391);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.AddTrans);
            this.Controls.Add(this.MoveBox);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Description);
            this.MinimumSize = new System.Drawing.Size(350, 430);
            this.Name = "AddTransaction";
            this.Text = "AddTransaction";
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            this.MoveBox.ResumeLayout(false);
            this.MoveBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Description;
        private Label Amount;
        private TextBox DescriptionBox;
        private TextBox AmountBox;
        private GroupBox MoveBox;
        private RadioButton ExpenseBox;
        private RadioButton IncomeBox;
        private Button AddTrans;
        private Label Category;
        private FileSystemWatcher fileSystemWatcher1;
        private ComboBox CategoryBox;
    }
}