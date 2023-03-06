using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //从文本框中获取新班级，添加到班级列表框中
            string nClass = txtClass.Text.ToString();
            if (nClass != string.Empty)
                lstClass.Items.Add(nClass);
        }
        private void btnDelete_Cilck(object sender, EventArgs e)
        {
            //从列表框中移除相应的项
            int nIndex = lstClass.SelectedIndex;
            if (nIndex >= 0)
                lstClass.Items.Remove(nIndex);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string nClass = txtClass.Text.ToString();
            int nIndex = lstClass.FindString(nClass);
            if (nIndex != -1)  //如果找到相应信息，设置该信息高亮显示
                lstClass.SetSelected(nIndex, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
