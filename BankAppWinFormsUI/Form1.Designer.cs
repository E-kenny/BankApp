
namespace BankAppWinForms
{
    partial class BankAppForm
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
            this.registerFirstName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.RegistrationPage = new System.Windows.Forms.GroupBox();
            this.RegisterMessage2 = new System.Windows.Forms.TextBox();
            this.RegisterMessage1 = new System.Windows.Forms.TextBox();
            this.RegisterMessage = new System.Windows.Forms.TextBox();
            this.RegisterHome = new System.Windows.Forms.Button();
            this.RegisterPassword = new System.Windows.Forms.TextBox();
            this.RegisterEmail = new System.Windows.Forms.TextBox();
            this.registerLastName = new System.Windows.Forms.TextBox();
            this.LogIn = new System.Windows.Forms.GroupBox();
            this.LoginMessage2 = new System.Windows.Forms.TextBox();
            this.LoginMessage = new System.Windows.Forms.TextBox();
            this.LoginMessage1 = new System.Windows.Forms.TextBox();
            this.LoginHome = new System.Windows.Forms.Button();
            this.LogInPassword = new System.Windows.Forms.TextBox();
            this.LogInEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HomePage = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.ToOpenAccount = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LandingPage = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.AccountStatement = new System.Windows.Forms.GroupBox();
            this.AccountDetailsTB = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.LogInPage = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.GroupBox();
            this.TransferMessage = new System.Windows.Forms.TextBox();
            this.TransferDescription = new System.Windows.Forms.TextBox();
            this.TransferTo = new System.Windows.Forms.TextBox();
            this.TransferBack = new System.Windows.Forms.Button();
            this.MakeTransfer = new System.Windows.Forms.Button();
            this.TransferAmount = new System.Windows.Forms.TextBox();
            this.TransferFrom = new System.Windows.Forms.TextBox();
            this.Withdrawal = new System.Windows.Forms.GroupBox();
            this.WithdrawalMessage = new System.Windows.Forms.TextBox();
            this.WithdrawalDescription = new System.Windows.Forms.TextBox();
            this.WithdrawalAccount = new System.Windows.Forms.TextBox();
            this.WithdrawalBack = new System.Windows.Forms.Button();
            this.WithdrawalAmount = new System.Windows.Forms.TextBox();
            this.MakeWithdrawal = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.GroupBox();
            this.DepositMessage = new System.Windows.Forms.TextBox();
            this.DepositDescription = new System.Windows.Forms.TextBox();
            this.DepositAccount = new System.Windows.Forms.TextBox();
            this.DepositBack = new System.Windows.Forms.Button();
            this.DepositAmount = new System.Windows.Forms.TextBox();
            this.MakeDeposit = new System.Windows.Forms.Button();
            this.OpenAccount = new System.Windows.Forms.GroupBox();
            this.OpenAccountMessage = new System.Windows.Forms.TextBox();
            this.OpenSavings = new System.Windows.Forms.Button();
            this.OpenAccountBack = new System.Windows.Forms.Button();
            this.OpenCurrent = new System.Windows.Forms.Button();
            this.InitialBalance = new System.Windows.Forms.TextBox();
            this.AccountView = new System.Windows.Forms.ListView();
            this.ListViewBack = new System.Windows.Forms.Button();
            this.RegistrationPage.SuspendLayout();
            this.LogIn.SuspendLayout();
            this.HomePage.SuspendLayout();
            this.Menu.SuspendLayout();
            this.LandingPage.SuspendLayout();
            this.AccountStatement.SuspendLayout();
            this.LogInPage.SuspendLayout();
            this.Transfer.SuspendLayout();
            this.Withdrawal.SuspendLayout();
            this.Deposit.SuspendLayout();
            this.OpenAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerFirstName
            // 
            this.registerFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerFirstName.Location = new System.Drawing.Point(0, 20);
            this.registerFirstName.Name = "registerFirstName";
            this.registerFirstName.PlaceholderText = "First Name";
            this.registerFirstName.Size = new System.Drawing.Size(165, 27);
            this.registerFirstName.TabIndex = 2;
            this.registerFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSubmit.Location = new System.Drawing.Point(-3, 243);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(60, 28);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Register";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // RegistrationPage
            // 
            this.RegistrationPage.BackColor = System.Drawing.Color.DimGray;
            this.RegistrationPage.Controls.Add(this.RegisterMessage2);
            this.RegistrationPage.Controls.Add(this.RegisterMessage1);
            this.RegistrationPage.Controls.Add(this.RegisterMessage);
            this.RegistrationPage.Controls.Add(this.RegisterHome);
            this.RegistrationPage.Controls.Add(this.RegisterPassword);
            this.RegistrationPage.Controls.Add(this.RegisterEmail);
            this.RegistrationPage.Controls.Add(this.registerLastName);
            this.RegistrationPage.Controls.Add(this.btnSubmit);
            this.RegistrationPage.Controls.Add(this.registerFirstName);
            this.RegistrationPage.ForeColor = System.Drawing.SystemColors.Control;
            this.RegistrationPage.Location = new System.Drawing.Point(1, 4);
            this.RegistrationPage.Name = "RegistrationPage";
            this.RegistrationPage.Size = new System.Drawing.Size(165, 271);
            this.RegistrationPage.TabIndex = 1;
            this.RegistrationPage.TabStop = false;
            this.RegistrationPage.Text = "Register User";
            this.RegistrationPage.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RegisterMessage2
            // 
            this.RegisterMessage2.BackColor = System.Drawing.Color.Gray;
            this.RegisterMessage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegisterMessage2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterMessage2.Location = new System.Drawing.Point(0, 196);
            this.RegisterMessage2.Name = "RegisterMessage2";
            this.RegisterMessage2.Size = new System.Drawing.Size(163, 15);
            this.RegisterMessage2.TabIndex = 18;
            this.RegisterMessage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegisterMessage1
            // 
            this.RegisterMessage1.BackColor = System.Drawing.Color.Gray;
            this.RegisterMessage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegisterMessage1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterMessage1.Location = new System.Drawing.Point(0, 172);
            this.RegisterMessage1.Name = "RegisterMessage1";
            this.RegisterMessage1.Size = new System.Drawing.Size(163, 15);
            this.RegisterMessage1.TabIndex = 17;
            this.RegisterMessage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegisterMessage
            // 
            this.RegisterMessage.BackColor = System.Drawing.Color.Gray;
            this.RegisterMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegisterMessage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterMessage.Location = new System.Drawing.Point(0, 222);
            this.RegisterMessage.Name = "RegisterMessage";
            this.RegisterMessage.Size = new System.Drawing.Size(163, 15);
            this.RegisterMessage.TabIndex = 16;
            this.RegisterMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegisterHome
            // 
            this.RegisterHome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.RegisterHome.Location = new System.Drawing.Point(99, 243);
            this.RegisterHome.Name = "RegisterHome";
            this.RegisterHome.Size = new System.Drawing.Size(60, 28);
            this.RegisterHome.TabIndex = 11;
            this.RegisterHome.Text = "Home";
            this.RegisterHome.UseVisualStyleBackColor = false;
            this.RegisterHome.Click += new System.EventHandler(this.RegisterHome_Click);
            // 
            // RegisterPassword
            // 
            this.RegisterPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterPassword.Location = new System.Drawing.Point(0, 140);
            this.RegisterPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.RegisterPassword.Name = "RegisterPassword";
            this.RegisterPassword.PlaceholderText = "Password";
            this.RegisterPassword.Size = new System.Drawing.Size(163, 27);
            this.RegisterPassword.TabIndex = 10;
            this.RegisterPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // RegisterEmail
            // 
            this.RegisterEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterEmail.Location = new System.Drawing.Point(0, 100);
            this.RegisterEmail.Name = "RegisterEmail";
            this.RegisterEmail.PlaceholderText = "Email";
            this.RegisterEmail.Size = new System.Drawing.Size(165, 27);
            this.RegisterEmail.TabIndex = 9;
            // 
            // registerLastName
            // 
            this.registerLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerLastName.Location = new System.Drawing.Point(0, 60);
            this.registerLastName.Name = "registerLastName";
            this.registerLastName.PlaceholderText = "Last Name";
            this.registerLastName.Size = new System.Drawing.Size(165, 27);
            this.registerLastName.TabIndex = 8;
            this.registerLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.DimGray;
            this.LogIn.Controls.Add(this.LoginMessage2);
            this.LogIn.Controls.Add(this.LoginMessage);
            this.LogIn.Controls.Add(this.LoginMessage1);
            this.LogIn.Controls.Add(this.LoginHome);
            this.LogIn.Controls.Add(this.LogInPassword);
            this.LogIn.Controls.Add(this.LogInEmail);
            this.LogIn.Controls.Add(this.button1);
            this.LogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.LogIn.Location = new System.Drawing.Point(1, 281);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(165, 199);
            this.LogIn.TabIndex = 11;
            this.LogIn.TabStop = false;
            this.LogIn.Text = "Log In User";
            // 
            // LoginMessage2
            // 
            this.LoginMessage2.BackColor = System.Drawing.Color.Gray;
            this.LoginMessage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginMessage2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginMessage2.Location = new System.Drawing.Point(1, 134);
            this.LoginMessage2.Name = "LoginMessage2";
            this.LoginMessage2.Size = new System.Drawing.Size(163, 15);
            this.LoginMessage2.TabIndex = 17;
            this.LoginMessage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginMessage
            // 
            this.LoginMessage.BackColor = System.Drawing.Color.Gray;
            this.LoginMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginMessage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginMessage.Location = new System.Drawing.Point(2, 115);
            this.LoginMessage.Name = "LoginMessage";
            this.LoginMessage.Size = new System.Drawing.Size(163, 15);
            this.LoginMessage.TabIndex = 16;
            this.LoginMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginMessage1
            // 
            this.LoginMessage1.BackColor = System.Drawing.Color.Gray;
            this.LoginMessage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginMessage1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginMessage1.Location = new System.Drawing.Point(2, 152);
            this.LoginMessage1.Name = "LoginMessage1";
            this.LoginMessage1.Size = new System.Drawing.Size(163, 15);
            this.LoginMessage1.TabIndex = 15;
            this.LoginMessage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginHome
            // 
            this.LoginHome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LoginHome.Location = new System.Drawing.Point(88, 169);
            this.LoginHome.Name = "LoginHome";
            this.LoginHome.Size = new System.Drawing.Size(52, 27);
            this.LoginHome.TabIndex = 15;
            this.LoginHome.Text = "Home";
            this.LoginHome.UseVisualStyleBackColor = false;
            this.LoginHome.Click += new System.EventHandler(this.LoginHome_Click);
            // 
            // LogInPassword
            // 
            this.LogInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInPassword.Location = new System.Drawing.Point(0, 75);
            this.LogInPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.LogInPassword.Name = "LogInPassword";
            this.LogInPassword.PlaceholderText = "Password";
            this.LogInPassword.Size = new System.Drawing.Size(163, 26);
            this.LogInPassword.TabIndex = 10;
            // 
            // LogInEmail
            // 
            this.LogInEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInEmail.Location = new System.Drawing.Point(0, 30);
            this.LogInEmail.Name = "LogInEmail";
            this.LogInEmail.PlaceholderText = "Email";
            this.LogInEmail.Size = new System.Drawing.Size(165, 27);
            this.LogInEmail.TabIndex = 9;
            this.LogInEmail.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(6, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.HomePage.BackColor = System.Drawing.Color.DimGray;
            this.HomePage.Controls.Add(this.label2);
            this.HomePage.Controls.Add(this.label1);
            this.HomePage.Controls.Add(this.button12);
            this.HomePage.Controls.Add(this.button11);
            this.HomePage.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.HomePage.ForeColor = System.Drawing.SystemColors.Control;
            this.HomePage.Location = new System.Drawing.Point(172, 5);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(211, 165);
            this.HomePage.TabIndex = 13;
            this.HomePage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "E-kenny Bank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button12.Location = new System.Drawing.Point(91, 96);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(104, 30);
            this.button12.TabIndex = 13;
            this.button12.Text = "Register";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button11.Location = new System.Drawing.Point(6, 96);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(79, 32);
            this.button11.TabIndex = 12;
            this.button11.Text = "Login";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.DimGray;
            this.Menu.Controls.Add(this.ToOpenAccount);
            this.Menu.Controls.Add(this.button7);
            this.Menu.Controls.Add(this.button6);
            this.Menu.Controls.Add(this.button5);
            this.Menu.Controls.Add(this.button4);
            this.Menu.Controls.Add(this.button3);
            this.Menu.Controls.Add(this.button2);
            this.Menu.ForeColor = System.Drawing.SystemColors.Control;
            this.Menu.Location = new System.Drawing.Point(389, 4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(199, 324);
            this.Menu.TabIndex = 11;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            // 
            // ToOpenAccount
            // 
            this.ToOpenAccount.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ToOpenAccount.Location = new System.Drawing.Point(8, 14);
            this.ToOpenAccount.Name = "ToOpenAccount";
            this.ToOpenAccount.Size = new System.Drawing.Size(172, 27);
            this.ToOpenAccount.TabIndex = 13;
            this.ToOpenAccount.Text = "Open Account";
            this.ToOpenAccount.UseVisualStyleBackColor = false;
            this.ToOpenAccount.Click += new System.EventHandler(this.ToOpenAccount_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button7.Location = new System.Drawing.Point(8, 60);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 32);
            this.button7.TabIndex = 12;
            this.button7.Text = "Account Details";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button6.Location = new System.Drawing.Point(8, 176);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 44);
            this.button6.TabIndex = 11;
            this.button6.Text = "Transfer";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button5.Location = new System.Drawing.Point(99, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 29);
            this.button5.TabIndex = 10;
            this.button5.Text = "Deposit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.Location = new System.Drawing.Point(53, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "Log out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Location = new System.Drawing.Point(95, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Account Statement";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Location = new System.Drawing.Point(8, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Withdrawal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // LandingPage
            // 
            this.LandingPage.BackColor = System.Drawing.Color.DimGray;
            this.LandingPage.Controls.Add(this.button9);
            this.LandingPage.Controls.Add(this.button8);
            this.LandingPage.Controls.Add(this.textBox7);
            this.LandingPage.Controls.Add(this.textBox6);
            this.LandingPage.ForeColor = System.Drawing.SystemColors.Control;
            this.LandingPage.Location = new System.Drawing.Point(0, 2);
            this.LandingPage.Name = "LandingPage";
            this.LandingPage.Size = new System.Drawing.Size(380, 370);
            this.LandingPage.TabIndex = 12;
            this.LandingPage.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.CadetBlue;
            this.button9.Location = new System.Drawing.Point(123, 271);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 40);
            this.button9.TabIndex = 9;
            this.button9.Text = "Login";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.CadetBlue;
            this.button8.Location = new System.Drawing.Point(123, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 40);
            this.button8.TabIndex = 8;
            this.button8.Text = "Register";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(75, 112);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(234, 29);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "E-KENNY BANK";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(123, 49);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(114, 33);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "Welcome To ";
            // 
            // AccountStatement
            // 
            this.AccountStatement.BackColor = System.Drawing.Color.DimGray;
            this.AccountStatement.Controls.Add(this.AccountDetailsTB);
            this.AccountStatement.Controls.Add(this.textBox14);
            this.AccountStatement.Controls.Add(this.textBox15);
            this.AccountStatement.Controls.Add(this.textBox16);
            this.AccountStatement.Controls.Add(this.textBox17);
            this.AccountStatement.ForeColor = System.Drawing.SystemColors.Control;
            this.AccountStatement.Location = new System.Drawing.Point(0, 0);
            this.AccountStatement.Name = "AccountStatement";
            this.AccountStatement.Size = new System.Drawing.Size(393, 370);
            this.AccountStatement.TabIndex = 14;
            this.AccountStatement.TabStop = false;
            // 
            // AccountDetailsTB
            // 
            this.AccountDetailsTB.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountDetailsTB.Location = new System.Drawing.Point(48, 14);
            this.AccountDetailsTB.Name = "AccountDetailsTB";
            this.AccountDetailsTB.Size = new System.Drawing.Size(272, 29);
            this.AccountDetailsTB.TabIndex = 4;
            this.AccountDetailsTB.Text = "Account Statement";
            this.AccountDetailsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox14.Location = new System.Drawing.Point(291, 52);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(91, 282);
            this.textBox14.TabIndex = 3;
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox15.Location = new System.Drawing.Point(194, 52);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(91, 282);
            this.textBox15.TabIndex = 2;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox16.Location = new System.Drawing.Point(97, 52);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(91, 282);
            this.textBox16.TabIndex = 1;
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox17.Location = new System.Drawing.Point(0, 52);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(91, 282);
            this.textBox17.TabIndex = 0;
            // 
            // LogInPage
            // 
            this.LogInPage.BackColor = System.Drawing.Color.DimGray;
            this.LogInPage.Controls.Add(this.textBox13);
            this.LogInPage.Controls.Add(this.textBox18);
            this.LogInPage.Controls.Add(this.button10);
            this.LogInPage.ForeColor = System.Drawing.SystemColors.Control;
            this.LogInPage.Location = new System.Drawing.Point(0, 0);
            this.LogInPage.Name = "LogInPage";
            this.LogInPage.Size = new System.Drawing.Size(393, 370);
            this.LogInPage.TabIndex = 14;
            this.LogInPage.TabStop = false;
            this.LogInPage.Text = "LogIn";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox13.Location = new System.Drawing.Point(25, 105);
            this.textBox13.Name = "textBox13";
            this.textBox13.PlaceholderText = "Password";
            this.textBox13.Size = new System.Drawing.Size(295, 34);
            this.textBox13.TabIndex = 10;
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox18.Location = new System.Drawing.Point(25, 51);
            this.textBox18.Name = "textBox18";
            this.textBox18.PlaceholderText = "Email";
            this.textBox18.Size = new System.Drawing.Size(295, 34);
            this.textBox18.TabIndex = 9;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.CadetBlue;
            this.button10.Location = new System.Drawing.Point(25, 269);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 40);
            this.button10.TabIndex = 7;
            this.button10.Text = "Login";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.Color.DimGray;
            this.Transfer.Controls.Add(this.TransferMessage);
            this.Transfer.Controls.Add(this.TransferDescription);
            this.Transfer.Controls.Add(this.TransferTo);
            this.Transfer.Controls.Add(this.TransferBack);
            this.Transfer.Controls.Add(this.MakeTransfer);
            this.Transfer.Controls.Add(this.TransferAmount);
            this.Transfer.Controls.Add(this.TransferFrom);
            this.Transfer.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Transfer.ForeColor = System.Drawing.SystemColors.Control;
            this.Transfer.Location = new System.Drawing.Point(600, 259);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(392, 228);
            this.Transfer.TabIndex = 15;
            this.Transfer.TabStop = false;
            this.Transfer.Text = "Transfer";
            this.Transfer.Enter += new System.EventHandler(this.Transfer_Enter);
            // 
            // TransferMessage
            // 
            this.TransferMessage.BackColor = System.Drawing.Color.Gray;
            this.TransferMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransferMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferMessage.Location = new System.Drawing.Point(6, 123);
            this.TransferMessage.Name = "TransferMessage";
            this.TransferMessage.Size = new System.Drawing.Size(385, 20);
            this.TransferMessage.TabIndex = 26;
            this.TransferMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TransferDescription
            // 
            this.TransferDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferDescription.Location = new System.Drawing.Point(186, 81);
            this.TransferDescription.Name = "TransferDescription";
            this.TransferDescription.PlaceholderText = "Description";
            this.TransferDescription.Size = new System.Drawing.Size(201, 27);
            this.TransferDescription.TabIndex = 25;
            // 
            // TransferTo
            // 
            this.TransferTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferTo.Location = new System.Drawing.Point(185, 22);
            this.TransferTo.Name = "TransferTo";
            this.TransferTo.PlaceholderText = "To";
            this.TransferTo.Size = new System.Drawing.Size(201, 27);
            this.TransferTo.TabIndex = 24;
            // 
            // TransferBack
            // 
            this.TransferBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TransferBack.Location = new System.Drawing.Point(253, 164);
            this.TransferBack.Name = "TransferBack";
            this.TransferBack.Size = new System.Drawing.Size(68, 32);
            this.TransferBack.TabIndex = 23;
            this.TransferBack.Text = "Back";
            this.TransferBack.UseVisualStyleBackColor = false;
            this.TransferBack.Click += new System.EventHandler(this.TransferBack_Click);
            // 
            // MakeTransfer
            // 
            this.MakeTransfer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MakeTransfer.Location = new System.Drawing.Point(6, 164);
            this.MakeTransfer.Name = "MakeTransfer";
            this.MakeTransfer.Size = new System.Drawing.Size(76, 32);
            this.MakeTransfer.TabIndex = 22;
            this.MakeTransfer.Text = "Transfer";
            this.MakeTransfer.UseVisualStyleBackColor = false;
            this.MakeTransfer.Click += new System.EventHandler(this.MakeTransfer_Click);
            // 
            // TransferAmount
            // 
            this.TransferAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferAmount.Location = new System.Drawing.Point(0, 81);
            this.TransferAmount.Name = "TransferAmount";
            this.TransferAmount.PlaceholderText = "Amount";
            this.TransferAmount.Size = new System.Drawing.Size(177, 27);
            this.TransferAmount.TabIndex = 21;
            // 
            // TransferFrom
            // 
            this.TransferFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferFrom.Location = new System.Drawing.Point(1, 22);
            this.TransferFrom.Name = "TransferFrom";
            this.TransferFrom.PlaceholderText = "From ";
            this.TransferFrom.Size = new System.Drawing.Size(177, 27);
            this.TransferFrom.TabIndex = 20;
            // 
            // Withdrawal
            // 
            this.Withdrawal.BackColor = System.Drawing.Color.DimGray;
            this.Withdrawal.Controls.Add(this.WithdrawalMessage);
            this.Withdrawal.Controls.Add(this.WithdrawalDescription);
            this.Withdrawal.Controls.Add(this.WithdrawalAccount);
            this.Withdrawal.Controls.Add(this.WithdrawalBack);
            this.Withdrawal.Controls.Add(this.WithdrawalAmount);
            this.Withdrawal.Controls.Add(this.MakeWithdrawal);
            this.Withdrawal.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Withdrawal.ForeColor = System.Drawing.SystemColors.Control;
            this.Withdrawal.Location = new System.Drawing.Point(594, 12);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(211, 234);
            this.Withdrawal.TabIndex = 16;
            this.Withdrawal.TabStop = false;
            this.Withdrawal.Text = "Withdrawal";
            this.Withdrawal.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // WithdrawalMessage
            // 
            this.WithdrawalMessage.BackColor = System.Drawing.Color.Gray;
            this.WithdrawalMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WithdrawalMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawalMessage.Location = new System.Drawing.Point(0, 146);
            this.WithdrawalMessage.Name = "WithdrawalMessage";
            this.WithdrawalMessage.Size = new System.Drawing.Size(211, 20);
            this.WithdrawalMessage.TabIndex = 22;
            this.WithdrawalMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WithdrawalDescription
            // 
            this.WithdrawalDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawalDescription.Location = new System.Drawing.Point(0, 110);
            this.WithdrawalDescription.Name = "WithdrawalDescription";
            this.WithdrawalDescription.PlaceholderText = "Description";
            this.WithdrawalDescription.Size = new System.Drawing.Size(211, 27);
            this.WithdrawalDescription.TabIndex = 21;
            // 
            // WithdrawalAccount
            // 
            this.WithdrawalAccount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawalAccount.Location = new System.Drawing.Point(0, 22);
            this.WithdrawalAccount.Name = "WithdrawalAccount";
            this.WithdrawalAccount.PlaceholderText = "Account";
            this.WithdrawalAccount.Size = new System.Drawing.Size(211, 27);
            this.WithdrawalAccount.TabIndex = 20;
            // 
            // WithdrawalBack
            // 
            this.WithdrawalBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.WithdrawalBack.Location = new System.Drawing.Point(105, 188);
            this.WithdrawalBack.Name = "WithdrawalBack";
            this.WithdrawalBack.Size = new System.Drawing.Size(88, 32);
            this.WithdrawalBack.TabIndex = 19;
            this.WithdrawalBack.Text = "Back";
            this.WithdrawalBack.UseVisualStyleBackColor = false;
            this.WithdrawalBack.Click += new System.EventHandler(this.WithdrawalBack_Click);
            // 
            // WithdrawalAmount
            // 
            this.WithdrawalAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawalAmount.Location = new System.Drawing.Point(0, 64);
            this.WithdrawalAmount.Name = "WithdrawalAmount";
            this.WithdrawalAmount.PlaceholderText = "Amount";
            this.WithdrawalAmount.Size = new System.Drawing.Size(211, 27);
            this.WithdrawalAmount.TabIndex = 18;
            // 
            // MakeWithdrawal
            // 
            this.MakeWithdrawal.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MakeWithdrawal.Location = new System.Drawing.Point(6, 190);
            this.MakeWithdrawal.Name = "MakeWithdrawal";
            this.MakeWithdrawal.Size = new System.Drawing.Size(79, 32);
            this.MakeWithdrawal.TabIndex = 17;
            this.MakeWithdrawal.Text = "Withdraw";
            this.MakeWithdrawal.UseVisualStyleBackColor = false;
            this.MakeWithdrawal.Click += new System.EventHandler(this.MakeWithdrawal_Click);
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.Color.DimGray;
            this.Deposit.Controls.Add(this.DepositMessage);
            this.Deposit.Controls.Add(this.DepositDescription);
            this.Deposit.Controls.Add(this.DepositAccount);
            this.Deposit.Controls.Add(this.DepositBack);
            this.Deposit.Controls.Add(this.DepositAmount);
            this.Deposit.Controls.Add(this.MakeDeposit);
            this.Deposit.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Deposit.ForeColor = System.Drawing.SystemColors.Control;
            this.Deposit.Location = new System.Drawing.Point(811, 12);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(187, 234);
            this.Deposit.TabIndex = 17;
            this.Deposit.TabStop = false;
            this.Deposit.Text = "Deposit";
            this.Deposit.Enter += new System.EventHandler(this.Deposit_Enter);
            // 
            // DepositMessage
            // 
            this.DepositMessage.BackColor = System.Drawing.Color.Gray;
            this.DepositMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DepositMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositMessage.Location = new System.Drawing.Point(0, 146);
            this.DepositMessage.Name = "DepositMessage";
            this.DepositMessage.Size = new System.Drawing.Size(187, 20);
            this.DepositMessage.TabIndex = 23;
            this.DepositMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DepositDescription
            // 
            this.DepositDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositDescription.Location = new System.Drawing.Point(6, 110);
            this.DepositDescription.Name = "DepositDescription";
            this.DepositDescription.PlaceholderText = "Description";
            this.DepositDescription.Size = new System.Drawing.Size(187, 27);
            this.DepositDescription.TabIndex = 22;
            // 
            // DepositAccount
            // 
            this.DepositAccount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositAccount.Location = new System.Drawing.Point(6, 22);
            this.DepositAccount.Name = "DepositAccount";
            this.DepositAccount.PlaceholderText = "Account";
            this.DepositAccount.Size = new System.Drawing.Size(181, 27);
            this.DepositAccount.TabIndex = 21;
            // 
            // DepositBack
            // 
            this.DepositBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DepositBack.Location = new System.Drawing.Point(100, 185);
            this.DepositBack.Name = "DepositBack";
            this.DepositBack.Size = new System.Drawing.Size(81, 32);
            this.DepositBack.TabIndex = 20;
            this.DepositBack.Text = "Back";
            this.DepositBack.UseVisualStyleBackColor = false;
            this.DepositBack.Click += new System.EventHandler(this.DepositBack_Click);
            // 
            // DepositAmount
            // 
            this.DepositAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositAmount.Location = new System.Drawing.Point(0, 64);
            this.DepositAmount.Name = "DepositAmount";
            this.DepositAmount.PlaceholderText = "Amount";
            this.DepositAmount.Size = new System.Drawing.Size(197, 27);
            this.DepositAmount.TabIndex = 19;
            // 
            // MakeDeposit
            // 
            this.MakeDeposit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MakeDeposit.Location = new System.Drawing.Point(6, 188);
            this.MakeDeposit.Name = "MakeDeposit";
            this.MakeDeposit.Size = new System.Drawing.Size(79, 32);
            this.MakeDeposit.TabIndex = 18;
            this.MakeDeposit.Text = "Deposit";
            this.MakeDeposit.UseVisualStyleBackColor = false;
            this.MakeDeposit.Click += new System.EventHandler(this.MakeDeposit_Click);
            // 
            // OpenAccount
            // 
            this.OpenAccount.BackColor = System.Drawing.Color.DimGray;
            this.OpenAccount.Controls.Add(this.OpenAccountMessage);
            this.OpenAccount.Controls.Add(this.OpenSavings);
            this.OpenAccount.Controls.Add(this.OpenAccountBack);
            this.OpenAccount.Controls.Add(this.OpenCurrent);
            this.OpenAccount.Controls.Add(this.InitialBalance);
            this.OpenAccount.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.OpenAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenAccount.Location = new System.Drawing.Point(172, 180);
            this.OpenAccount.Name = "OpenAccount";
            this.OpenAccount.Size = new System.Drawing.Size(211, 148);
            this.OpenAccount.TabIndex = 18;
            this.OpenAccount.TabStop = false;
            this.OpenAccount.Text = "Open Account";
            // 
            // OpenAccountMessage
            // 
            this.OpenAccountMessage.BackColor = System.Drawing.Color.Gray;
            this.OpenAccountMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OpenAccountMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenAccountMessage.Location = new System.Drawing.Point(0, 46);
            this.OpenAccountMessage.Name = "OpenAccountMessage";
            this.OpenAccountMessage.Size = new System.Drawing.Size(211, 20);
            this.OpenAccountMessage.TabIndex = 18;
            this.OpenAccountMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenSavings
            // 
            this.OpenSavings.BackColor = System.Drawing.Color.LightSeaGreen;
            this.OpenSavings.Location = new System.Drawing.Point(116, 72);
            this.OpenSavings.Name = "OpenSavings";
            this.OpenSavings.Size = new System.Drawing.Size(79, 32);
            this.OpenSavings.TabIndex = 17;
            this.OpenSavings.Text = "Savings";
            this.OpenSavings.UseVisualStyleBackColor = false;
            this.OpenSavings.Click += new System.EventHandler(this.OpenSavings_Click);
            // 
            // OpenAccountBack
            // 
            this.OpenAccountBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.OpenAccountBack.Location = new System.Drawing.Point(31, 109);
            this.OpenAccountBack.Name = "OpenAccountBack";
            this.OpenAccountBack.Size = new System.Drawing.Size(142, 32);
            this.OpenAccountBack.TabIndex = 16;
            this.OpenAccountBack.Text = "Back";
            this.OpenAccountBack.UseVisualStyleBackColor = false;
            this.OpenAccountBack.Click += new System.EventHandler(this.OpenAccountBack_Click);
            // 
            // OpenCurrent
            // 
            this.OpenCurrent.BackColor = System.Drawing.Color.LightSeaGreen;
            this.OpenCurrent.Location = new System.Drawing.Point(19, 72);
            this.OpenCurrent.Name = "OpenCurrent";
            this.OpenCurrent.Size = new System.Drawing.Size(79, 32);
            this.OpenCurrent.TabIndex = 13;
            this.OpenCurrent.Text = "Current";
            this.OpenCurrent.UseVisualStyleBackColor = false;
            this.OpenCurrent.Click += new System.EventHandler(this.OpenAccount_Click);
            // 
            // InitialBalance
            // 
            this.InitialBalance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitialBalance.Location = new System.Drawing.Point(0, 22);
            this.InitialBalance.Name = "InitialBalance";
            this.InitialBalance.PlaceholderText = "Initial Balance";
            this.InitialBalance.Size = new System.Drawing.Size(211, 27);
            this.InitialBalance.TabIndex = 3;
            // 
            // AccountView
            // 
            this.AccountView.Location = new System.Drawing.Point(178, 334);
            this.AccountView.Name = "AccountView";
            this.AccountView.Size = new System.Drawing.Size(410, 156);
            this.AccountView.TabIndex = 19;
            this.AccountView.UseCompatibleStateImageBehavior = false;
            this.AccountView.SelectedIndexChanged += new System.EventHandler(this.AccountView_SelectedIndexChanged);
            // 
            // ListViewBack
            // 
            this.ListViewBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ListViewBack.Location = new System.Drawing.Point(520, 455);
            this.ListViewBack.Name = "ListViewBack";
            this.ListViewBack.Size = new System.Drawing.Size(68, 32);
            this.ListViewBack.TabIndex = 24;
            this.ListViewBack.Text = "Back";
            this.ListViewBack.UseVisualStyleBackColor = false;
            this.ListViewBack.Click += new System.EventHandler(this.ListViewBack_Click);
            // 
            // BankAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(999, 492);
            this.Controls.Add(this.ListViewBack);
            this.Controls.Add(this.AccountView);
            this.Controls.Add(this.OpenAccount);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.Withdrawal);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.HomePage);
            this.Controls.Add(this.RegistrationPage);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BankAppForm";
            this.Text = "MyBankApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RegistrationPage.ResumeLayout(false);
            this.RegistrationPage.PerformLayout();
            this.LogIn.ResumeLayout(false);
            this.LogIn.PerformLayout();
            this.HomePage.ResumeLayout(false);
            this.HomePage.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.LandingPage.ResumeLayout(false);
            this.LandingPage.PerformLayout();
            this.AccountStatement.ResumeLayout(false);
            this.AccountStatement.PerformLayout();
            this.LogInPage.ResumeLayout(false);
            this.LogInPage.PerformLayout();
            this.Transfer.ResumeLayout(false);
            this.Transfer.PerformLayout();
            this.Withdrawal.ResumeLayout(false);
            this.Withdrawal.PerformLayout();
            this.Deposit.ResumeLayout(false);
            this.Deposit.PerformLayout();
            this.OpenAccount.ResumeLayout(false);
            this.OpenAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox registerFirstName;
        private Button btnSubmit;
        private GroupBox RegistrationPage;
        private TextBox RegisterPassword;
        private TextBox RegisterEmail;
        private TextBox registerLastName;
        private GroupBox Menu;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private GroupBox LandingPage;
        private TextBox textBox7;
        private TextBox textBox6;
        private GroupBox AccountStatement;
        private TextBox AccountDetailsTB;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private Button button9;
        private Button button8;
        private GroupBox LogInPage;
        private TextBox textBox13;
        private TextBox textBox18;
        private Button button10;
        private GroupBox LogIn;
        private TextBox LogInPassword;
        private TextBox LogInEmail;
        private Button button1;
        private GroupBox HomePage;
        private Button button12;
        private Button button11;
        private Label label1;
        private Label label2;
        private Button RegisterHome;
        private Button LoginHome;
        private TextBox LoginMessage1;
        private GroupBox Transfer;
        private GroupBox Withdrawal;
        private GroupBox Deposit;
        private GroupBox OpenAccount;
        private Button ToOpenAccount;
        private Button OpenCurrent;
        private TextBox InitialBalance;
        private Button OpenAccountBack;
        private Button OpenSavings;
        private TextBox OpenAccountMessage;
        private Button MakeWithdrawal;
        private Button MakeDeposit;
        private TextBox WithdrawalAmount;
        private TextBox DepositAmount;
        private Button TransferBack;
        private Button MakeTransfer;
        private TextBox TransferAmount;
        private TextBox TransferFrom;
        private Button WithdrawalBack;
        private Button DepositBack;
        private ListView AccountView;
        private Button ListViewBack;
        private TextBox WithdrawalAccount;
        private TextBox DepositAccount;
        private TextBox WithdrawalDescription;
        private TextBox DepositDescription;
        private TextBox WithdrawalMessage;
        private TextBox DepositMessage;
        private TextBox TransferDescription;
        private TextBox TransferTo;
        private TextBox TransferMessage;
        private TextBox RegisterMessage;
        private TextBox RegisterMessage1;
        private TextBox RegisterMessage2;
        private TextBox LoginMessage;
        private TextBox LoginMessage2;
    }
}