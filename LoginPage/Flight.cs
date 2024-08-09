using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Flight : Form
    {
        public Flight()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;

            if(username == "Raymond" && password == "123")
            {
                MessageBox.Show("Login successful!");
                TravelRegister travelRegister = new TravelRegister();
                travelRegister.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid password or user please try again");
            }
        }
    }
}
