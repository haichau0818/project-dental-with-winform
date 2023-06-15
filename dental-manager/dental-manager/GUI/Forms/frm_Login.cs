using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_manager.GUI.Forms
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            txt_Username.Focus();

        }

        #region Handle change textbox

        //Change text when click
        private void txt_Username_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Username...")
            {
                txt_Username.Text = "";
                txt_Username.ForeColor = Color.FromArgb(36, 134, 206);
            }

        }

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                txt_Username.Text = "Username...";
                txt_Username.ForeColor = Color.FromArgb(172, 209, 255);
            }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }


        private void txt_Password_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password...")
            {
                txt_Password.Text = "";
                txt_Password.ForeColor = Color.FromArgb(36, 134, 206);
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Password...";
                txt_Password.ForeColor = Color.FromArgb(172, 209, 255);
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_SignIn_MouseHover(object sender, EventArgs e)
        {
            btn_SignIn.BackColor = Color.FromArgb(95, 86, 208);
            btn_SignIn.ForeColor = Color.White;
            btn_SignIn.FlatAppearance.BorderSize = 0;
            btn_SignIn.FlatAppearance.BorderColor = Color.White;
        }

        private void btn_SignIn_Leave(object sender, EventArgs e)
        {
            btn_SignIn.BackColor = Color.FromArgb(172, 209, 254);
            btn_SignIn.ForeColor = Color.FromArgb(36, 134, 206);
        }

        private void btn_SignIn_MouseLeave(object sender, EventArgs e)
        {
            btn_SignIn.BackColor = Color.FromArgb(172, 209, 254);
            btn_SignIn.ForeColor = Color.FromArgb(36, 134, 206);
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            this.txt_Username.Focus();
        }
        //Minimize application click
        private void pic_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Close application click
        private void pic_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


        private void btn_SignIn_Click(object sender, EventArgs e)
        {

        }

       
    }
}
