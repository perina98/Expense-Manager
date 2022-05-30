using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Expense_Manager
{
    public static class ExpenseManager
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseFacade facade = new(new DataContext());
            facade.EnsureCreated();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}