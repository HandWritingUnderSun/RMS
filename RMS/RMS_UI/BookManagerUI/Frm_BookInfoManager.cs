using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RMS.BLL;
using RMS.Command;
using RMS.Model;
using Excel = Microsoft.Office.Interop.Excel;

namespace RMS.UI
{
    public partial class Frm_BookInfoManager : Form
    {
        #region 单例模式
        private static Frm_BookInfoManager _instance = null;
        private Frm_BookInfoManager()
        {
            InitializeComponent();
        }
        public static Frm_BookInfoManager CreateInstance()
        {
            if (_instance == null)
            {
                _instance = new Frm_BookInfoManager();
            }
            return _instance;
        }
        #endregion

        Com autocolumns = new Com();
        BookInfo_BLL bookInfo_BLL = new BookInfo_BLL();
        BookType_BLL bookType_BLL = new BookType_BLL();
        List<string> checkedBookTypeList = new List<string>();

        public void Frm_BookInfoManager_Load(object sender, EventArgs e)
        {
            ShowLayout_dgv_BookInfo();
            Init_treeV_BookType();
            Init_cbo_PubYear();
            Init_cbb_BookBigType();
        }

        /// <summary>
        /// 初始化dgv_BookInfo显示格式
        /// </summary>
        public void ShowLayout_dgv_BookInfo()
        {
            //这两处不能放回车，否则不显示
            //需要添加列的列标题字符串
            string dgv_MatInfoHeaderText = @"Guid,ISBN,图书原名,图书中文名,图书作者,出版社,出版日期,数量,购买日期,购买人,购买商店,图书类型,图书语言,描述";
            //需要绑定数据库列名称的字符串
            string dgv_MatInfoName = @"BookGuid,BookISBN,BookRawName,BookCNName,BookAuthor,BookPress,BookPubDate,BookNumber,BookBuyDate,BookBuyPerson,BookBuyShop,BookTypeName,BookLanType,BookAnnotation";

            //自动生成columns，包括删除、修改和查看
            autocolumns.AutoColumn(dgv_MatInfoHeaderText, dgv_MatInfoName, dgv_BookInfo);
            autocolumns.AddColumn("修改", dgv_BookInfo);
            autocolumns.AddColumn("删除", dgv_BookInfo);
            autocolumns.AddColumn("查看", dgv_BookInfo);
            //隐藏guid列
            dgv_BookInfo.Columns[0].Visible = false;

            //窗体加载时默认隐藏的列
            int columnCount = dgv_BookInfo.Columns.Count;
            for (int i = columnCount - 6; i < columnCount-3; ++i)
            {
                dgv_BookInfo.Columns[i].Visible = false;
            }
        }


        #region 树

