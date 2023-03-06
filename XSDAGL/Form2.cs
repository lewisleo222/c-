using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XSDAGL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 检查用户名文本框的文本是否为空
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                // 如果为空，则禁用登录按钮
                btnLogin.Enabled = false;
            }
            else
            {
                // 如果不为空，则启用登录按钮
                btnLogin.Enabled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sUser = txtUser.Text.ToString();
            string sPsw = txtPsw.Text.ToString();
            if (CheckUser(sUser, sPsw) !=0)
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
                lblMessage.Text = "用户名或密码出错,请重新输入";

        }
        private int CheckUser(string User ,string Psw)
        {
            if (User == "Admin" && Psw == "12345")
                return 1;
            else
                return 0;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPsw.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            btnLogin.Enabled = false;
        }
    }
}
