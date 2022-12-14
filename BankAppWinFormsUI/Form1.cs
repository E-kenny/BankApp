using static System.ComponentModel.Design.ObjectSelectorEditor;
using Microsoft.Extensions.DependencyInjection;
using BankAppWinForm.Repositories.Implementations;
using BankAppWinForm.Repositories.Interfaces;
using BankAppWinForm.Services.Implementations;
using BankAppWinForm.Services.Interfaces;
using BankAppWinForm.Models;
using BankAppWinForm.Services;
using BankAppWinForm.Repositories;
using System.Net.Security;
using System.Windows.Forms;
using System.Security.Principal;
using System.Transactions;
using BankAppWinForms.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace BankAppWinForms
{
    public partial class BankAppForm : Form
    {
        public ICustomerService _customerService;
        public IBankAccountService _bankAccountService;
        public ITransactionService _transactionService;
        public Response _response;
        public Customer _customer;
        public List<BankAccount> _allBankAccount;
        public List<CustomerTransaction> _allCustomerTransactions;

        public BankAppForm(IBankAccountService bankAccountService, ICustomerService customerService, ITransactionService transactionService, IBankAccountRepository bankAccountRepository, ITransactionRepository transactionRepository)
        {
            InitializeComponent();
            _customerService = customerService;
            _transactionService = transactionService;
            _bankAccountService = bankAccountService;
            _allBankAccount = bankAccountRepository.ReadAllAccounts();
            _allCustomerTransactions = transactionRepository.ReadAllTransactions();

            //layers
            HomePage.Show();
            RegistrationPage.Hide();
            Menu.Hide();
            LogIn.Hide();
            OpenAccount.Hide();
            Withdrawal.Hide();
            Transfer.Hide();
            Deposit.Hide();
            AccountView.Hide();
            ListViewBack.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdmale_CheckedChanged(object sender, EventArgs e)
        {

        }


        //Registration
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool firstName = MyValidator.IsValid(registerFirstName.Text);
            bool lastName = MyValidator.IsValid(registerLastName.Text);

            var emailValidator = new EmailAddressAttribute();
            bool email =   emailValidator.IsValid(RegisterEmail.Text);


            bool password = MyValidator.IsPassword( RegisterPassword.Text);


            if (firstName && lastName  && password && email) 
            {
                _response = _customerService.Register(registerFirstName.Text, registerLastName.Text, RegisterEmail.Text, RegisterPassword.Text);
                _customer = _response.customer;
                LoginMessage.Text = _response.message;

                if (_response.status == "Successful")
                {
                    HomePage.Hide();
                    RegistrationPage.Hide();
                    Menu.Hide();
                    LogIn.Show();

                    registerFirstName.Text = "";
                    registerLastName.Text = "";
                    RegisterEmail.Text = "";
                    RegisterPassword.Text = "";
                    RegisterMessage1.Text = "";
                    RegisterMessage.Text = "";
                    RegisterMessage2.Text = "";
                }
            }
            else
            {
                RegisterMessage1.Text = "proper email format";
                RegisterMessage2.Text = "Name must start with cap letter";
                RegisterMessage.Text = "Password - (spe)char & Alphanumeric";
            }           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            HomePage.Hide();
            RegistrationPage.Show();
            Menu.Hide();
            LogIn.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HomePage.Hide();
            RegistrationPage.Hide();
            Menu.Hide();
            LogIn.Show();
        }

        private void RegisterHome_Click(object sender, EventArgs e)
        {

            HomePage.Show();
            RegistrationPage.Hide();
            Menu.Hide();
            LogIn.Hide();
        }

        private void LoginHome_Click(object sender, EventArgs e)
        {
            HomePage.Show();
            RegistrationPage.Hide();
            Menu.Hide();
            LogIn.Hide();
        }

        //Login
        private void button1_Click(object sender, EventArgs e)
        {

            var emailValidator = new EmailAddressAttribute();
            bool email = emailValidator.IsValid(LogInEmail.Text);

            bool password = MyValidator.IsPassword(LogInPassword.Text);


            if (email && password)
            {
                _response = _customerService.logIn(LogInEmail.Text, LogInPassword.Text);
                _customer = _response.customer;
                LoginMessage1.Text = _response.message;

                if (LoginMessage1.Text == "Authenticated")
                {
                    LogIn.Hide();
                    Menu.Show();
                    LoginMessage.Text = "";
                    LogInEmail.Text = "";
                    LogInPassword.Text = "";
                    LoginMessage.Text = "";
                    LoginMessage1.Text = "";
                    LoginMessage2.Text = "";
                }
            }
            else if(email){
                LoginMessage.Text = "Proper password format";
                LoginMessage2.Text = "Special char & alphanumeric";
                LoginMessage1.Text = "Not Authenticated";
            }
            else
            {
                LoginMessage.Text = "Proper email format";
                LoginMessage2.Text = "Special char & alphanumeric";
                LoginMessage1.Text = "Not Authenticated";
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage.Hide();
            RegistrationPage.Hide();
            Menu.Hide();
            LogIn.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void OpenAccount_Click(object sender, EventArgs e)
        {
            string _initialBalance = InitialBalance.Text;
            if (int.TryParse(_initialBalance, out int balance))
            {
                BankAccount _bankAccount = _bankAccountService.OpenAccount(_customer, 2, balance);
                if (_bankAccount != null)
                {
                    _allCustomerTransactions =  _transactionService.MakeDeposit(_bankAccount.Id, balance, DateTime.Now, "Initial Balance");
                    OpenAccountMessage.Text = "";
                    _allBankAccount.Add(_bankAccount);
                    Menu.Show();
                    OpenAccount.Hide();
                    InitialBalance.Text = "";
                }         


            }
            else
            {
                OpenAccountMessage.Text = "Wrong Input";
            }

        }

        private void ToOpenAccount_Click(object sender, EventArgs e)
        {
            Menu.Hide();
            OpenAccount.Show();
        }

        private void OpenAccountBack_Click(object sender, EventArgs e)
        {
            Menu.Show();
            OpenAccount.Hide();
            OpenAccountMessage.Text = "";
        }

        private void OpenSavings_Click(object sender, EventArgs e)
        {
            string _initialBalance = InitialBalance.Text;
            if (int.TryParse(_initialBalance, out int balance))
            {
                BankAccount _bankAccount = _bankAccountService.OpenAccount(_customer, 1, balance);
                if (_bankAccount != null)
                {
                    _allCustomerTransactions =  _transactionService.MakeDeposit(_bankAccount.Id, balance, DateTime.Now, "Initial Balance");
                    OpenAccountMessage.Text = "";
                    _allBankAccount.Add(_bankAccount);
                    Menu.Show();
                    OpenAccount.Hide();
                    InitialBalance.Text = "";
                }

            }
            else
            {
                OpenAccountMessage.Text = "Wrong Input";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HomePage.Hide();
            RegistrationPage.Hide();
            Menu.Hide();
            LogIn.Hide();
            OpenAccount.Hide();
            Withdrawal.Show();
            Transfer.Hide();
            Deposit.Hide();
            AccountView.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomePage.Hide();
            RegistrationPage.Hide();
            Menu.Hide();
            LogIn.Hide();
            OpenAccount.Hide();
            Withdrawal.Hide();
            Transfer.Hide();
            Deposit.Show();
            AccountView.Hide();
        }

        private void AccountView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            HomePage.Hide();
            RegistrationPage.Hide();
            Menu.Hide();
            LogIn.Hide();
            OpenAccount.Hide();
            Withdrawal.Hide();
            Transfer.Hide();
            Deposit.Hide();
            //listview
            ListViewBack.Show();
            AccountView.Show();
            AccountView.View = View.Details;

            // Now create the columns
            // AccountView.Columns.Add("Account Number", 100);
            AccountView.Columns.Add("Name", 100);
            AccountView.Columns.Add("Type", 100);
            AccountView.Columns.Add("Number", 100);
            AccountView.Columns.Add("Balance", 100);

          
            foreach (var account in _allBankAccount)
            {
                decimal balance = 0;

                if (account.CustomerId == _customer.Id)
                {
                   
                    ListViewItem item = new ListViewItem(account.Owner);
                    item.SubItems.Add(account.Type);
                    item.SubItems.Add(account.Number);
                    
                    foreach(var transaction in _allCustomerTransactions)
                    {
                      
                        if (account.Id == transaction.AccountId)
                            balance+= transaction.Amount;
                    }


                    item.SubItems.Add(Convert.ToString(balance));
                    AccountView.Items.Add(item);
                }

            }
        }

        private void Deposit_Enter(object sender, EventArgs e)
        {

        }

        private void ListViewBack_Click(object sender, EventArgs e)
        {
            AccountView.Hide();
            ListViewBack.Hide();
            Menu.Show();
            AccountView.Clear();
        }

        private void TransferBack_Click(object sender, EventArgs e)
        {
            Menu.Show();
            Transfer.Hide();
            TransferFrom.Text = "";
            TransferTo.Text = "";
            TransferAmount.Text = "";
            TransferDescription.Text = "";
        }

        private void MakeWithdrawal_Click(object sender, EventArgs e)
        {
          
            foreach (var account in _allBankAccount)
            {
                if (account.Number == WithdrawalAccount.Text)
                {
                  
                    if (int.TryParse(WithdrawalAmount.Text, out int inpAmt))
                    {
                        _allCustomerTransactions =  _transactionService.MakeWithdrawal(account.Id, inpAmt, DateTime.Now, WithdrawalDescription.Text);
                        Menu.Show();
                        Withdrawal.Hide();
                        WithdrawalAccount.Text = "";
                        WithdrawalAmount.Text = "";
                        WithdrawalDescription.Text = "";
                        WithdrawalMessage.Text = "";
                        break;
                    }
                    else
                    {
                        WithdrawalMessage.Text = "Wrong Input";
                        break;
                    }
                }
                else
                {
                    WithdrawalMessage.Text = "Account Not Found";
                }


            }
        }

        private void WithdrawalBack_Click(object sender, EventArgs e)
        {
            Menu.Show();
            Withdrawal.Hide();
            WithdrawalAccount.Text = "";
            WithdrawalAmount.Text = "";
            WithdrawalDescription.Text = "";

        }

        private void DepositBack_Click(object sender, EventArgs e)
        {
            Menu.Show();
            Deposit.Hide();
            DepositAccount.Text = "";
            DepositAmount.Text = "";
            DepositDescription.Text = "";
        }

        
        private void MakeDeposit_Click(object sender, EventArgs e)
        {
          
            foreach (var account in _allBankAccount)
            {
                if (account.Number == DepositAccount.Text)
                {
                   
                    if (int.TryParse(DepositAmount.Text, out int inpAmt))
                    {
                       _allCustomerTransactions =  _transactionService.MakeDeposit(account.Id, inpAmt, DateTime.Now, DepositDescription.Text);
                        Menu.Show();
                        Deposit.Hide();
                        DepositMessage.Text = "";
                        DepositAccount.Text = "";
                        DepositAmount.Text = "";
                        DepositDescription.Text = "";
                        break;
                    }
                    else
                    {
                        DepositMessage.Text = "Wrong Input";
                    }
                }
                else
                {
                    DepositMessage.Text = "Account Not Found";
                }


            }
        }

        private void MakeTransfer_Click(object sender, EventArgs e)
        {
            string x = "";
            string y = "";

            foreach (var account1 in _allBankAccount)
            {

                if (account1.Number == TransferFrom.Text)
                {
                    x = account1.Id;
                    break;
                }

            }

            foreach (var account2 in _allBankAccount)
            {
                if (account2.Number == TransferTo.Text)
                {
                    y = account2.Id;
                    break;
                }

            }


            if(x != null && y != null)
            {
                if (int.TryParse(TransferAmount.Text, out int kAmt))
                {
                    _allCustomerTransactions = _transactionService.Transfer(x, kAmt, y, WithdrawalDescription.Text);
                    Menu.Show();
                    Transfer.Hide();
                }
                else
                {
                    TransferMessage.Text = "Wrong Input Amount";
                }
            }
            else
            {
                TransferMessage.Text = "Check your Account no";
            }           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu.Hide();
            Transfer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage.Hide();
            RegistrationPage.Hide();
            Menu.Hide();
            LogIn.Hide();
            OpenAccount.Hide();
            Withdrawal.Hide();
            Transfer.Hide();
            Deposit.Hide();
            //listview
            ListViewBack.Show();
            AccountView.Show();
            AccountView.View = View.Details;

            // Now create the columns
            // AccountView.Columns.Add("Account Number", 100);
            AccountView.Columns.Add("Date", 100);
            AccountView.Columns.Add("Description", 100);
            AccountView.Columns.Add("Account", 100);
            AccountView.Columns.Add("Balance", 100);

            foreach (var account in _allBankAccount)
            {
               
                foreach (var transaction in _allCustomerTransactions)
                    {

                     if (account.CustomerId == _customer.Id)
                       
                      {

                        if (account.Id == transaction.AccountId)
                        {
                            ListViewItem item = new ListViewItem(account.Owner);
                        item.SubItems.Add(account.Type);
                        item.SubItems.Add(account.Number);


                            decimal balance = 0;

                            balance += transaction.Amount;
                            item.SubItems.Add(Convert.ToString(balance));
                            AccountView.Items.Add(item);
                        }   
                     }
                }

            }
        }

        private void Transfer_Enter(object sender, EventArgs e)
        {

        }
    }

}