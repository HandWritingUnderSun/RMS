using RMS.Model;
using System;
using System.Windows.Forms;

namespace RMS.UI
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        public static User user;

        //可以从app.config中读出
        //private string sn = ConfigurationManager.GetSection("system").ToString();
        private string SystemName = "个人信息管理系统";
        private string Author = "zhuyu";
        private string VersionId = "v1.2";

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Text = SystemName + "  " + VersionId;

            IsLoginOK();

            InitFrmMain();
        }

        /// <summary>
        /// 是否登录成功
        /// </summary>
        private void IsLoginOK()
        {
            Frm_Login loginWin = new Frm_Login();
            if (loginWin.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Visible = true;
            }
        }

        /// <summary>
        /// 初始化窗体
        /// </summary>
        private void InitFrmMain()
        {
            try
            {
                tSSL_LoginState.Text = "状态：" + user.LoginId + "已登录.";
            }
            catch
            {
                tSSL_LoginState.Text = "状态：无用户登录.";
            }
        }

        #region 函数

        /// <summary>
        /// TabControl的TabPage绑定窗体的公共方法
        /// </summary>
        /// <param name="form"></param>
        /// <param name="page"></param>
        public void TabPageBinding(Form form, TabPage page)
        {
            if (true == tabControl.TabPages.ContainsKey(page.Name))
            {
                return;
            }
            else
            {
                page.Controls.Clear();
                form.FormBorderStyle = FormBorderStyle.None;
                form.StartPosition = FormStartPosition.Manual;
                form.Dock = DockStyle.Fill;
                form.TopLevel = false;
                page.Controls.Add(form);
                tabControl.Controls.Add(page);
                tabControl.SelectedTab = page;
                page.Show();
                form.Show();
            }
        }

        #endregion

        /// <summary>
        /// menuStrip新增材料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStripAddBookInfo_Click(object sender, EventArgs e)
        {
            //frmBookInfoManager.AddMatInfo();
        }


        private void toolStripBorrow_Click(object sender, EventArgs e)
        {
            BorrowManager_UI b = new BorrowManager_UI();
            b.ShowDialog();
        }

        private void menuStripAddReaderInfo_Click(object sender, EventArgs e)
        {
            //frmPersonInfoManager.btnAddReaderInfo_Click(null, null);
        }

        private void tsmi_PersonTypeManager_Click(object sender, EventArgs e)
        {
            Frm_PersonTypeManager frmPersonTypeManager = new Frm_PersonTypeManager();
            frmPersonTypeManager.ShowDialog();
        }



        /// <summary>
        /// 调出系统计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        /// <summary>
        /// 调出系统画板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 画图工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 帮助-关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SystemName+" "+VersionId+"\n作者："+Author);
        }

        #region 控件事件

        /// <summary>
        /// 图书管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_BookManager_Click(object sender, EventArgs e)
        {
            Frm_BookInfoManager frmBookInfoManager = Frm_BookInfoManager.CreateInstance();
            foreach (TabPage tp in this.tabControl.TabPages)
            {
                if (tp.Name == "BookInfo")
                {
                    this.tabControl.SelectedTab = tp;
                    break;
                }
            }
            TabPage tP_BookInfoManagement = new TabPage();
            tP_BookInfoManagement.Name = "BookInfo";
            tP_BookInfoManagement.Text = "图书信息管理";
            TabPageBinding(frmBookInfoManager, tP_BookInfoManagement);
        }

        /// <summary>
        /// 人员管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonReaderManager_Click(object sender, EventArgs e)
        {
            Frm_PersonInfoManager frmUserInfoManager = new Frm_PersonInfoManager();
            TabPage tP_UserInfoManagement = new TabPage();
            tP_UserInfoManagement.Name = "UserInfo";
            tP_UserInfoManagement.Text = "人员信息管理";
            TabPageBinding(frmUserInfoManager, tP_UserInfoManagement);
        }

        /// <summary>
        /// 日志操作管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonBorrowReturn_Click(object sender, EventArgs e)
        {
            //TabPageBinding(new BorrowHostory_UI(), tP_BorrowInfoManagement);
            //this.tabControl.SelectedIndex = 2;
        }

        private void TSMI_BookTypeManager_Click(object sender, EventArgs e)
        {
            Frm_BookTypeManager frmBookTypeManager = new Frm_BookTypeManager();
            frmBookTypeManager.ShowDialog();
        }

        /// <summary>
        /// 双击实现tabpage关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_DoubleClick(object sender, EventArgs e)
        {
            tabControl.TabPages.RemoveAt(((TabControl)sender).SelectedIndex);
        }

        #endregion


        /// <summary>
        /// 日记管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSB_Dairy_Click(object sender, EventArgs e)
        {
            Frm_DairyInfoManager frmDairyInfoManager = new Frm_DairyInfoManager();
            TabPage tP_UserInfoManagement = new TabPage();
            tP_UserInfoManagement.Name = "DairyInfo";
            tP_UserInfoManagement.Text = "日记管理";
            TabPageBinding(frmDairyInfoManager, tP_UserInfoManagement);

        }

        private void TSMI_BookInfoStatistics_Click(object sender, EventArgs e)
        {
            Frm_BookInfoStatistics frmBookInfoStatistics = new Frm_BookInfoStatistics();
            TabPage tP_BookInfoStatistics = new TabPage();
            tP_BookInfoStatistics.Name = "BookInfoStatistics";
            tP_BookInfoStatistics.Text = "图书统计";
            TabPageBinding(frmBookInfoStatistics, tP_BookInfoStatistics);
        }
    }
}
