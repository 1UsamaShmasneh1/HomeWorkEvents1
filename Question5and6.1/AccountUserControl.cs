using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Question5and6;

namespace Question5and6._1
{
    public partial class AccountUserControl : UserControl
    {
        public User User {  get; set; } = new User();
        public AccountUserControl()
        {
            InitializeComponent();
            UsersList.SuccesLogin += user =>
            {
                User = user;
                WelcomeLabel.Text = $"Welcome {user.Username}";
                TotalLabel.Text = Convert.ToString(user.TotalAmount);
            };

            UsersList.UnsuccesWithdrawal += withdrawalFailureReasons =>
            {
                switch (withdrawalFailureReasons)
                {
                    case FailedWithdrawalReasonsEnum.NotEnoughAmount:
                        MessageBox.Show("Not enough amount in your account");
                        break;
                    case FailedWithdrawalReasonsEnum.WithdrawalAmountMustBeBanknotesOfAHundred:
                        MessageBox.Show("Withdrawal amount must be banknotes of a hundred");
                        break;
                }
            };

            UsersList.UnsuccesDeposit += depositFailureReasons =>
            {
                switch (depositFailureReasons)
                {
                    case FailedDepositReasonsEnum.DepositAmountMustBeBanknotesOfAHundred:
                        MessageBox.Show("Withdrawal amount must be banknotes of a hundred");
                        break;
                }
            };
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            UsersList.LogOut(User);
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            UsersList.Deposit(Convert.ToInt32(DepositTextBox.Text), User);
        }

        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            UsersList.Withdrawal(Convert.ToInt32(WithdrawalTextBox.Text), User);
        }
    }
}
