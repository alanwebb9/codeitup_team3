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
    public partial class Login : Form
    {

        public Login()
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
            List<User> Users = new List<User>();
            using (StreamReader sr = new StreamReader("data.txt")) 
            {
                string line;
                while ((line = sr.ReadLine())!= null)
                {
                    string[] items = line.Split(',');
                    Users.Add(new User(items[0], items[1], items[2]));
                }
            }


            bool accepted = false;
            string passAttempt = txtPassword.Text;
            string nameAttempt = txtUsername.Text;
            if(accepted == false)
            {
                userError.Visible = false;
                passwordError.Visible = false;
            }
            foreach (var item in Users)
            {
                if (nameAttempt == item.Name)
                {
                    if (passAttempt == item.Password)
                    {

                        accepted = true;
                        break;
                    }
                    else if (passAttempt == "")
                        ;
                    else if (passAttempt != item.Password && passAttempt != "")
                    {
                        passwordError.Visible = true;
                    }
                        
                        
                }
                else if (nameAttempt == "")
                    ;
                else if (nameAttempt != item.Name && passwordError.Visible != true)
                    userError.Visible = true;

            }

            if (accepted)
            {
                welcomeScreen welcome = new welcomeScreen();
                welcome.Show();
                this.Close();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
