using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RMS.BLL;
using RMS.Command;
using RMS.Model;

namespace RMS.UI
{
    public partial class Frm_PersonInfoManager : Form
    {
        #region 单例模式
        private static Frm_PersonInfoManager _instance = null;
        public Frm_PersonInfoManager()
        {
            InitializeComponent();
        }
        public static Frm_PersonInfoManager CreateInstance()
        {
            if (_instance == null)
            {
                _instance = new Frm_PersonInfoManager();
            }
            return _instance;
        }
        #endregion

        public Frm_BookInfoManager frmBookInfoManager;
        Com autocoumns = new Com();
        public PersonInfo_BLL userInfo_BLL = new PersonInfo_BLL();
        UserType_BLL UserType_BLL = new UserType_BLL();

        /// <summary>
        /// 树状图的绑定
        /// </summary>
        public void TreeViewBand()
        {
            //人员类型的集合
            //List<UserType> list = UserType_BLL.SelectPersonType();
            //TreeNode node = new TreeNode();
            //node.Text = "人员类型";
            //node.ImageIndex = 0;
            //treeView1.Nodes.Add(node);

            //foreach (UserType k in list)
            //{
            //    TreeNode n = new TreeNode();
            //    n.Text = k.UserTypeName;
            //    n.Tag = k.UserTypeGuid;
            //    n.ImageIndex = 0;
            //    node.Nodes.Add(n);
            //}
            //treeView1.ExpandAll();
        }



        //人员管理窗体的加载事件
        public  void UserInfoManager_UI_Load(object sender, EventArgs e)
        {
            ShowLayout_dgv_UserInfo();

            ShowData_dgv_PersonInfo();

            #region 下拉框绑定

            DataGridViewColumnCollection columns = dgv_UserInfo.Columns;

            for (int i = 0; i < columns.Count - 2; i++)
            {
                comboBox1.Items.Add(columns[i].HeaderText);
            }
            comboBox1.Items.Insert(0, "全部");
            comboBox1.SelectedIndex = 0;

            #endregion


            //树状图的绑定

            //TreeViewBand();

            #region DataGridView3的绑定 已借阅的图书信息表

            //dataGridView3.AutoGenerateColumns = false;
            //需要添加列的列标题字符串
            string arraysHeaderText1 = @"读者编号,读者名称,图书编号,图书名称,借出时间,书应归还时间,实际归还时间,应付罚金,续借次数,借还描述";
            //需要绑定数据库列名称的字符串
            string arraysName1 = @"ReaderId,ReaderName,BookId,BookName,BorrowTime,ReturnTime,FactReturnTime,Fine,RenewCount,BorrowRemark";

            //自动生成columns
            autocoumns.AutoColumn(arraysHeaderText1, arraysName1, dgvReaderBorrowBook);

            //string index = dgvHeaderInfo.Rows[0].Cells[0].Value.ToString();
            //DataGridView1数据集绑定
            //this.dgvReaderBorrowBook.DataSource = borrowReturn_bll.ReaderBorrowReturn(index).Tables[0];

            #endregion
        }

        /// <summary>
        /// 可以改成登陆操作等信息
        /// </summary>
        private void Init_dgv_BorrowInfo()
        {
            ////dataGridView2.AutoGenerateColumns = false;
            ////需要添加列的列标题字符串
            //string arraysHeaderText2 = @"读者编号,读者名称,图书编号,图书名称,借出时间,书应归还时间,实际归还时间,应付罚金,续借次数,借还描述";
            ////需要绑定数据库列名称的字符串
            //string arraysName2 = @"ReaderId,ReaderName,BookId,BookName,BorrowTime,ReturnTime,FactReturnTime,Fine,RenewCount,BorrowRemark";

            ////自动生成columns
            //autocoumns.AutoColumn(arraysHeaderText2, arraysName2, dgvReaderBorrowBookInfoed);

            //string index1 = dgv_PersonInfo.Rows[0].Cells[0].Value.ToString();
            ////DataGridView1数据集绑定
            //this.dgvReaderBorrowBookInfoed.DataSource = borrowReturn_bll.ReaderBorrowReturn1(index1).Tables[0];
            //dgvReaderBorrowBookInfoed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// dgv显示用户数据
        /// </summary>
        public void ShowData_dgv_PersonInfo()
        {
            //dgvHeaderInfo数据集绑定
            dgv_UserInfo.DataSource = userInfo_BLL.SelectPerson();

        }

        /// <summary>
        /// dgv显示用户信息
        /// </summary>
        public  void ShowLayout_dgv_UserInfo()
        {
            dgv_UserInfo.Columns.Clear();
            //需要添加列的列标题字符串
            string arraysHeaderText = @"Guid,编号,姓名,性别,电话,描述";
            //需要绑定数据库列名称的字符串
            string arraysName = @"PersonGuid,PersonID,PersonName,Sexy,Phone,Anno";

            //自动生成columns
            autocoumns.AutoColumn(arraysHeaderText, arraysName, dgv_UserInfo);
            autocoumns.AddColumn("修改", dgv_UserInfo);
            autocoumns.AddColumn("删除", dgv_UserInfo);
            dgv_UserInfo.Columns[0].Visible = false;
        }

        //TreeView节点选项改变事件
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Level == 0)
            {
                dgv_UserInfo.DataSource = userInfo_BLL.SelectPerson();
            }
            else if (treeView1.SelectedNode.Level == 1)
            {
                string index = treeView1.SelectedNode.Tag.ToString();
                dgv_UserInfo.DataSource = userInfo_BLL.SelectPersonInfo(index);
            }

