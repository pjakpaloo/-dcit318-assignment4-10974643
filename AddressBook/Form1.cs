using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string phone = textBox3.Text;

            string message = $"Name: {name}\nEmail: {email}\nPhone: {phone}";
            MessageBox.Show(message, "Information Saved");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
