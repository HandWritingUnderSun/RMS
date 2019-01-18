namespace RMS.UI
{
    partial class CardInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardInfo));
            this.pB_Logo = new System.Windows.Forms.PictureBox();
            this.bN_CardInfo = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bNCI_Num = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bNMFI_First = new System.Windows.Forms.ToolStripButton();
            this.bNMPI_Previous = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bNPI_Num = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bNMNI_Next = new System.Windows.Forms.ToolStripButton();
            this.bNMLI_Last = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lb_CID = new System.Windows.Forms.Label();
            this.tB_CID = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.tB_Telephone = new System.Windows.Forms.TextBox();
            this.lb_Tp = new System.Windows.Forms.Label();
            this.tB_Company = new System.Windows.Forms.TextBox();
            this.lb_Cp = new System.Windows.Forms.Label();
            this.tB_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Client = new System.Windows.Forms.Label();
            this.lb_LC = new System.Windows.Forms.Label();
            this.cB_Client = new System.Windows.Forms.CheckBox();
            this.dTP_LC = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bN_CardInfo)).BeginInit();
            this.bN_CardInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pB_Logo
            // 
            this.pB_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pB_Logo.Image")));
            this.pB_Logo.Location = new System.Drawing.Point(405, 12);
            this.pB_Logo.Name = "pB_Logo";
            this.pB_Logo.Size = new System.Drawing.Size(180, 180);
            this.pB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pB_Logo.TabIndex = 0;
            this.pB_Logo.TabStop = false;
            this.pB_Logo.Click += new System.EventHandler(this.pB_Logo_Click);
            // 
            // bN_CardInfo
            // 
            this.bN_CardInfo.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bN_CardInfo.CountItem = this.bNCI_Num;
            this.bN_CardInfo.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bN_CardInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bNMFI_First,
            this.bNMPI_Previous,
            this.bindingNavigatorSeparator,
            this.bNPI_Num,
            this.bNCI_Num,
            this.bindingNavigatorSeparator1,
            this.bNMNI_Next,
            this.bNMLI_Last,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bN_CardInfo.Location = new System.Drawing.Point(0, 0);
            this.bN_CardInfo.MoveFirstItem = this.bNMFI_First;
            this.bN_CardInfo.MoveLastItem = this.bNMLI_Last;
            this.bN_CardInfo.MoveNextItem = this.bNMNI_Next;
            this.bN_CardInfo.MovePreviousItem = this.bNMPI_Previous;
            this.bN_CardInfo.Name = "bN_CardInfo";
            this.bN_CardInfo.PositionItem = this.bNPI_Num;
            this.bN_CardInfo.Size = new System.Drawing.Size(592, 25);
            this.bN_CardInfo.TabIndex = 1;
            this.bN_CardInfo.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bNCI_Num
            // 
            this.bNCI_Num.Name = "bNCI_Num";
            this.bNCI_Num.Size = new System.Drawing.Size(39, 22);
            this.bNCI_Num.Text = "of {0}";
            this.bNCI_Num.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bNMFI_First
            // 
            this.bNMFI_First.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bNMFI_First.Image = ((System.Drawing.Image)(resources.GetObject("bNMFI_First.Image")));
            this.bNMFI_First.Name = "bNMFI_First";
            this.bNMFI_First.RightToLeftAutoMirrorImage = true;
            this.bNMFI_First.Size = new System.Drawing.Size(23, 22);
            this.bNMFI_First.Text = "移到第一条记录";
            this.bNMFI_First.Click += new System.EventHandler(this.bNMFI_First_Click);
            // 
            // bNMPI_Previous
            // 
            this.bNMPI_Previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bNMPI_Previous.Image = ((System.Drawing.Image)(resources.GetObject("bNMPI_Previous.Image")));
            this.bNMPI_Previous.Name = "bNMPI_Previous";
            this.bNMPI_Previous.RightToLeftAutoMirrorImage = true;
            this.bNMPI_Previous.Size = new System.Drawing.Size(23, 22);
            this.bNMPI_Previous.Text = "移到上一条记录";
            this.bNMPI_Previous.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bNPI_Num
            // 
            this.bNPI_Num.AccessibleName = "位置";
            this.bNPI_Num.AutoSize = false;
            this.bNPI_Num.Name = "bNPI_Num";
            this.bNPI_Num.Size = new System.Drawing.Size(50, 23);
            this.bNPI_Num.Text = "0";
            this.bNPI_Num.ToolTipText = "当前位置";
            this.bNPI_Num.TextChanged += new System.EventHandler(this.bNPI_Num_TextChanged);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bNMNI_Next
            // 
            this.bNMNI_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bNMNI_Next.Image = ((System.Drawing.Image)(resources.GetObject("bNMNI_Next.Image")));
            this.bNMNI_Next.Name = "bNMNI_Next";
            this.bNMNI_Next.RightToLeftAutoMirrorImage = true;
            this.bNMNI_Next.Size = new System.Drawing.Size(23, 22);
            this.bNMNI_Next.Text = "移到下一条记录";
            this.bNMNI_Next.Click += new System.EventHandler(this.bNMNI_Next_Click);
            // 
            // bNMLI_Last
            // 
            this.bNMLI_Last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bNMLI_Last.Image = ((System.Drawing.Image)(resources.GetObject("bNMLI_Last.Image")));
            this.bNMLI_Last.Name = "bNMLI_Last";
            this.bNMLI_Last.RightToLeftAutoMirrorImage = true;
            this.bNMLI_Last.Size = new System.Drawing.Size(23, 22);
            this.bNMLI_Last.Text = "移到最后一条记录";
            this.bNMLI_Last.Click += new System.EventHandler(this.bNMLI_Last_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lb_CID
            // 
            this.lb_CID.AutoSize = true;
            this.lb_CID.Location = new System.Drawing.Point(41, 47);
            this.lb_CID.Name = "lb_CID";
            this.lb_CID.Size = new System.Drawing.Size(65, 12);
            this.lb_CID.TabIndex = 2;
            this.lb_CID.Text = "ContactID:";
            // 
            // tB_CID
            // 
            this.tB_CID.Location = new System.Drawing.Point(121, 44);
            this.tB_CID.Name = "tB_CID";
            this.tB_CID.Size = new System.Drawing.Size(256, 21);
            this.tB_CID.TabIndex = 3;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(41, 92);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(35, 12);
            this.lb_Name.TabIndex = 4;
            this.lb_Name.Text = "Name:";
            // 
            // tB_Name
            // 
            this.tB_Name.Location = new System.Drawing.Point(121, 89);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(256, 21);
            this.tB_Name.TabIndex = 5;
            // 
            // tB_Telephone
            // 
            this.tB_Telephone.Location = new System.Drawing.Point(121, 176);
            this.tB_Telephone.Name = "tB_Telephone";
            this.tB_Telephone.Size = new System.Drawing.Size(256, 21);
            this.tB_Telephone.TabIndex = 9;
            // 
            // lb_Tp
            // 
            this.lb_Tp.AutoSize = true;
            this.lb_Tp.Location = new System.Drawing.Point(41, 179);
            this.lb_Tp.Name = "lb_Tp";
            this.lb_Tp.Size = new System.Drawing.Size(65, 12);
            this.lb_Tp.TabIndex = 8;
            this.lb_Tp.Text = "Telephone:";
            // 
            // tB_Company
            // 
            this.tB_Company.Location = new System.Drawing.Point(121, 131);
            this.tB_Company.Name = "tB_Company";
            this.tB_Company.Size = new System.Drawing.Size(256, 21);
            this.tB_Company.TabIndex = 7;
            // 
            // lb_Cp
            // 
            this.lb_Cp.AutoSize = true;
            this.lb_Cp.Location = new System.Drawing.Point(39, 134);
            this.lb_Cp.Name = "lb_Cp";
            this.lb_Cp.Size = new System.Drawing.Size(53, 12);
            this.lb_Cp.TabIndex = 6;
            this.lb_Cp.Text = "ComPany:";
            // 
            // tB_Email
            // 
            this.tB_Email.Location = new System.Drawing.Point(121, 221);
            this.tB_Email.Name = "tB_Email";
            this.tB_Email.Size = new System.Drawing.Size(256, 21);
            this.tB_Email.TabIndex = 11;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(41, 224);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(41, 12);
            this.lb_Email.TabIndex = 10;
            this.lb_Email.Text = "Email:";
            // 
            // lb_Client
            // 
            this.lb_Client.AutoSize = true;
            this.lb_Client.Location = new System.Drawing.Point(41, 267);
            this.lb_Client.Name = "lb_Client";
            this.lb_Client.Size = new System.Drawing.Size(47, 12);
            this.lb_Client.TabIndex = 12;
            this.lb_Client.Text = "Client:";
            // 
            // lb_LC
            // 
            this.lb_LC.AutoSize = true;
            this.lb_LC.Location = new System.Drawing.Point(41, 308);
            this.lb_LC.Name = "lb_LC";
            this.lb_LC.Size = new System.Drawing.Size(65, 12);
            this.lb_LC.TabIndex = 13;
            this.lb_LC.Text = "Last Call:";
            // 
            // cB_Client
            // 
            this.cB_Client.AutoSize = true;
            this.cB_Client.Location = new System.Drawing.Point(121, 266);
            this.cB_Client.Name = "cB_Client";
            this.cB_Client.Size = new System.Drawing.Size(78, 16);
            this.cB_Client.TabIndex = 14;
            this.cB_Client.Text = "checkBox1";
            this.cB_Client.UseVisualStyleBackColor = true;
            // 
            // dTP_LC
            // 
            this.dTP_LC.Location = new System.Drawing.Point(121, 302);
            this.dTP_LC.Name = "dTP_LC";
            this.dTP_LC.Size = new System.Drawing.Size(256, 21);
            this.dTP_LC.TabIndex = 15;
            // 
            // CardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 343);
            this.Controls.Add(this.dTP_LC);
            this.Controls.Add(this.cB_Client);
            this.Controls.Add(this.lb_LC);
            this.Controls.Add(this.lb_Client);
            this.Controls.Add(this.tB_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.tB_Telephone);
            this.Controls.Add(this.lb_Tp);
            this.Controls.Add(this.tB_Company);
            this.Controls.Add(this.lb_Cp);
            this.Controls.Add(this.tB_Name);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.tB_CID);
            this.Controls.Add(this.lb_CID);
            this.Controls.Add(this.bN_CardInfo);
            this.Controls.Add(this.pB_Logo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardInfo";
            this.Text = "Objectville Paper Company Contact List";
            this.Load += new System.EventHandler(this.CardInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bN_CardInfo)).EndInit();
            this.bN_CardInfo.ResumeLayout(false);
            this.bN_CardInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_Logo;
        private System.Windows.Forms.BindingNavigator bN_CardInfo;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bNCI_Num;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bNMFI_First;
        private System.Windows.Forms.ToolStripButton bNMPI_Previous;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bNPI_Num;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bNMNI_Next;
        private System.Windows.Forms.ToolStripButton bNMLI_Last;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label lb_CID;
        private System.Windows.Forms.TextBox tB_CID;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.TextBox tB_Telephone;
        private System.Windows.Forms.Label lb_Tp;
        private System.Windows.Forms.TextBox tB_Company;
        private System.Windows.Forms.Label lb_Cp;
        private System.Windows.Forms.TextBox tB_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Client;
        private System.Windows.Forms.Label lb_LC;
        private System.Windows.Forms.CheckBox cB_Client;
        private System.Windows.Forms.DateTimePicker dTP_LC;
    }
}

