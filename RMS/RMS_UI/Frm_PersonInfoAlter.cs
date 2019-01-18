using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RMS.BLL;
using RMS.Model;
using RMS.Command;

namespace RMS.UI
{
    public partial class Frm_PersonInfoAlter : Form
    {
        public Frm_PersonInfoAlter()
        {
            InitializeComponent();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Standard;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
        }

        public Frm_PersonInfoManager reader = null;
        public string ReaderId = null;

        PersonInfo_BLL reader_bll = new PersonInfo_BLL();
        UserType_BLL readerType_bll = new UserType_BLL();
        Department_BLL department_bll = new Department_BLL();
        Com com = new Com();

        public void ReaderExit_UI_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PersonInfo r = new PersonInfo();


            if (reader_bll.updateReader(r) > 0)
            {
                MessageBox.Show("修改成功！");
                //单价查询
                reader.btnSelect_Click(null, null);

                //自动找到刚刚修改成功的行，并选中
                com.AutoFindRow(txtReaderId.Text.Trim(),reader.dgv_UserInfo);
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        //读者类型编辑
        private void button4_Click(object sender, EventArgs e)
        {
            //Frm_MatTypeAdd a = new Frm_MatTypeAdd();
            //a.tabName = "读者类型";
            //a.readerExit = this;
            //a.readerManager = this.reader;
            //a.ShowDialog();
        }

        //院系编辑
        private void button3_Click(object sender, EventArgs e)
        {
            //Frm_MatTypeAdd a = new Frm_MatTypeAdd();
            //a.tabName = "院系";
            //a.readerExit = this;
            //a.readerManager = this.reader;
            //a.ShowDialog();
        }

        //班级编辑
        private void button5_Click(object sender, EventArgs e)
        {
            //Frm_MatTypeAdd a = new Frm_MatTypeAdd();
            //a.tabName = "班级";
            //a.readerExit = this;
            //a.readerManager = this.reader;
            //a.ShowDialog();
        }

       
    }
}
