using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question5and6._1
{
    public partial class BankForm : Form
    {
        public User User { get; set; } = new User();
        public BankForm()
        {
            InitializeComponent();
            LoginUserControl loginUserControl= new LoginUserControl();
            AccountUserControl accountUserControl = new AccountUserControl();
            BankFormPanel.Controls.Add(loginUserControl);
            loginUserControl.Dock = DockStyle.Fill;
            UsersList.SuccesLogin += user =>
            {
                loginUserControl = new LoginUserControl();
                BankFormPanel.Controls.Clear();
                MessageBox.Show("Welcome " + user.Username + "!");
                BankFormPanel.Controls.Add(accountUserControl);
                accountUserControl.Dock = DockStyle.Fill;
                User = user;
            };
            UsersList.UnsuccesLogin += LoginFailureReasons =>
            {
                switch (LoginFailureReasons)
                {
                    case FailedLoginReasonsEnum.UserNameDoesNotExist:
                        MessageBox.Show("User name not found");
                        break;
                    case FailedLoginReasonsEnum.WrongPassword:
                        MessageBox.Show("Wrong password");
                        break;
                }
            };
            UsersList.LogOutE += user1 =>
            {
                accountUserControl = new AccountUserControl();
                User = new User();
                BankFormPanel.Controls.Clear();
                UsersList.LogOutE += user => MessageBox.Show($"Good by {user.Username}");
                BankFormPanel.Controls.Add(loginUserControl);
                loginUserControl.Dock = DockStyle.Fill;
            };
        }
    }
}
