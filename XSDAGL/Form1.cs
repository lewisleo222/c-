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
            // 获取选中的项
            string selectedItem = lstClass.SelectedItem.ToString();

            // 从列表框中移除选中项
            lstClass.Items.Remove(selectedItem);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 获取选中的项
            string selectedItem = lstClass.SelectedItem.ToString();

            // 从列表框中移除选中项
            lstClass.Items.Remove(selectedItem);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int nIndex = lstClass.SelectedIndex;
            string nClass = txtClass.Text.ToString();
            if(nIndex>=0&&nClass!=string.Empty)
            {
                lstClass.Items.RemoveAt(nIndex);
                lstClass.Items.Insert(nIndex, nClass);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            txtCount.Text = lstClass.Items.Count.ToString();
        }
        private void btnClear_Click(object sender,EventArgs e)
        {
            lstClass.Items.Clear();
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cboUser.SelectedItem)!="管理员")
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnClear.Enabled = false;
            }
        }
    }
}
