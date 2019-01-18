namespace RMS.UI
{
    partial class Frm_BookInfoManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BookInfoManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.历史借阅记录 = new System.Windows.Forms.TabPage();
            this.dgv_BorrowHistory = new System.Windows.Forms.DataGridView();
            this.dgv_BookInfo = new System.Windows.Forms.DataGridView();
            this.btnAddBookInfo = new System.Windows.Forms.Button();
            this.btn_ChangeColumn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeV_BookType = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_批量导出 = new System.Windows.Forms.Button();
            this.btn_批量导入 = new System.Windows.Forms.Button();
            this.ckb_出版年份 = new System.Windows.Forms.CheckBox();
            this.ckb_BookBigType = new System.Windows.Forms.CheckBox();
            this.cbb_BookBigType = new System.Windows.Forms.ComboBox();
            this.cbb_Year = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.历史借阅记录.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BorrowHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookInfo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.dgv_BookInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(113, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 446);
            this.panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.历史借阅记录);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 284);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 162);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // 历史借阅记录
            // 
            this.历史借阅记录.Controls.Add(this.dgv_BorrowHistory);
            this.历史借阅记录.Location = new System.Drawing.Point(4, 22);
            this.历史借阅记录.Name = "历史借阅记录";
            this.历史借阅记录.Padding = new System.Windows.Forms.Padding(3);
            this.历史借阅记录.Size = new System.Drawing.Size(909, 136);
            this.历史借阅记录.TabIndex = 0;
            this.历史借阅记录.Text = "历史借阅记录";
            this.历史借阅记录.UseVisualStyleBackColor = true;
            // 
            // dgv_BorrowHistory
            // 
            this.dgv_BorrowHistory.AllowUserToAddRows = false;
            this.dgv_BorrowHistory.AllowUserToDeleteRows = false;
            this.dgv_BorrowHistory.AllowUserToResizeColumns = false;
            this.dgv_BorrowHistory.AllowUserToResizeRows = false;
            this.dgv_BorrowHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BorrowHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_BorrowHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BorrowHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_BorrowHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BorrowHistory.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_BorrowHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BorrowHistory.Location = new System.Drawing.Point(3, 3);
            this.dgv_BorrowHistory.Name = "dgv_BorrowHistory";
            this.dgv_BorrowHistory.RowTemplate.Height = 23;
            this.dgv_BorrowHistory.Size = new System.Drawing.Size(903, 130);
            this.dgv_BorrowHistory.TabIndex = 5;
            // 
            // dgv_BookInfo
            // 
            this.dgv_BookInfo.AllowUserToAddRows = false;
            this.dgv_BookInfo.AllowUserToDeleteRows = false;
            this.dgv_BookInfo.AllowUserToResizeColumns = false;
            this.dgv_BookInfo.AllowUserToResizeRows = false;
            this.dgv_BookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BookInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BookInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_BookInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_BookInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BookInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_BookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BookInfo.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_BookInfo.Location = new System.Drawing.Point(0, 0);
            this.dgv_BookInfo.Name = "dgv_BookInfo";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_BookInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_BookInfo.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_BookInfo.RowTemplate.Height = 23;
            this.dgv_BookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BookInfo.Size = new System.Drawing.Size(916, 280);
            this.dgv_BookInfo.TabIndex = 3;
            this.dgv_BookInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BookInfo_CellContentClick);
            // 
            // btnAddBookInfo
            // 
            this.btnAddBookInfo.Location = new System.Drawing.Point(562, 14);
            this.btnAddBookInfo.Name = "btnAddBookInfo";
            this.btnAddBookInfo.Size = new System.Drawing.Size(86, 23);
            this.btnAddBookInfo.TabIndex = 4;
            this.btnAddBookInfo.Text = "新增图书";
            this.btnAddBookInfo.UseVisualStyleBackColor = true;
            this.btnAddBookInfo.Click += new System.EventHandler(this.btn_AddBookInfo_Click);
            // 
            // btn_ChangeColumn
            // 
            this.btn_ChangeColumn.Location = new System.Drawing.Point(654, 14);
            this.btn_ChangeColumn.Name = "btn_ChangeColumn";
            this.btn_ChangeColumn.Size = new System.Drawing.Size(125, 23);
            this.btn_ChangeColumn.TabIndex = 5;
            this.btn_ChangeColumn.Text = "更改表中显示的列";
            this.btn_ChangeColumn.UseVisualStyleBackColor = true;
            this.btn_ChangeColumn.Click += new System.EventHandler(this.btn_ChangeColumn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.75581F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.24419F));
            this.tableLayoutPanel1.Controls.Add(this.treeV_BookType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.84813F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.15187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 507);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeV_BookType
            // 
            this.treeV_BookType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeV_BookType.ImageIndex = 0;
            this.treeV_BookType.ImageList = this.imageList1;
            this.treeV_BookType.Location = new System.Drawing.Point(3, 58);
            this.treeV_BookType.Name = "treeV_BookType";
            this.treeV_BookType.SelectedImageIndex = 0;
            this.treeV_BookType.Size = new System.Drawing.Size(104, 446);
            this.treeV_BookType.TabIndex = 0;
            this.treeV_BookType.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tV_MatType_AfterCheck);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btn_批量导出);
            this.panel1.Controls.Add(this.btn_批量导入);
            this.panel1.Controls.Add(this.ckb_出版年份);
            this.panel1.Controls.Add(this.ckb_BookBigType);
            this.panel1.Controls.Add(this.cbb_BookBigType);
            this.panel1.Controls.Add(this.cbb_Year);
            this.panel1.Controls.Add(this.btn_ChangeColumn);
            this.panel1.Controls.Add(this.btnAddBookInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 49);
            this.panel1.TabIndex = 1;
            // 
            // btn_批量导出
            // 
            this.btn_批量导出.Location = new System.Drawing.Point(886, 14);
            this.btn_批量导出.Name = "btn_批量导出";
            this.btn_批量导出.Size = new System.Drawing.Size(95, 23);
            this.btn_批量导出.TabIndex = 11;
            this.btn_批量导出.Text = "批量导出";
            this.btn_批量导出.UseVisualStyleBackColor = true;
            this.btn_批量导出.Click += new System.EventHandler(this.btn_批量导出_Click);
            // 
            // btn_批量导入
            // 
            this.btn_批量导入.Location = new System.Drawing.Point(785, 14);
            this.btn_批量导入.Name = "btn_批量导入";
            this.btn_批量导入.Size = new System.Drawing.Size(95, 23);
            this.btn_批量导入.TabIndex = 10;
            this.btn_批量导入.Text = "批量导入";
            this.btn_批量导入.UseVisualStyleBackColor = true;
            this.btn_批量导入.Click += new System.EventHandler(this.btn_批量导入_Click);
            // 
            // ckb_出版年份
            // 
            this.ckb_出版年份.AutoSize = true;
            this.ckb_出版年份.Location = new System.Drawing.Point(332, 18);
            this.ckb_出版年份.Name = "ckb_出版年份";
            this.ckb_出版年份.Size = new System.Drawing.Size(72, 16);
            this.ckb_出版年份.TabIndex = 9;
            this.ckb_出版年份.Text = "出版年份";
            this.ckb_出版年份.UseVisualStyleBackColor = true;
            this.ckb_出版年份.CheckedChanged += new System.EventHandler(this.ckb_PressYear_CheckedChanged);
            // 
            // ckb_BookBigType
            // 
            this.ckb_BookBigType.AutoSize = true;
            this.ckb_BookBigType.Location = new System.Drawing.Point(101, 18);
            this.ckb_BookBigType.Name = "ckb_BookBigType";
            this.ckb_BookBigType.Size = new System.Drawing.Size(72, 16);
            this.ckb_BookBigType.TabIndex = 8;
            this.ckb_BookBigType.Text = "图书大类";
            this.ckb_BookBigType.UseVisualStyleBackColor = true;
            this.ckb_BookBigType.CheckedChanged += new System.EventHandler(this.ckb_EquipType_CheckedChanged);
            // 
            // cbb_BookBigType
            // 
            this.cbb_BookBigType.FormattingEnabled = true;
            this.cbb_BookBigType.Location = new System.Drawing.Point(179, 14);
            this.cbb_BookBigType.Name = "cbb_BookBigType";
            this.cbb_BookBigType.Size = new System.Drawing.Size(121, 20);
            this.cbb_BookBigType.TabIndex = 7;
            this.cbb_BookBigType.SelectedValueChanged += new System.EventHandler(this.cbb_BookBigType_SelectedValueChanged);
            // 
            // cbb_Year
            // 
            this.cbb_Year.FormattingEnabled = true;
            this.cbb_Year.Location = new System.Drawing.Point(410, 14);
            this.cbb_Year.Name = "cbb_Year";
            this.cbb_Year.Size = new System.Drawing.Size(121, 20);
            this.cbb_Year.TabIndex = 6;
            this.cbb_Year.SelectedValueChanged += new System.EventHandler(this.cbb_PressYear_SelectedValueChanged);
            // 
            // Frm_BookInfoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Frm_BookInfoManager";
            this.Tag = " ";
            this.Text = "图书管理";
            this.Load += new System.EventHandler(this.Frm_BookInfoManager_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.历史借阅记录.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BorrowHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookInfo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 历史借阅记录;
        public System.Windows.Forms.DataGridView dgv_BorrowHistory;
        public System.Windows.Forms.DataGridView dgv_BookInfo;
        public System.Windows.Forms.Button btnAddBookInfo;
        private System.Windows.Forms.Button btn_ChangeColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TreeView treeV_BookType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbb_BookBigType;
        private System.Windows.Forms.ComboBox cbb_Year;
        private System.Windows.Forms.CheckBox ckb_出版年份;
        private System.Windows.Forms.CheckBox ckb_BookBigType;
        private System.Windows.Forms.Button btn_批量导入;
        private System.Windows.Forms.Button btn_批量导出;

    }
}