            //如果读者信息表中查不到一条数据，相关表的数据也清空
            if (dgv_UserInfo.Rows.Count == 0)
            {
                dgvReaderBorrowBookInfoed.DataSource = null;
                dgvReaderBorrowBook.DataSource=null;
                return;
            }
        }

       
      
        private void btnExitColumn_Click(object sender, EventArgs e)
        {
            //BookInfoExitRows_UI b = new BookInfoExitRows_UI();
            //b.Reader = this;
            //b.ShowDialog();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ReaderId = "";
            try
            {
                //选中行的图书编号
                ReaderId = dgv_UserInfo.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            catch (Exception) { }

            //DataGridView的总列数
            int rows = dgv_UserInfo.Columns.Count;

            if (e.ColumnIndex == rows - 2)//修改
            {
                Frm_PersonInfoAlter b = new Frm_PersonInfoAlter();
                b.reader = this;
                b.ReaderId = ReaderId;
                b.ShowDialog();
            }
            else if (e.ColumnIndex == rows - 1)//删除
            {
                DialogResult result = MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (userInfo_BLL.deleteReader(ReaderId) > 0)
                    {
                        btnSelect_Click(null, null);
                        //历史记录表中的数据引用着读者信息表的数据，删除读者信息应该刷新历史记录表
                        //frmMatInfoManager.dgv_BorrowHistory.DataSource = frmMatInfoManager.borrowHistory_BLL.selectBorrowReturn(frmMatInfoManager.selectedMatID).Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
        }

        //当编辑绑定完 DataGridView所有单元格之后，执行绘制引发的事件
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
               e.RowBounds.Location.Y,
               dgv_UserInfo.RowHeadersWidth - 4,
               e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgv_UserInfo.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgv_UserInfo.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        public Frm_PersonInfoAdd readerAdd;
        public void btnAddReaderInfo_Click(object sender, EventArgs e)
        {
            readerAdd = new Frm_PersonInfoAdd();
            readerAdd.personInfoManager = this;
            readerAdd.ShowDialog();
        }

        //单击查询按钮
        public  void btnSelect_Click(object sender, EventArgs e)
        {
            DataGridViewColumnCollection columns = dgv_UserInfo.Columns;
            if (comboBox1.SelectedIndex == 0)//全部
            {
                List<string> list = new List<string>();
                for (int i = 0; i < columns.Count - 2; i++)
                {
                    list.Add(columns[i].DataPropertyName);
                }
                string B = textBox1.Text.Trim();
                dgv_UserInfo.DataSource = userInfo_BLL.selectReader(list, B).Tables[0];
            }
            else
            {

                for (int i = 0; i < columns.Count - 2; i++)
                {
                    if (comboBox1.SelectedItem.ToString() == columns[i].HeaderText)
                    {
                        string A = columns[i].DataPropertyName;
                        string B = textBox1.Text.Trim();
                        //dgv_PersonInfo.DataSource = personInfo_BLL.selectReader(A, B).Tables[0];
                        break;
                    }
                }
            }

            //如果读者信息表中查不到一条数据，相关表的数据也清空
            if (dgv_UserInfo.Rows.Count == 0)
            {
                dgvReaderBorrowBookInfoed.DataSource = null;
                dgvReaderBorrowBook.DataSource = null;
                return;
            }
        }



    }
}
