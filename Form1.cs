using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArcanecfgFacebookLogin;

namespace FB_LogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArcanecfgFacebookLogin.ArcanecfgFacebookLogin login = new ArcanecfgFacebookLogin.ArcanecfgFacebookLogin();
            if(login.Login(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("The Account Is Exist!!", "EXIST!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly, false);
            }
            else
            {
                MessageBox.Show("Error The Account Doesn't Exist!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button3,MessageBoxOptions.DefaultDesktopOnly,false);
            }
        }
    }
}
