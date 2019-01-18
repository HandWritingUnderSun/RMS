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
    public partial class Frm_RoomManager : Form
    {
        public Frm_RoomManager(Frm_BookInfoManager frm)
        {
            matInfoManager = frm;
            InitializeComponent();
        }

        public Frm_BookInfoManager matInfoManager;
        public Room_BLL room_BLL = new Room_BLL();

        Com auto = new Com();

        private void Frm_RoomManager_Load(object sender, EventArgs e)
        {
            Init_dGV_Room();
        }

        /// <summary>
        /// 初始化dgv
        /// </summary>
        private void Init_dGV_Room()
        {
            ShowLayout_dGV_Room();

            ShowData_dGV_MatUnit();
        }

        /// <summary>
        /// 显示dgv格式
        /// </summary>
        private void ShowLayout_dGV_Room()
        {
            string HeaderText = "Guid,房间";
            string DataPropertyNames = "RoomID,RoomName";
            dGV_Room.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //自动生成列
            auto.AutoColumn(HeaderText, DataPropertyNames, dGV_Room);
            auto.AddColumn("修改", dGV_Room);
            auto.AddColumn("删除", dGV_Room);

            dGV_Room.Columns[0].Visible = false;
        }

        /// <summary>
        /// 显示dgv类型数据
        /// </summary>
        private void ShowData_dGV_MatUnit()
        {
            dGV_Room.DataSource = room_BLL.SelectRoom();
        }

        /// <summary>
        /// 添加资料类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            string tempRoomName = tB_Room.Text.Trim();

            if (tempRoomName == "")
            {
                MessageBox.Show("资料类型名不能为空，请重新输入！！！");
            }
            else if (room_BLL.IsRoomHaving(tempRoomName))
            {
                MessageBox.Show("该类型已存在，请重新输入！！！");

            }
            else if (room_BLL.AddRoom(tempRoomName) == true)
            {
                MessageBox.Show("添加成功！");
                ShowData_dGV_MatUnit();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
            tB_Room.Clear();            
        }

        /// <summary>
        /// 资料类型表的单元格单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGV_Room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //选中行的资料编号
            int strID=0;
           try
           {
               strID = Convert.ToInt32(dGV_Room.Rows[e.RowIndex].Cells[0].Value.ToString());
           }
           catch (Exception)
           { }

           //dGV_MatType的总列数
           int colCount = dGV_Room.Columns.Count;

            if (e.ColumnIndex == colCount - 2)//修改
            {
                Room room = new Room();
                room.RoomID=strID;
                room.RoomName= dGV_Room.Rows[e.RowIndex].Cells[1].Value.ToString();

                Frm_RoomAlter frmRoomAlter = new Frm_RoomAlter();
                frmRoomAlter.frmRoomManager = this;
                frmRoomAlter.room = room;
                frmRoomAlter.Text = "修改资料类型";
                frmRoomAlter.ShowDialog();
            }
            else if (e.ColumnIndex == colCount - 1)//删除
            {
                DialogResult result = MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (room_BLL.deleteRoom(strID))
                    {
                        MessageBox.Show("删除成功！");
                        ShowData_dGV_MatUnit();
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
