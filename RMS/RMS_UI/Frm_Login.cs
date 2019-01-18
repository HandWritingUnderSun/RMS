using System;
using System.Windows.Forms;
using RMS.BLL;
using RMS.Model;

/***********************************************************************************************
 * 2017年06月08日
 * 登录界面
 * 利用DialogResult返回值确定登录是否成功，进而调出主界面
 * */


namespace RMS.UI
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private User_BLL user_bll = new User_BLL();

        public User_BLL User_bll
        {
            get { return user_bll; }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Longin_Click(object sender, EventArgs e)
        {
            User loginUser = new User();

            loginUser.LoginId = txtLoginId.Text.Trim();
            loginUser.LoginPwd = txtPwd.Text.Trim();

            if (user_bll.CountUser(loginUser) > 0)
            {
                DialogResult = DialogResult.OK;
                Frm_Main.user = loginUser;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                MessageBox.Show("登录失败！");
            }
        }
    }
}