        /// <summary>
        /// 初始化树的样式
        /// </summary>
        public void Init_treeV_BookType()
        {
            treeV_BookType.CheckBoxes = true;
            treeV_BookType.Nodes.Clear();

            List<BookType> pBookList = bookType_BLL.SelectBookType();
            TreeViewBand("实体书",pBookList);
            List<BookType> eBookList = bookType_BLL.SelectBookType();
            TreeViewBand("电子书",eBookList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tV_MatType_AfterCheck(object sender, TreeViewEventArgs e)
        {
            ShowCheckedNode(e);

            GetCheckedNode();

            ShowDataToDataGridView();
        }

        /// <summary>
        /// 获取选中节点的集合
        /// </summary>
        /// <param name="tnc"></param>
        private void GetCheckedNode()
        {
            checkedBookTypeList.Clear();
            foreach (TreeNode node in treeV_BookType.TopNode.Nodes)
            {
                if (node.Checked)
                {
                    checkedBookTypeList.Add(node.Text.ToString().Trim());
                }
            }
        }


        /// <summary>
        /// 初始化图书类型树
        /// 带根节点的
        /// </summary>
        public void TreeViewBand(string rootNodeName, List<BookType> list)
        {
            treeV_BookType.Sort();

            TreeNode nod = new TreeNode();
            nod.Text = rootNodeName;
            nod.ImageIndex = 0;
            treeV_BookType.Nodes.Add(nod);

            foreach (BookType k in list)
            {
                TreeNode node = new TreeNode();
                node.Text = k.BookTypeName;
                node.Tag = k.BookTypeGuid;
                node.ImageIndex = 0;
                nod.Nodes.Add(node);
            }
            treeV_BookType.ExpandAll();
        }

        /// <summary>
        /// 树在点选后的逻辑
        /// </summary>
        /// <param name="e"></param>
        private void ShowCheckedNode(TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                TreeNode tn = e.Node;//选中的节点
                if (tn.Checked)//如果选中的话
                {
                    if (tn.Parent != null)
                    {
                        tn.Parent.Checked = true;
                        if (tn.Parent.Parent != null)
                        {
                            tn.Parent.Parent.Checked = true;
                        }
                    }
                    TV_Check(tn, true); //本身节点之下还有子节点，遍历，全选中   
                }
                else//若是取消选中
                {
                    TV_Check(tn, false);//本身节点之下还有子节点，遍历，全取消选中 
                    if (tn.Parent != null)
                    {
                        //若有父节点，判断此次取消选中后，是否兄弟节点也是没选中？               
                        TreeNode TNP = tn.Parent;
                        bool YXZ = false;//有选中的，以此来判断否兄弟节点也是没选中
                        foreach (TreeNode childTN in TNP.Nodes)
                        {
                            if (childTN.Checked)
                            {

                                YXZ = true;//还有选中的兄弟节点
                                break;
                            }
                        }
                        TNP.Checked = YXZ;//将遍历结果赋给父节点
                    }
                }
            }
        }

        /// <summary>
        /// 递归调用，选中或取消
        /// </summary>
        /// <param name="TN"></param>
        /// <param name="flag"></param>
        private void TV_Check(TreeNode TN, bool flag)
        {
            if (TN.Nodes.Count > 0)
            {
                foreach (TreeNode childTN in TN.Nodes)
                {
                    childTN.Checked = flag;
                    TV_Check(childTN, flag);
                }
            }
        }

        /// <summary>
        /// 初始化资料类型树
        /// 不显示根节点
        /// </summary>
        public void TreeViewBand2()
        {
            treeV_BookType.Sort();
            //资料类型的集合
            List<BookType> list = bookType_BLL.SelectBookType();
            foreach (BookType k in list)
            {
                TreeNode nod = new TreeNode();
                nod.Text = k.BookTypeName;
                nod.Tag = k.BookTypeGuid;
                nod.ImageIndex = 0;
                treeV_BookType.Nodes.Add(nod);
            }
            treeV_BookType.ExpandAll();
        }

        #endregion


        /// <summary>
        /// 更改表中显示的列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ChangeColumn_Click(object sender, EventArgs e)
        {
            Frm_ChangeCoulumn b = new Frm_ChangeCoulumn(dgv_BookInfo);
            //b.frmMatInfoManager = this;
            b.ShowDialog();
        }

        /// <summary>
        /// 单击dgv_BookInfo单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_BookInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedBookGuid = dgv_BookInfo.Rows[e.RowIndex].Cells[0].Value.ToString();//选中行的图书Guid
            int rows = dgv_BookInfo.Columns.Count;//dgv_MatInfo的总列数
            
            if (e.ColumnIndex == rows - 3)//修改
            {
                BookInfoAlter(selectedBookGuid);
            }
            else if (e.ColumnIndex == rows - 2)//删除
            {
                BookInfoDelete(selectedBookGuid);
            }
            else if (e.ColumnIndex == rows - 1)
            {
                BookInfoView(selectedBookGuid);//查看
            }
        }

        private void BookInfoAlter(string selectedBookGuid)
        {
            Frm_BookInfoEdit frm_BookInfoAlter = new Frm_BookInfoEdit(selectedBookGuid);
            if (frm_BookInfoAlter.ShowDialog() == DialogResult.OK)
            {
                ShowDataToDataGridView();
            }
        }

