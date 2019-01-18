using System;
using System.Windows.Forms;
using RMS.Command;
using RMS.BLL;
using RMS.Model;

/***************************************************************************
 * 2017年06月15日
 * 资料类型管理
 * 删除
 * 添加
 * 修改
 * 
 * 
 * */

namespace RMS.UI
{
    public partial class Frm_BookTypeManager : Form
    {
        public Frm_BookTypeManager()
        {
            InitializeComponent();
        }

        public BookType_BLL BookType_BLL = new BookType_BLL();
        Com auto = new Com();

        private void Frm_BookTypeManager_Load(object sender, EventArgs e)
        {
            Init_dGV_BookType();
        }

        /// <summary>
        /// 初始化图书类型dgv
        /// </summary>
        private void Init_dGV_BookType()
        {
            ShowLayout_dgv_BookType();

            ShowData_dgv_BookType();
        }

        /// <summary>
        /// 显示dgv格式
        /// </summary>
        private void ShowLayout_dgv_BookType()
        {
            string HeaderText = "Guid,类型名称";
            string DataPropertyNames = "BookTypeGuid,BookTypeName";
            dgv_BookType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //自动生成列
            auto.AutoColumn(HeaderText, DataPropertyNames, dgv_BookType);
            auto.AddColumn("修改", dgv_BookType);
            auto.AddColumn("删除", dgv_BookType);

            dgv_BookType.Columns[0].Visible = false;
        }

        /// <summary>
        /// 显示dgv类型数据
        /// </summary>
        private void ShowData_dgv_BookType()
        {
            dgv_BookType.DataSource = BookType_BLL.SelectBookType();
        }

        /// <summary>
        /// 添加图书类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddMatType_Click(object sender, EventArgs e)
        {
            BookType bookType = new BookType();
            bookType.BookTypeName = tB_BookType.Text.Trim();
            bookType.BookTypeGuid = Guid.NewGuid().ToString();

            if (bookType.BookTypeName =="")
            {
                MessageBox.Show("资料类型名不能为空，请重新输入！！！");
            }
            else if (BookType_BLL.IsBookTypeHaving(bookType.BookTypeName))
            {
                MessageBox.Show("该类型已存在，请重新输入！！！");

            }
            else if (BookType_BLL.AddBookTypeInfo(bookType) == true)
            {
                MessageBox.Show("添加成功！");
                ShowData_dgv_BookType();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
            tB_BookType.Clear();            
        }

        /// <summary>
        /// 资料类型表的单元格单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGV_MatType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //选中行的图书编号
            BookType tmpBookType = new BookType();
            try
            {
                tmpBookType.BookTypeGuid=dgv_BookType.Rows[e.RowIndex].Cells[0].Value.ToString();
                tmpBookType.BookTypeName = dgv_BookType.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            { 
            }

            //dGV_MatType的总列数
            int colCount = dgv_BookType.Columns.Count;

            if (e.ColumnIndex == colCount - 2)//修改
            {
                EditBookType(tmpBookType);
            }
            else if (e.ColumnIndex == colCount - 1)//删除
            {
                DeleteBookType(tmpBookType);
            }
        }

        private void DeleteBookType(BookType bookType)
        {
            DialogResult result = MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (BookType_BLL.deleteBookType(bookType.BookTypeGuid))
                {
                    MessageBox.Show("删除成功！");
                    ShowData_dgv_BookType();
                }
                else
                {
                    MessageBox.Show("删除失败！！！");
                }
            }
        }

        private void EditBookType(BookType bookType)
        {
            Frm_BookTypeAlter frmMatTypeAlter = new Frm_BookTypeAlter(bookType);

            DialogResult result = frmMatTypeAlter.ShowDialog();
            if (result == DialogResult.OK)
            {
                ShowData_dgv_BookType();
            }
        }

        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
