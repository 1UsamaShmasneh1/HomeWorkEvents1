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
    public partial class TotalAmountDepostedButton : UserControl
    {
        public TotalAmountDepostedButton()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            UsersList.Login(UsernameTextBox.Text, PasswordTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total Amount deposited to th bank:  {UsersList.totalAmountDeposited}");
        }
    }
}
