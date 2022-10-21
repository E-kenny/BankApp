using Microsoft.Extensions.DependencyInjection;
using BankAppWinForm.Repositories.Implementations;
using BankAppWinForm.Repositories.Interfaces;
using BankAppWinForm.Services.Implementations;
using BankAppWinForm.Services.Interfaces;
using BankAppWinForm.Models;

namespace BankAppWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Welcome());

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<BankAppForm>();
                Application.Run(form1);
            }
     
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ICustomerRepo, CustomerRepo>();
            services.AddScoped<IBankAccountRepository, BankAccountRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<IBankAccountService, BankAccountService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<BankAppForm>();
        }
        //private static void ConfigureServices(ServiceCollection services)
        //{
        //    //services.AddScoped<I, Test>();
        //    //services.AddScoped<Form1>();
        //}
    }
}