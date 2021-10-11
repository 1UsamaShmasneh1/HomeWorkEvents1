using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Question1;

namespace Question1._1
{
    public partial class Form1 : Form
    {

        Person person = new Person();
        public Form1()
        {
            InitializeComponent();
            person.TooLongName += LongNameHandler;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            person.Name = NameTextBox.Text;
        }

        private void LongNameHandler()
        {
            MessageBox.Show("Great name");
        }
    }
}
