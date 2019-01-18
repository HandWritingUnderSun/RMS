using System;
using System.Windows.Forms;
using RMS.Command;
using RMS.Model;
using RMS.BLL;

namespace RMS.UI
{
    public partial class Frm_PersonTypeAlter : Form
    {
        public Frm_PersonTypeAlter()
        {
            InitializeComponent();
        }

        Com com = new Com();
        UserType_BLL personType_BLL = new UserType_BLL();
        public Frm_PersonTypeManager frmPersonTypeManager = null;
        public UserType personType = null;

        private void Frm_Alter_Load(object sender, EventArgs e)
        {
            tB_PersonType.Text = personType.UserTypeName;
        }

        /// <summary>
        /// 修改类型名，确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            personType.UserTypeName = tB_PersonType.Text.Trim();

            if(personType_BLL.IsUpdatePersonType(personType))
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
