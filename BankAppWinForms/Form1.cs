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

        public BankAppForm(IBankAccountService bankAccountService, ICustomerService customerService, ITransactionService transactionService, IBankAccountRepository bankAccountRepository)
        {
            InitializeComponent();
            _customerService = customerService;
            _transactionService = transactionService;
            _bankAccountService = bankAccountService;
            _allBankAccount = bankAccountRepository.ReadAllAccounts();

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
            string firstName = registerFirstName.Text;
            string lastName = registerLastName.Text;
            string email = RegisterEmail.Text;
            string password = RegisterPassword.Text;

            _response = _customerService.Register(firstName, lastName, email, password);
            _customer = _response.customer;
            message.Text = _response.message;

            if (_response.status == "Successful")
            {
                HomePage.Show();
                RegistrationPage.Hide();
                Menu.Hide();
                LogIn.Hide();

                registerFirstName.Text = "";
                registerLastName.Text = "";
                RegisterEmail.Text = "";
                RegisterPassword.Text = "";
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
            string email = LogInEmail.Text;
            string password = LogInPassword.Text;

            _response = _customerService.logIn(email, password);
            _customer = _response.customer;
            message.Text = _response.message;

            if (message.Text == "Authenticated")
            {
                LogIn.Hide();
                Menu.Show();
                message.Text = "";
                LogInEmail.Text = "";
                LogInPassword.Text = "";
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
        }

        private void OpenSavings_Click(object sender, EventArgs e)
        {
            string _initialBalance = InitialBalance.Text;
            if (int.TryParse(_initialBalance, out int balance))
            {
                BankAccount _bankAccount = _bankAccountService.OpenAccount(_customer, 1, balance);
                if (_bankAccount != null)
                {
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
                if (account.CustomerId == _customer.Id)
                {
                    ListViewItem item = new ListViewItem(account.Owner);
                    item.SubItems.Add(account.Type);
                    item.SubItems.Add(account.Number);
                    item.SubItems.Add(Convert.ToString(account.Balance));
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
           
        }

        private void MakeWithdrawal_Click(object sender, EventArgs e)
        {
            BankAccount x = new BankAccount();
            foreach (var account in _allBankAccount)
            {
                if (account.Number == WithdrawalAccount.Text)
                {
                    x = account;
                    if (int.TryParse(WithdrawalAmount.Text, out int inpAmt))
                    {
                        _transactionService.MakeWithdrawal(x, inpAmt, DateTime.Now, WithdrawalDescription.Text);
                    }
                    else
                    {
                        WithdrawalMessage.Text = "Wrong Input";
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
        }

        private void DepositBack_Click(object sender, EventArgs e)
        {
            Menu.Show();
            Deposit.Hide();
        }

        private void MakeDeposit_Click(object sender, EventArgs e)
        {
            BankAccount x = new BankAccount();
            foreach (var account in _allBankAccount)
            {
                if (account.Number == WithdrawalAccount.Text)
                {
                    x = account;
                    if (int.TryParse(WithdrawalAmount.Text, out int inpAmt))
                    {
                        _transactionService.MakeDeposit(x, inpAmt, DateTime.Now, WithdrawalDescription.Text);
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
    }
}