using System;
using System.Windows.Forms;
using RMS.BLL;
using RMS.Command;
using RMS.Model;

namespace RMS.UI
{
    public partial class Frm_PersonTypeManager : Form
    {
        public Frm_PersonTypeManager()
        {
            InitializeComponent();
        }

        public UserType_BLL personType_BLL = new UserType_BLL();
        Com auto = new Com();


        private void Frm_PersonTypeAdd_Load(object sender, EventArgs e)
        {
            Init_dgv_PersonType();
        }

        /// <summary>
        /// 初始化人员类型表
        /// </summary>
        private void Init_dgv_PersonType()
        {
            ShowLayout_dGV_PersonType();

            ShowData_dGV_PersonType();
        }


        /// <summary>
        /// 设置dgv的显示格式
        /// </summary>
        private void ShowLayout_dGV_PersonType()
        {
            string headerText = "Guid,人员类型";
            string dataPropertyNames = "ReaderTypeId,ReaderTypeName";
            dgv_PersonType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //自动生成列
            auto.AutoColumn(headerText, dataPropertyNames, dgv_PersonType);
            auto.AddColumn("修改", dgv_PersonType);
            auto.AddColumn("删除", dgv_PersonType);
        }

        /// <summary>
        /// 设置dgv显示的数据
        /// </summary>
        private void ShowData_dGV_PersonType()
        {
            //dgv_PersonType.Rows.Clear();
            //dgv_PersonType.DataSource = personType_BLL.SelectPersonType();
            //dgv_PersonType.Columns[0].Visible = false;
        }

        /// <summary>
        /// 添加用户类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            UserType personType= new UserType();
            personType.UserTypeName=tb_PersonType.Text.Trim();
            if (personType.UserTypeName == "")
            {
                MessageBox.Show("人员类型名不能为空，请重新输入！！！");
            }
            else if (personType_BLL.IsPersonTypeHaving(personType.UserTypeName))
            {
                MessageBox.Show("该类型已存在，请重新输入！！！");
            }
            else if (personType_BLL.AddPersonType(personType) == true)
            {
                MessageBox.Show("添加成功！");
                ShowData_dGV_PersonType();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
            tb_PersonType.Clear();
        }

        /// <summary>
        /// 人员类型表的单元格单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_PersonType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //选中行的人员编号
            string str = "";
            try
            {
                str = dgv_PersonType.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            }
            catch (Exception) { }

            //dgv_PersonType的总列数
            int colCount = dgv_PersonType.Columns.Count;

            if (e.ColumnIndex == colCount - 2)//修改
            {
                UserType personType = new UserType();
                personType.UserTypeGuid = str;
                personType.UserTypeName = dgv_PersonType.Rows[e.RowIndex].Cells[1].Value.ToString();


                Frm_PersonTypeAlter frmPersonTypeAlter = new Frm_PersonTypeAlter();
                frmPersonTypeAlter.frmPersonTypeManager=this;
                frmPersonTypeAlter.personType=personType;
                frmPersonTypeAlter.ShowDialog();
            }
            else if (e.ColumnIndex == colCount - 1)//删除
            {
                DialogResult result = MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (personType_BLL.deletePersonType(str))
                    {
                        MessageBox.Show("删除成功！");
                        ShowData_dGV_PersonType();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！！！");
                    }
                }
            }
        }


        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            //AfterClosed();
        }

        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            //AfterClosed();
            this.Close();
        }

        /// <summary>
        /// 关闭以后刷新
        /// </summary>
        private void AfterClosed()
        {
            //if (bookInfoExit != null)
            //{
            //    bookInfoExit.BookInfoExit_UI_Load(null, null);
            //}
            //if (readerExit != null)
            //{
            //    readerExit.ReaderExit_UI_Load(null, null);
            //}
            //if (Manager != null)
            //{
            //    Manager.tV_MatType.Nodes.Clear();
            //    Manager.TreeViewBand();
            //    Manager.btnSelect_Click(null, null);
            //}
            //if (bookInfoAdd != null)
            //{
            //    bookInfoAdd.BookInfoAdd_UI_Load(null, null);
            //}
            //if (readerManager != null)
            //{
            //    readerManager.treeView1.Nodes.Clear();
            //    readerManager.TreeViewBand();
            //    readerManager.btnSelect_Click(null, null);
            //}
        }
    }
}
