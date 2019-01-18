using System;
using System.Windows.Forms;
using RMS.Command;
using RMS.BLL;
using RMS.Model;
using System.Collections.Generic;

namespace RMS.UI
{
    public partial class Frm_BookInfoEdit : Form
    {
        public Frm_BookInfoEdit()
        {
            InitializeComponent();
        }

        public Frm_BookInfoEdit(string tempBookGuid)
        {
            InitializeComponent();
            BookGuid = tempBookGuid;
        }

        private  Enum_EditOp Flag;
        
        private string _BookGuid;
        public string BookGuid
        {
            get
            { 
                return _BookGuid; 
            }
            set 
            {
                if (value == string.Empty)
                {
                    _BookGuid = string.Empty;
                    Flag = Enum_EditOp.Add;
                }
                else
                {
                    _BookGuid = value;
                    Flag = Enum_EditOp.Alter;
 
                }

            }
        }

        Com com = new Com();
        BookInfo_BLL bookInfo_BLL = new BookInfo_BLL();
        BookType_BLL bookType_BLL = new BookType_BLL();


        public void Frm_BookInfoEdit_Load(object sender, EventArgs e)
        {
            Init_cbb_BookType();
            Init_cbb_BookLanType();
            Init_BookInfoEdit();
        }

        private void Init_BookInfoEdit()
        {
            switch (Flag)
            {
                case Enum_EditOp.Add:
                    this.Text = "添加图书信息";
                    break;
                case Enum_EditOp.Alter:
                    this.Text = "修改图书信息";
                    Init_BookInfo();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 初始化图书类型下拉菜单
        /// </summary>
        private void Init_cbb_BookType()
        {
            cbb_BookType.DataSource = bookType_BLL.SelectBookType();
            cbb_BookType.DisplayMember = "BookTypeName";
            cbb_BookType.ValueMember = "BookTypeGuid";
        }

        /// <summary>
        /// 初始化语言类型下拉菜单
        /// </summary>
        private void Init_cbb_BookLanType()
        {
            cbb_BookLanType.Items.Add("中文");
            cbb_BookLanType.Items.Add("英语");
            cbb_BookLanType.Items.Add("德文");
            cbb_BookLanType.SelectedIndex = 0;
        }

        /// <summary>
        /// 初始化其他相关信息
        /// </summary>
        private void Init_BookInfo()
        {
            BookInfo_View bookInfo_V = bookInfo_BLL.SelectBookInfo_V(BookGuid);
            tb_BookISBN.Text = bookInfo_V.BookISBN;
            tb_BookRawName.Text = bookInfo_V.BookRawName;
            tb_BookCNName.Text = bookInfo_V.BookCNName;
            tb_BookAuthorName.Text = bookInfo_V.BookAuthor;
            tb_BookPress.Text = bookInfo_V.BookPress;
            tb_BookNumber.Text = (bookInfo_V.BookNumber).ToString();
            dtp_BookPubDate.Value = bookInfo_V.BookPubDate;
            dtp_BookBuyDate.Value = bookInfo_V.BookBuyDate;
            tb_BookBuyPerson.Text = bookInfo_V.BookBuyPerson;
            tb_BookBuyShop.Text = bookInfo_V.BookBuyShop;

            cbb_BookType.Text = bookInfo_V.BookTypeName;
            cbb_BookLanType.Text = bookInfo_V.BookLanType;
            tb_BookAnno.Text = bookInfo_V.BookAnnotation;
        }

        /// <summary>
        /// 保存按钮根据标识选择操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            switch (Flag)
            {
                case Enum_EditOp.Add:
                    AddBookInfo();
                    break;
                case Enum_EditOp.Alter:
                    AlterBookInfo();
                    break;
                default:
                    break;
            }
            this.Close();
        }

        /// <summary>
        /// 修改图书信息
        /// </summary>
        private void AlterBookInfo()
        {
            if ((MessageBox.Show("是否确定修改？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)) == DialogResult.No)
            {
                return;
            }
            if (tb_BookISBN.Text.Trim() == "")//资料编号必须唯一
            {
                MessageBox.Show("图书编号不能为空！！！");
                return;
            }
            else if (tb_BookRawName.Text.Trim() == "")
            {
                MessageBox.Show("图书名称不能为空！！！");
                return;
            }
            //创建修改的对象
            BookInfo_Table bookInfo_T = new BookInfo_Table(
                Guid.NewGuid().ToString(),
                tb_BookISBN.Text.Trim().ToString(),
                tb_BookRawName.Text.Trim().ToString(),
                tb_BookCNName.Text.Trim().ToString(),
                tb_BookAuthorName.Text.Trim().ToString(),
                tb_BookPress.Text.Trim().ToString(),
                dtp_BookPubDate.Value,
                Convert.ToInt32(tb_BookNumber.Text.Trim().ToString()),
                dtp_BookBuyDate.Value,
                tb_BookBuyPerson.Text.Trim().ToString(),
                tb_BookBuyShop.Text.Trim().ToString(),
                cbb_BookType.SelectedValue.ToString(),
                cbb_BookLanType.SelectedText.Trim().ToString(),
                tb_BookAnno.Text.Trim().ToString(),
                false);

            if (bookInfo_BLL.UpdateMatInfo(bookInfo_T))
            {
                MessageBox.Show("修改信息成功！");
                DialogResult = DialogResult.OK;//返回添加成功
            }
            else
            {
                MessageBox.Show("修改信息失败！");
            }
        }

        /// <summary>
        /// 添加图书信息
        /// </summary>
        private void AddBookInfo()
        {
            //图书编号必须唯一
            if (tb_BookISBN.Text.Trim() == "")
            {
                MessageBox.Show("图书ISBN不能为空！！！");
            }
            else if (tb_BookRawName.Text.Trim() == "")
            {
                MessageBox.Show("图书原名称不能为空！！！");
            }
            else if (tb_BookNumber.Text == "")
            {
                MessageBox.Show("图书份数不能为空！！！");
            }
            else
            {
                //创建添加的对象
                BookInfo_Table bookInfo = new BookInfo_Table(
                    Guid.NewGuid().ToString(),
                    tb_BookISBN.Text.Trim().ToString(),
                    tb_BookRawName.Text.Trim().ToString(),
                    tb_BookCNName.Text.Trim().ToString(),
                    tb_BookAuthorName.Text.Trim().ToString(),
                    tb_BookPress.Text.Trim().ToString(),
                    dtp_BookPubDate.Value,
                    Convert.ToInt32(tb_BookNumber.Text.Trim().ToString()),
                    dtp_BookBuyDate.Value,
                    tb_BookBuyPerson.Text.Trim().ToString(),
                    tb_BookBuyShop.Text.Trim().ToString(),
                    cbb_BookType.SelectedValue.ToString(),
                    cbb_BookLanType.Text.Trim().ToString(),
                    tb_BookAnno.Text.Trim().ToString(),
                    false);

                if (true == bookInfo_BLL.AddBookInfo(bookInfo))
                {
                    //返回添加成功
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("添加失败！！！");
                }
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
