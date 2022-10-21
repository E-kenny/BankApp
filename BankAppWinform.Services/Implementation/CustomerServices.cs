

namespace BankApp.Services.Implementation
{
    public class CustomerServices
    {

        public CustomerServices()
        {

        }
        
        public string AccountDetails()
        {
            var report = new System.Text.StringBuilder();


            report.AppendLine($"ACCOUNT DETAILS");
            report.AppendLine($"|---------------|------------------------|---------------|---------------|");
            report.AppendLine($"|{"FULL NAME",-15}| {"ACCOUNT NUMBER",-23}| {"ACCOUNT TYPE",-15}| {"AMOUNT BALANCE",-15}");
            report.AppendLine($"|---------------|------------------------|---------------|---------------|");
            foreach (var item in myAccount)
            {

                report.AppendLine($"|{Name,-15}| {item.Number,-25}| {item.Type,-15}| {item.Balance,-15}|");
            }

            report.AppendLine($"|---------------|------------------------|---------------|---------------|");

            return report.ToString();
        }

    }
}