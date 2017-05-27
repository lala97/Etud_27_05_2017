using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //string usrname = txt_username.Text;
            //string password = txt_password.Text;
            //if (usrname == "admin" && password == "123456")
            //{
               HomePage page = new HomePage();
                page.Show();
                this.Hide();

            //}
            //else
            //{
            //    btn_login.Text = "Try again";
            //    btn_login.BackColor = Color.Red;
            //    txt_username.Text = "";
            //    txt_password.Text = "";
            //    MessageBox.Show("Username or password incorrect");

            //}
        }
    }
}
