using Expense_Manager.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Expense_Manager.Data
{
    public static class DataProcessor
    {
        public static void Import(MainWindow mainWindow)
        {
            OpenFileDialog ofd = new()
            {
                Filter = "JSON files (*.json)|*.json",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            var input = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Task.Run(() =>
                {
                    input = File.ReadAllText(ofd.FileName);
                    try
                    {
                        var db = new DataContext();
                        if (db.Transactions == null)
                        {
                            throw new Exception("Transactions not initialized");
                        }
                        var transactions = JsonSerializer.Deserialize<List<Transaction>>(input);
                        if (transactions != null)
                        {
                            foreach (var t in transactions)
                            {
                                var category = t.TransactionCategory;
                                var type = t.TransactionType;
                                var transaction = new Transaction
                                {
                                    AccountID = mainWindow.LoggedUser,
                                    TransactionDescription = t.TransactionDescription,
                                    TransactionCategory = category,
                                    TransactionAmount = t.TransactionAmount,
                                    TransactionType = type,
                                    TransactionDate = t.TransactionDate
                                };
                                db.Transactions.Add(transaction);
                            }
                            db.SaveChanges();

                            db.Transactions.Load();

                            mainWindow.transactionBindingSource.DataSource = db.Transactions.Local.ToBindingList().Where(t => t.AccountID == mainWindow.LoggedUser);
                            mainWindow.TransactionTable.Refresh();
                            mainWindow.Balance.Text = db.Users.First(u => u.Id == mainWindow.LoggedUser).GetBalance();

                            MessageBox.Show("Data imported");
                        }
                        else
                        {
                            MessageBox.Show("Data not imported");
                        }
                    }
                    catch (JsonException)
                    {
                        MessageBox.Show("Data corrupted. Not importing.");
                    }
                });
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        public static void Export(MainWindow mainWindow)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "JSON files (*.json)|*.json",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                FileName = "transactions.json"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Task.Run(() =>
                {
                    var db = new DataContext();
                    if (db.Transactions == null)
                    {
                        throw new Exception("Transactions not initialized");
                    }
                    db.Transactions.Load();
                    var transactions = db.Transactions.Local.ToBindingList().Where(t => t.AccountID == mainWindow.LoggedUser);
                    var json = JsonSerializer.Serialize(transactions);
                    File.WriteAllText(saveFileDialog.FileName, json);
                    MessageBox.Show("Data exported");
                });
            }
        }
    }
}
