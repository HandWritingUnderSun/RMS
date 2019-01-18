namespace RMS.UI
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_BasicInfoManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_BookTypeManager = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_BookInfoMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_BookManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddBookInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_BookInfoStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MatTypeManager = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_BookTypeManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PersonManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AlterPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_BorrowInfoManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Borrow = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_BRRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SomeTools = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Calc = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Draw = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Calendar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SomeGames = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SystemManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ManagerManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.茶叶管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.茶叶信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.价格管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB_BookManager = new System.Windows.Forms.ToolStripButton();
            this.tSB_PersonManager = new System.Windows.Forms.ToolStripButton();
            this.tSB_BorrowManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSB_DairyManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSL_LoginState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tSB_BorrowReturnManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_BasicInfoManagement,
            this.TSMI_BookInfoMaintenance,
            this.TSMI_PersonManagement,
            this.TSMI_BorrowInfoManagement,
            this.TSMI_SomeTools,
            this.TSMI_SomeGames,
            this.TSMI_SystemManagement,
            this.TSMI_Help,
            this.茶叶管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(793, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_BasicInfoManagement
            // 
            this.TSMI_BasicInfoManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_BookTypeManager});
            this.TSMI_BasicInfoManagement.Name = "TSMI_BasicInfoManagement";
            this.TSMI_BasicInfoManagement.Size = new System.Drawing.Size(92, 21);
            this.TSMI_BasicInfoManagement.Text = "基本信息维护";
            // 
            // TSMI_BookTypeManager
            // 
            this.TSMI_BookTypeManager.Name = "TSMI_BookTypeManager";
            this.TSMI_BookTypeManager.Size = new System.Drawing.Size(148, 22);
            this.TSMI_BookTypeManager.Text = "图书类型维护";
            this.TSMI_BookTypeManager.Click += new System.EventHandler(this.TSMI_BookTypeManager_Click);
            // 
            // TSMI_BookInfoMaintenance
            // 
            this.TSMI_BookInfoMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_BookManagment,
            this.TSMI_AddBookInfo,
            this.TSMI_BookInfoStatistics,
            this.TSMI_MatTypeManager});
            this.TSMI_BookInfoMaintenance.Name = "TSMI_BookInfoMaintenance";
            this.TSMI_BookInfoMaintenance.Size = new System.Drawing.Size(92, 21);
            this.TSMI_BookInfoMaintenance.Text = "图书信息维护";
            // 
            // TSMI_BookManagment
            // 
            this.TSMI_BookManagment.Name = "TSMI_BookManagment";
            this.TSMI_BookManagment.Size = new System.Drawing.Size(148, 22);
            this.TSMI_BookManagment.Text = "图书管理";
            this.TSMI_BookManagment.Click += new System.EventHandler(this.TSMI_BookManager_Click);
            // 
            // TSMI_AddBookInfo
            // 
            this.TSMI_AddBookInfo.Name = "TSMI_AddBookInfo";
            this.TSMI_AddBookInfo.Size = new System.Drawing.Size(148, 22);
            this.TSMI_AddBookInfo.Text = "新增图书";
            this.TSMI_AddBookInfo.Click += new System.EventHandler(this.menuStripAddBookInfo_Click);
            // 
            // TSMI_BookInfoStatistics
            // 
            this.TSMI_BookInfoStatistics.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_BookInfoStatistics.Image")));
            this.TSMI_BookInfoStatistics.Name = "TSMI_BookInfoStatistics";
            this.TSMI_BookInfoStatistics.Size = new System.Drawing.Size(148, 22);
            this.TSMI_BookInfoStatistics.Text = "图书信息统计";
            this.TSMI_BookInfoStatistics.Click += new System.EventHandler(this.TSMI_BookInfoStatistics_Click);
            // 
            // TSMI_MatTypeManager
            // 
            this.TSMI_MatTypeManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_BookTypeManagement});
            this.TSMI_MatTypeManager.Name = "TSMI_MatTypeManager";
            this.TSMI_MatTypeManager.Size = new System.Drawing.Size(148, 22);
            this.TSMI_MatTypeManager.Text = "基本信息维护";
            // 
            // TSMI_BookTypeManagement
            // 
            this.TSMI_BookTypeManagement.Name = "TSMI_BookTypeManagement";
            this.TSMI_BookTypeManagement.Size = new System.Drawing.Size(148, 22);
            this.TSMI_BookTypeManagement.Text = "图书类型维护";
            this.TSMI_BookTypeManagement.Click += new System.EventHandler(this.TSMI_BookTypeManager_Click);
            // 
            // TSMI_PersonManagement
            // 
            this.TSMI_PersonManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_AddPersonInfo,
            this.TSMI_AlterPersonInfo});
            this.TSMI_PersonManagement.Name = "TSMI_PersonManagement";
            this.TSMI_PersonManagement.Size = new System.Drawing.Size(68, 21);
            this.TSMI_PersonManagement.Text = "人员管理";
            // 
            // TSMI_AddPersonInfo
            // 
            this.TSMI_AddPersonInfo.Name = "TSMI_AddPersonInfo";
            this.TSMI_AddPersonInfo.Size = new System.Drawing.Size(148, 22);
            this.TSMI_AddPersonInfo.Text = "添加人员信息";
            // 
            // TSMI_AlterPersonInfo
            // 
            this.TSMI_AlterPersonInfo.Name = "TSMI_AlterPersonInfo";
            this.TSMI_AlterPersonInfo.Size = new System.Drawing.Size(148, 22);
            this.TSMI_AlterPersonInfo.Text = "修改人员信息";
            // 
            // TSMI_BorrowInfoManagement
            // 
            this.TSMI_BorrowInfoManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Borrow,
            this.TSMI_BRRecord});
            this.TSMI_BorrowInfoManagement.Name = "TSMI_BorrowInfoManagement";
            this.TSMI_BorrowInfoManagement.Size = new System.Drawing.Size(68, 21);
            this.TSMI_BorrowInfoManagement.Text = "借阅管理";
            // 
            // TSMI_Borrow
            // 
            this.TSMI_Borrow.Name = "TSMI_Borrow";
            this.TSMI_Borrow.Size = new System.Drawing.Size(124, 22);
            this.TSMI_Borrow.Text = "资源借阅";
            this.TSMI_Borrow.Click += new System.EventHandler(this.toolStripBorrow_Click);
            // 
            // TSMI_BRRecord
            // 
            this.TSMI_BRRecord.Name = "TSMI_BRRecord";
            this.TSMI_BRRecord.Size = new System.Drawing.Size(124, 22);
            this.TSMI_BRRecord.Text = "借还记录";
            this.TSMI_BRRecord.Click += new System.EventHandler(this.toolStripButtonBorrowReturn_Click);
            // 
            // TSMI_SomeTools
            // 
            this.TSMI_SomeTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Calc,
            this.TSMI_Draw,
            this.TSMI_Calendar});
            this.TSMI_SomeTools.Name = "TSMI_SomeTools";
            this.TSMI_SomeTools.Size = new System.Drawing.Size(44, 21);
            this.TSMI_SomeTools.Text = "工具";
            // 
            // TSMI_Calc
            // 
            this.TSMI_Calc.Name = "TSMI_Calc";
            this.TSMI_Calc.Size = new System.Drawing.Size(124, 22);
            this.TSMI_Calc.Text = "计算器";
            this.TSMI_Calc.Click += new System.EventHandler(this.计算器ToolStripMenuItem_Click);
            // 
            // TSMI_Draw
            // 
            this.TSMI_Draw.Name = "TSMI_Draw";
            this.TSMI_Draw.Size = new System.Drawing.Size(124, 22);
            this.TSMI_Draw.Text = "画图工具";
            this.TSMI_Draw.Click += new System.EventHandler(this.画图工具ToolStripMenuItem_Click);
            // 
            // TSMI_Calendar
            // 
            this.TSMI_Calendar.Name = "TSMI_Calendar";
            this.TSMI_Calendar.Size = new System.Drawing.Size(124, 22);
            this.TSMI_Calendar.Text = "日历";
            // 
            // TSMI_SomeGames
            // 
            this.TSMI_SomeGames.Name = "TSMI_SomeGames";
            this.TSMI_SomeGames.Size = new System.Drawing.Size(44, 21);
            this.TSMI_SomeGames.Text = "游戏";
            // 
            // TSMI_SystemManagement
            // 
            this.TSMI_SystemManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ManagerManagment,
            this.TSMI_Exit});
            this.TSMI_SystemManagement.Name = "TSMI_SystemManagement";
            this.TSMI_SystemManagement.Size = new System.Drawing.Size(68, 21);
            this.TSMI_SystemManagement.Text = "系统管理";
            // 
            // TSMI_ManagerManagment
            // 
            this.TSMI_ManagerManagment.Name = "TSMI_ManagerManagment";
            this.TSMI_ManagerManagment.Size = new System.Drawing.Size(124, 22);
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(124, 22);
            this.TSMI_Exit.Text = "退出系统";
            this.TSMI_Exit.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // TSMI_Help
            // 
            this.TSMI_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_About});
            this.TSMI_Help.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Help.Image")));
            this.TSMI_Help.Name = "TSMI_Help";
            this.TSMI_Help.Size = new System.Drawing.Size(60, 21);
            this.TSMI_Help.Text = "帮助";
            // 
            // TSMI_About
            // 
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(100, 22);
            this.TSMI_About.Text = "关于";
            this.TSMI_About.Click += new System.EventHandler(this.TSMI_About_Click);
            // 
            // 茶叶管理ToolStripMenuItem
            // 
            this.茶叶管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.茶叶信息管理ToolStripMenuItem,
            this.价格管理ToolStripMenuItem,
            this.库存管理ToolStripMenuItem});
            this.茶叶管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("茶叶管理ToolStripMenuItem.Image")));
            this.茶叶管理ToolStripMenuItem.Name = "茶叶管理ToolStripMenuItem";
            this.茶叶管理ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.茶叶管理ToolStripMenuItem.Text = "茶叶管理";
            // 
            // 茶叶信息管理ToolStripMenuItem
            // 
            this.茶叶信息管理ToolStripMenuItem.Name = "茶叶信息管理ToolStripMenuItem";
            this.茶叶信息管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.茶叶信息管理ToolStripMenuItem.Text = "基本信息管理";
            // 
            // 价格管理ToolStripMenuItem
            // 
            this.价格管理ToolStripMenuItem.Name = "价格管理ToolStripMenuItem";
            this.价格管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.价格管理ToolStripMenuItem.Text = "历史价格统计";
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            this.库存管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.库存管理ToolStripMenuItem.Text = "库存茶叶管理";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_BookManager,
            this.tSB_PersonManager,
            this.tSB_BorrowManager,
            this.toolStripSeparator1,
            this.tSB_DairyManager,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(793, 67);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSB_BookManager
            // 
            this.tSB_BookManager.AutoSize = false;
            this.tSB_BookManager.Image = ((System.Drawing.Image)(resources.GetObject("tSB_BookManager.Image")));
            this.tSB_BookManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_BookManager.Name = "tSB_BookManager";
            this.tSB_BookManager.Size = new System.Drawing.Size(64, 64);
            this.tSB_BookManager.Text = "图书管理 ";
            this.tSB_BookManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSB_BookManager.ToolTipText = "图书管理 ";
            this.tSB_BookManager.Click += new System.EventHandler(this.TSMI_BookManager_Click);
            // 
            // tSB_PersonManager
            // 
            this.tSB_PersonManager.Image = ((System.Drawing.Image)(resources.GetObject("tSB_PersonManager.Image")));
            this.tSB_PersonManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_PersonManager.Name = "tSB_PersonManager";
            this.tSB_PersonManager.Size = new System.Drawing.Size(64, 61);
            this.tSB_PersonManager.Text = "人员管理 ";
            this.tSB_PersonManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSB_PersonManager.Click += new System.EventHandler(this.toolStripButtonReaderManager_Click);
            // 
            // tSB_BorrowManager
            // 
            this.tSB_BorrowManager.Image = ((System.Drawing.Image)(resources.GetObject("tSB_BorrowManager.Image")));
            this.tSB_BorrowManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_BorrowManager.Name = "tSB_BorrowManager";
            this.tSB_BorrowManager.Size = new System.Drawing.Size(64, 61);
            this.tSB_BorrowManager.Text = "借阅管理 ";
            this.tSB_BorrowManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSB_BorrowManager.Click += new System.EventHandler(this.toolStripBorrow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // tSB_DairyManager
            // 
            this.tSB_DairyManager.Image = ((System.Drawing.Image)(resources.GetObject("tSB_DairyManager.Image")));
            this.tSB_DairyManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_DairyManager.Name = "tSB_DairyManager";
            this.tSB_DairyManager.Size = new System.Drawing.Size(60, 61);
            this.tSB_DairyManager.Text = "日记管理";
            this.tSB_DairyManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSB_DairyManager.Click += new System.EventHandler(this.tSB_Dairy_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 61);
            this.toolStripButton1.Text = "茶叶管理";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL_LoginState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSL_LoginState
            // 
            this.tSSL_LoginState.Name = "tSSL_LoginState";
            this.tSSL_LoginState.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 92);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(793, 388);
            this.tabControl.TabIndex = 5;
            this.tabControl.DoubleClick += new System.EventHandler(this.tabControl_DoubleClick);
            // 
            // tSB_BorrowReturnManager
            // 
            this.tSB_BorrowReturnManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_BorrowReturnManager.Name = "tSB_BorrowReturnManager";
            this.tSB_BorrowReturnManager.Size = new System.Drawing.Size(60, 21);
            this.tSB_BorrowReturnManager.Text = "借阅管理";
            this.tSB_BorrowReturnManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSB_BorrowReturnManager.Click += new System.EventHandler(this.toolStripButtonBorrowReturn_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 502);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.Text = "资源管理系统v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SystemManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BorrowInfoManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ManagerManagment;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Borrow;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BookInfoMaintenance;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SomeTools;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddBookInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Calc;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Draw;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BRRecord;
        private System.Windows.Forms.ToolStripMenuItem TSMI_About;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SomeGames;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PersonManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AlterPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BasicInfoManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BookTypeManager;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MatTypeManager;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BookTypeManagement;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_BookManager;
        private System.Windows.Forms.ToolStripButton tSB_PersonManager;
        private System.Windows.Forms.ToolStripButton tSB_BorrowManager;
        private System.Windows.Forms.ToolStripButton tSB_BorrowReturnManager;
        private System.Windows.Forms.ToolStripButton tSB_DairyManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_LoginState;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BookInfoStatistics;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BookManagment;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Calendar;
        private System.Windows.Forms.ToolStripMenuItem 茶叶管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 茶叶信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 价格管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

