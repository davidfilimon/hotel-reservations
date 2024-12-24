using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_tap
{
    public partial class Form1 : Form
    {
        
        // initalizare pagina login
        public Form1()
        {
            InitializeComponent();
            this.Text = "Login";
            this.FormClosing += new FormClosingEventHandler(CloseApplication);
        }


        // buton login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // preluare date
            string username = userBox.Text;
            string password = passwordBox.Text;

            if (!string.IsNullOrEmpty(userBox.Text) && !string.IsNullOrEmpty(passwordBox.Text)) // validator
            {
                if (verifyLogin(username, password)) // validator
                {
                    Form2 form2 = new Form2(); // initializare pagina principala
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username sau parola gresita.", "Eroare", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Va rugam nu lasati spatii libere.", "Invalid", MessageBoxButtons.OK);
            }
        }

        private bool verifyLogin(string username, string password) // datele de logare hardcoded
        {
            return username == "admin" && password == "1234";
        }
        
        // oprirea proceselor aplicatiei odata cu inchiderea ei
        private void CloseApplication(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
