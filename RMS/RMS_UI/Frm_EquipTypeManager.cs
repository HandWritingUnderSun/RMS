using System;
using System.Windows.Forms;
using RMS.BLL;
using RMS.Command;
using RMS.Model;

/***************************************************************************
 * 2017年06月18日
 * 资料类型管理
 * 删除
 * 添加
 * 修改
 * */

namespace RMS.UI
{
    public partial class Frm_EquipTypeManager : Form
    {
        public Frm_EquipTypeManager(Frm_BookInfoManager frm)
        {
            matInfoManager = frm;
            InitializeComponent();
        }

        public Frm_BookInfoManager matInfoManager;
        public EquipType_BLL equipType_BLL = new EquipType_BLL();
        Com auto = new Com();

        private void Frm_EquipTypeManager_Load(object sender, EventArgs e)
        {
            Init_dGV_EquipType();
        }

        /// <summary>
        /// 初始化dgv
        /// </summary>
        private void Init_dGV_EquipType()
        {
            ShowLayout_dGV_EquipType();

            ShowData_dGV_EquipType();
        }

        /// <summary>
        /// 显示dgv格式
        /// </summary>
        private void ShowLayout_dGV_EquipType()
        {
            string HeaderText = "Guid,配属装备类型";
            string DataPropertyNames = "EquipTypeID,EquipTypeName";
            dGV_EquipType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //自动生成列
            auto.AutoColumn(HeaderText, DataPropertyNames, dGV_EquipType);
            auto.AddColumn("修改", dGV_EquipType);
            auto.AddColumn("删除", dGV_EquipType);

            dGV_EquipType.Columns[0].Visible = false;
        }

        /// <summary>
        /// 显示dgv类型数据
        /// </summary>
        private void ShowData_dGV_EquipType()
        {
            dGV_EquipType.DataSource = equipType_BLL.SelectEquipType();
        }

        /// <summary>
        /// 添加资料类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddMatUnit_Click(object sender, EventArgs e)
        {
            string tempEquipTypeName = tB_EquipType.Text.Trim();

            if (tempEquipTypeName == "")
            {
                MessageBox.Show("资料类型名不能为空，请重新输入！！！");
            }
            else if (equipType_BLL.IsEquipTypeHaving(tempEquipTypeName))
            {
                MessageBox.Show("该类型已存在，请重新输入！！！");

            }
            else if (equipType_BLL.AddEquipType(tempEquipTypeName) == true)
            {
                MessageBox.Show("添加成功！");
                ShowData_dGV_EquipType();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
            tB_EquipType.Clear();            
        }

        /// <summary>
        /// 资料类型表的单元格单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGV_MatUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //选中行的资料编号
            int strID=0;
           try
           {
               strID = Convert.ToInt32(dGV_EquipType.Rows[e.RowIndex].Cells[0].Value.ToString());
           }
           catch (Exception)
           { }

           //dGV_MatType的总列数
            int colCount = dGV_EquipType.Columns.Count;

            if (e.ColumnIndex == colCount - 2)//修改
            {
                EquipType equipType = new EquipType();
                equipType.EquipTypeID = strID;
                equipType.EquipTypeName = dGV_EquipType.Rows[e.RowIndex].Cells[1].Value.ToString();

                Frm_EquipTypeAlter frmEquipTypeAlter = new Frm_EquipTypeAlter();
                frmEquipTypeAlter.frmEquipTypeManager = this;
                frmEquipTypeAlter.equipType = equipType;
                frmEquipTypeAlter.Text = "修改资料类型";
                frmEquipTypeAlter.ShowDialog();
            }
            else if (e.ColumnIndex == colCount - 1)//删除
            {
                DialogResult result = MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (equipType_BLL.deleteEquipType(strID))
                    {
                        MessageBox.Show("删除成功！");
                        ShowData_dGV_EquipType();
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
        private void Frm_MatUnitManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            matInfoManager.Init_treeV_BookType();
        }

        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            matInfoManager.Init_treeV_BookType();
            this.Close();
        }
    }
}
