using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GIP_Programma_JonasCassaer_MatteoSarens
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();

            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HomeScreen homescreen = new HomeScreen();
            homescreen.ShowDialog();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void chbViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbViewPassword.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else if (chbViewPassword.Checked == false)
            {
                txtPassword.PasswordChar = '●';
            }
        }


    }
}
