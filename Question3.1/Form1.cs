using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3._1
{
    public partial class Form1 : Form
    {
        Student studentForm = new Student();
        public Form1()
        {
            InitializeComponent();
            StudentList.Discount += DiscountHandler;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            studentForm = new Student();
            StudentList.Add(studentForm);
        }
        private void DiscountHandler(Student student)
        {
            MessageBox.Show("You get 5% discount");
        }
    }
}
