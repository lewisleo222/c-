using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sUser = txtUser.Text.ToString();
            string sPsw = txtPsw.Text.ToString();
            if (CheckUser(sUser, sPsw) != 0)
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
                lblLoginError.Text = "你的信息有误！";
        }
        private int CheckUser(string User,string Psw)
        {
            if (User == "Admin" && Psw == "123")
                return 1;
            else
                return 0;
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Form frm = sender as Form;
            if (frm != null)
            {
                frm.Text = "登录窗体";
            }
        }

        private void FrmLogin_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void FrmLogin_Deactivate(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 将取消按钮的 DialogResult 属性设置为 Cancel
            this.DialogResult = DialogResult.Cancel;

            // 清空文本框内容
            txtUser.Text = "";
            txtPsw.Text = "";
            // 以此类推
        }
    }
}
