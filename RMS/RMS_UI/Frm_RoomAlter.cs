using System;
using System.Windows.Forms;
using RMS.BLL;
using RMS.Model;
using RMS.Command;

namespace RMS.UI
{
    public partial class Frm_RoomAlter : Form
    {
        public Frm_RoomAlter()
        {
            InitializeComponent();
        }

        public Frm_RoomManager frmRoomManager = null;
        public Room room = null;
        Room_BLL room_BLL = new Room_BLL();

        Com com = new Com();


        private void Frm_Alter_Load(object sender, EventArgs e)
        {
            tB_Room.Text = room.RoomName;
        }

        /// <summary>
        /// 修改类型名，确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            room.RoomName = tB_Room.Text.Trim();

            if (room_BLL.IsUpdateRoom(room))
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
            Close();
        }
    }
}
