using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxPassword.ForeColor = Color.LightGray;
        }
 // Maska Login
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Логін") 
            {
                textBoxLogin.Text = "";
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = "Логін";
                textBoxLogin.ForeColor = Color.LightGray;
            }
        }
// Maska Password
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Пароль";
                textBoxPassword.ForeColor = Color.LightGray;
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }
        // Hiding Password text
        private void eyeNoneActive_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "Пароль")
            {
                textBoxPassword.UseSystemPasswordChar = false ;
                eyeActive.Visible = true;
                eyeNoneActive.Visible = false;
            }
        }
        private void eyeActive_Click_1(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "Пароль")
            {
                textBoxPassword.UseSystemPasswordChar = true;
                eyeActive.Visible = false;
                eyeNoneActive.Visible = true;
            }
        }
        // Authorization acess
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "1" && textBoxPassword.Text == "1")
            {
                // Switching from Authorization form to form2 Main Application and close form 1.
                MainForm frm1 = new MainForm();
                frm1.Show();
                Hide();
            }
            else
            {
                DialogResult rexult = MessageBox.Show
                     ("Неправильно введенний логін чи пароль!", "Помилка авторизації",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button1);
            }
        }
    }
}
