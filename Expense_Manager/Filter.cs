using Microsoft.EntityFrameworkCore;

namespace Expense_Manager
{
    public class Filter
    {
        public string Description { get; set; }
        public decimal AmountFrom { get; set; }
        public decimal AmountTo { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public TransactionCategory? TransactionCategory { get; set; }
        public TransactionType? TransactionType { get; set; }
        
        public Filter()
        {
            Description = "";
            AmountFrom = decimal.MinValue;
            AmountTo = decimal.MaxValue;
            DateFrom = DateTime.MinValue;
            DateTo = DateTime.MaxValue;
            TransactionCategory = null;
            TransactionType = null;
            db = new();
        }

        DataContext db;

        internal void FilterTable(MainWindow mainwindow)
        {
            if (db == null || db.Transactions == null || db.Users == null)
            { 
                throw new Exception("Database not initialized");
            }
            db.Transactions.Load();
            var result = db.Transactions.Local.ToBindingList()
                .Where(t => t.AccountID == mainwindow.LoggedUser)
                .Where(t => t.TransactionDescription.ToLower().Contains(Description.ToLower()))
                .Where(t => t.TransactionAmount >= AmountFrom)
                .Where(t => t.TransactionAmount <= AmountTo)
                .Where(t => t.TransactionDate >= DateFrom)
                .Where(t => t.TransactionDate <= DateTo);

            if (TransactionCategory != null)
            {
                result = result.Where(t => t.TransactionCategory == TransactionCategory);
            }
            if (TransactionType != null)
            {
                result = result.Where(t => t.TransactionType == TransactionType);
            }

            mainwindow.transactionBindingSource.DataSource = result.ToList();
            mainwindow.TransactionTable.Refresh();
        }
    }
}
