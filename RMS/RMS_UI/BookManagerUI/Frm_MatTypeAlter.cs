using System;
using System.Windows.Forms;
using RMS.Command;
using RMS.Model;
using RMS.BLL;

namespace RMS.UI
{
    public partial class Frm_BookTypeAlter : Form
    {
        public Frm_BookTypeAlter()
        {
            InitializeComponent();
        }

        public Frm_BookTypeAlter(BookType bookType)
        {
            InitializeComponent();
            BookType = bookType;
        }

        private BookType _BookType;
        public BookType BookType
        {
            get { return _BookType; }
            set { _BookType = value; }
        }

        private Com com = new Com();
        private BookType_BLL bookType_BLL = new BookType_BLL();

        private void Frm_Alter_Load(object sender, EventArgs e)
        {
            tB_MatType.Text = _BookType.BookTypeName;
        }

        /// <summary>
        /// 修改类型名，确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            _BookType.BookTypeName = tB_MatType.Text.Trim();

            if(bookType_BLL.IsUpdateBookType(_BookType))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else 
            { 
                MessageBox.Show("修改失败！"); 
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
