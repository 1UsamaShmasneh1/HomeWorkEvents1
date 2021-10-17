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
    public partial class Form1 : Form
    {
        User user = new User();
        public Form1()
        {
            InitializeComponent();
            UsersList.SuccessLogin += LoginHandler;
            UsersList.UnsuccessLogin += LoginHandler;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            UsersList.OnLogIn(UsernameTextBox.Text, PasswordTextBox.Text);
        }
        private void LoginHandler(User user1, string message)
        {
            if (user != null)
                user = user1;
            MessageBox.Show(message);
        }
    }
}
