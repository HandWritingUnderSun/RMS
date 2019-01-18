using System;
using System.Windows.Forms;
using RMS.BLL;
using RMS.Model;
using RMS.Command;

namespace RMS.UI
{
    public partial class Frm_EquipTypeAlter : Form
    {
        public Frm_EquipTypeAlter()
        {
            InitializeComponent();
        }

        public Frm_EquipTypeManager frmEquipTypeManager = null;
        public EquipType equipType = null;
        Com com = new Com();
        EquipType_BLL equipType_BLL = new EquipType_BLL();

        private void Frm_Alter_Load(object sender, EventArgs e)
        {
            tB_EqiupType.Text = equipType.EquipTypeName;
        }

        /// <summary>
        /// 修改类型名，确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            equipType.EquipTypeName = tB_EqiupType.Text.Trim();

            if (equipType_BLL.IsUpdateEquipType(equipType))
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