        private void BookInfoDelete(string selectedBookGuid)
        {
            DialogResult result = MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (bookInfo_BLL.DeleteBookInfo(selectedBookGuid) > 0)
                {
                    //调用查询按钮刷新图书信息表
                    //btn_Select_Click(null, null);
                    //历史记录表中的数据引用着图书信息表的数据，删除图书信息应该刷新历史记录表
                    //dgv_BorrowHistory.DataSource = borrowHistory_BLL.selectBorrowReturn(borrowMatID).Tables[0];
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void BookInfoView(string selectedBookGuid)
        {
            //查看图书，如果电子书可以显示出来
        }

        /// <summary>
        /// 添加图书信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_AddBookInfo_Click(object sender, EventArgs e)
        {
            Frm_BookInfoEdit bookInfoAdd = new Frm_BookInfoEdit();
            if (bookInfoAdd.ShowDialog() == DialogResult.OK)
            {
                ShowDataToDataGridView();
            }
        }

        /// <summary>
        /// 根据资料的类型树筛选资料
        /// </summary>
        /// <param name="strList"></param>
        private void Get_dgv_BookInfo(List<string> strList)
        {
            dgv_BookInfo.DataSource = bookInfo_BLL.GetMatInfo(strList);
        }

        /// <summary>
        /// 初始化图书类型下拉菜单
        /// </summary>
        public void Init_cbb_BookBigType()
        {
            //cbb_BookBigType.Items.Add("——全部——");

            cbb_BookBigType.Items.Add("实体书");
            cbb_BookBigType.Items.Add("电子书");
            cbb_BookBigType.SelectedIndex = 0;
        }

        /// <summary>
        /// 初始化出版年份下拉菜单
        /// </summary>
        public void Init_cbo_PubYear()
        {
            cbb_Year.DataSource=bookInfo_BLL.GetDistinctYear();
            cbb_Year.SelectedIndex = 0;
        }

        private void ckb_EquipType_CheckedChanged(object sender, EventArgs e)
        {
            ShowDataToDataGridView();
        }

        private void btn_批量导出_Click(object sender, EventArgs e)
        {
            ExportDataGridView(dgv_BookInfo,true);
        }

        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="path"></param>
        /// <param name="isShowExcel"></param>
        /// <returns></returns>
        public void ExportDataGridView(DataGridView dataGridView, bool isShowExcel)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("数据为空");
                return;
            }

            string outPath;
            SaveFileDialog savfile = new SaveFileDialog();
            savfile.Filter = "Excel files（*.xls）|*.xls";
            if (savfile.ShowDialog() == DialogResult.OK)
            {
                outPath = savfile.FileName;
                if(outPath.IndexOf(":")<0)
                {
                    return;
                }

                Excel.Application xlApp=new Excel.Application();
                if(xlApp==null)
                {
                    MessageBox.Show("无法创建Excel对象，您的电脑可能未安装office");
                    return;
                }
                Excel.Workbooks wbs =xlApp.Workbooks; 
                Excel.Workbook wb= wbs.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet ws=(Excel.Worksheet)wb.Worksheets[1];
                for (int i = 0; i < dgv_BookInfo.ColumnCount; i++)
                {
                    ws.Cells[1, i + 1] = dgv_BookInfo.Columns[i].HeaderText;
                }
                for (int r = 0; r < dgv_BookInfo.Rows.Count; r++)
                {
                    for (int i = 0; i < dgv_BookInfo.ColumnCount; i++)
                    {
                        ws.Cells[r + 2, i + 1] = dgv_BookInfo.Rows[r].Cells[i].Value.ToString();
                    }
                    System.Windows.Forms.Application.DoEvents();
                }
                object missing = System.Reflection.Missing.Value;
                xlApp.ActiveWorkbook.Saved = true;
                xlApp.ActiveWorkbook.SaveAs(outPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8, missing, missing, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, missing, missing, missing, missing, missing);
                wb.Close(missing, missing, missing);
                wb = null;
                xlApp.Quit();
            }



        }

        private void btn_批量导入_Click(object sender, EventArgs e)
        {
            Frm_BulkImportMatInfo frmBulkImportMatInfo = new Frm_BulkImportMatInfo();
            frmBulkImportMatInfo.ShowDialog();
        }

        /// <summary>
        /// 显示DataGridView的数据
        /// </summary>
        public void ShowDataToDataGridView()
        {
            //第一种情况：种类列表无数据，则dgv无数据
            if(checkedBookTypeList.Count==0)
            {
                return;
            }
            else if (ckb_出版年份.CheckState==CheckState.Checked && ckb_BookBigType.CheckState == CheckState.Checked)
                dgv_BookInfo.DataSource= bookInfo_BLL.SelectMatInfoByYearAndEquipType(checkedBookTypeList,cbb_Year.Text.ToString(),cbb_BookBigType.Text.ToString());
            else if (ckb_出版年份.CheckState == CheckState.Checked && ckb_BookBigType.CheckState != CheckState.Checked)
                dgv_BookInfo.DataSource = bookInfo_BLL.SelectMatInfoByYear(checkedBookTypeList, cbb_Year.Text.ToString());
            else if (ckb_出版年份.CheckState != CheckState.Checked && ckb_BookBigType.CheckState == CheckState.Checked)
                dgv_BookInfo.DataSource = bookInfo_BLL.SelectMatInfoByEquipType(checkedBookTypeList,cbb_BookBigType.Text.ToString());
            else
                dgv_BookInfo.DataSource = bookInfo_BLL.SelectBookInfo(checkedBookTypeList);
        }

        private void cbb_PressYear_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowDataToDataGridView();
        }

        private void cbb_BookBigType_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowDataToDataGridView();
            //筛选的方法
            //DataView dv = matInfo_BLL.SelectMatInfoDataSet().Tables[0].DefaultView;
            //dv.RowFilter = "EquipTypeName = '" + cbb_配属装备类型.SelectedItem.ToString().Trim() + "'";
            //dgv_MatInfo.DataSource = dv;
        }

        private void ckb_PressYear_CheckedChanged(object sender, EventArgs e)
        {
            ShowDataToDataGridView();
        }
    }
}
