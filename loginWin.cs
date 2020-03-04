using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MaterialSkin.Controls;
using System.Linq;
using System.Text;
using ShiloAmarsProj.Controls;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiloAmarsProj
{
    public partial class loginWin : MainWin
    {
        public loginWin()
        {
            InitializeComponent();
        }

        private void userNameTextBox1_Click(object sender, EventArgs e)
        {
            if (userNameTextBox1.Text != null)
            {
                userNameTextBox1.Text = "";
                userNameTextBox1.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox2_Click(object sender, EventArgs e)
        { }

        private void passwordTextBox2_Leave(object sender, EventArgs e)
        { }

        private void userNameTextBox1_Leave(object sender, EventArgs e)
        {
            if (userNameTextBox1.Text == "")
            {
                userNameTextBox1.Text = "הכנס שם משתמש";
            }

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            fullDashBoard x = new fullDashBoard();
            MainClass.viewWindow(x, this, MDIWin.ActiveForm);
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {}

        private void passwordLine_Click(object sender, EventArgs e)
        { 
                if (passwordLine.Text == "הכנס סיסמה")
                   {
                      passwordLine.Text = "";
                      passwordLine.ForeColor = Color.Black;
                   }
            
        }

        private void passwordLine_Leave(object sender, EventArgs e)
        {

            if (passwordLine.Text == "")
            {
                passwordLine.Text = "הכנס סיסמה";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordLine.UseSystemPasswordChar = false;
            }
            else
            {
                passwordLine.UseSystemPasswordChar = true;
            }
        }
    }
} 
