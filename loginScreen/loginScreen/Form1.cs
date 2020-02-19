using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace loginScreen
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("data.txt")) 
            {
                
            }


                string passAttempt = txtPassword.Text;
            string nameAttempt = txtUsername.Text;
            if (password == passAttempt&& username == nameAttempt)
            {
                MessageBox.Show ("All Gucci");
            }
            
            else if (password != passAttempt && username == nameAttempt)
            {
                MessageBox.Show("Incorrect Password");
            }

            else if (username != nameAttempt && nameAttempt != "")
            {
                MessageBox.Show("Username not found");
            }

        }
    }
}
