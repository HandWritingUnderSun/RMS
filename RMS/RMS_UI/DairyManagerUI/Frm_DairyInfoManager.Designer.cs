namespace RMS.UI
{
    partial class Frm_DairyInfoManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.另存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.书签ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SetFont = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SetColor = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_DairyText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.保存ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lV_FileInfo = new System.Windows.Forms.ListView();
            this.设置文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.参数ToolStripMenuItem,
            this.设置文件夹ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.TSMI_OpenFile,
            this.toolStripMenuItem2,
            this.TSMI_SaveFile,
            this.另存ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.关闭ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // TSMI_OpenFile
            // 
            this.TSMI_OpenFile.Name = "TSMI_OpenFile";
            this.TSMI_OpenFile.Size = new System.Drawing.Size(180, 22);
            this.TSMI_OpenFile.Text = "打开";
            this.TSMI_OpenFile.Click += new System.EventHandler(this.TSMI_OpenFile_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_SaveFile
            // 
            this.TSMI_SaveFile.Name = "TSMI_SaveFile";
            this.TSMI_SaveFile.Size = new System.Drawing.Size(180, 22);
            this.TSMI_SaveFile.Text = "保存";
            this.TSMI_SaveFile.Click += new System.EventHandler(this.TSMI_SaveFile_Click);
            // 
            // 另存ToolStripMenuItem
            // 
            this.另存ToolStripMenuItem.Name = "另存ToolStripMenuItem";
            this.另存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.另存ToolStripMenuItem.Text = "另存为";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.书签ToolStripMenuItem,
            this.toolStripMenuItem4});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // 书签ToolStripMenuItem
            // 
            this.书签ToolStripMenuItem.Name = "书签ToolStripMenuItem";
            this.书签ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.书签ToolStripMenuItem.Text = "书签";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(97, 6);
            // 
            // 参数ToolStripMenuItem
            // 
            this.参数ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_SetFont,
            this.TSMI_SetColor});
            this.参数ToolStripMenuItem.Name = "参数ToolStripMenuItem";
            this.参数ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.参数ToolStripMenuItem.Text = "参数";
            // 
            // TSMI_SetFont
            // 
            this.TSMI_SetFont.Name = "TSMI_SetFont";
            this.TSMI_SetFont.Size = new System.Drawing.Size(100, 22);
            this.TSMI_SetFont.Text = "字体";
            this.TSMI_SetFont.Click += new System.EventHandler(this.TSMI_SetFont_Click);
            // 
            // TSMI_SetColor
            // 
            this.TSMI_SetColor.Name = "TSMI_SetColor";
            this.TSMI_SetColor.Size = new System.Drawing.Size(100, 22);
            this.TSMI_SetColor.Text = "颜色";
            this.TSMI_SetColor.Click += new System.EventHandler(this.TSMI_SetColor_Click);
            // 
            // rtb_DairyText
            // 
            this.rtb_DairyText.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtb_DairyText.Location = new System.Drawing.Point(241, 25);
            this.rtb_DairyText.Name = "rtb_DairyText";
            this.rtb_DairyText.Size = new System.Drawing.Size(943, 746);
            this.rtb_DairyText.TabIndex = 1;
            this.rtb_DairyText.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 保存ToolStripMenuItem1
            // 
            this.保存ToolStripMenuItem1.Name = "保存ToolStripMenuItem1";
            this.保存ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.保存ToolStripMenuItem1.Text = "保存";
            // 
            // lV_FileInfo
            // 
            this.lV_FileInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lV_FileInfo.Location = new System.Drawing.Point(0, 25);
            this.lV_FileInfo.Name = "lV_FileInfo";
            this.lV_FileInfo.Size = new System.Drawing.Size(235, 746);
            this.lV_FileInfo.TabIndex = 2;
            this.lV_FileInfo.UseCompatibleStateImageBehavior = false;
            // 
            // 设置文件夹ToolStripMenuItem
            // 
            this.设置文件夹ToolStripMenuItem.Name = "设置文件夹ToolStripMenuItem";
            this.设置文件夹ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.设置文件夹ToolStripMenuItem.Text = "设置文件夹";
            this.设置文件夹ToolStripMenuItem.Click += new System.EventHandler(this.设置文件夹ToolStripMenuItem_Click);
            // 
            // Frm_DairyInfoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 771);
            this.Controls.Add(this.lV_FileInfo);
            this.Controls.Add(this.rtb_DairyText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_DairyInfoManager";
            this.Text = "Frm_DairyInfoManager";
            this.Load += new System.EventHandler(this.Frm_DairyInfoManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_OpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem 另存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 书签ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtb_DairyText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SetFont;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SetColor;
        private System.Windows.Forms.ListView lV_FileInfo;
        private System.Windows.Forms.ToolStripMenuItem 设置文件夹ToolStripMenuItem;
    }
}