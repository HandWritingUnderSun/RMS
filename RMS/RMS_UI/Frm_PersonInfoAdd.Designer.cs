namespace RMS.UI
{
    partial class Frm_PersonInfoAdd
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_PersonType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_PersonName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_PersonID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_Sexy = new System.Windows.Forms.ComboBox();
            this.cbo_Dept = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Anno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(636, 631);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(112, 39);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(756, 631);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 39);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "退出";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_PersonType);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tb_PersonName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_PersonID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(884, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人员基本信息（必填）";
            // 
            // cbo_PersonType
            // 
            this.cbo_PersonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PersonType.FormattingEnabled = true;
            this.cbo_PersonType.Location = new System.Drawing.Point(122, 121);
            this.cbo_PersonType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_PersonType.Name = "cbo_PersonType";
            this.cbo_PersonType.Size = new System.Drawing.Size(226, 28);
            this.cbo_PersonType.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(46, 124);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "人员类型";
            // 
            // tb_PersonName
            // 
            this.tb_PersonName.Location = new System.Drawing.Point(624, 54);
            this.tb_PersonName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_PersonName.Name = "tb_PersonName";
            this.tb_PersonName.Size = new System.Drawing.Size(226, 27);
            this.tb_PersonName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(536, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "人员姓名";
            // 
            // tb_PersonID
            // 
            this.tb_PersonID.Location = new System.Drawing.Point(122, 54);
            this.tb_PersonID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_PersonID.Name = "tb_PersonID";
            this.tb_PersonID.Size = new System.Drawing.Size(226, 27);
            this.tb_PersonID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(47, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "人员编号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_Sexy);
            this.groupBox2.Controls.Add(this.cbo_Dept);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_Anno);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_Phone);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 226);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(888, 395);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "人员详细信息（选填）";
            // 
            // cbo_Sexy
            // 
            this.cbo_Sexy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Sexy.FormattingEnabled = true;
            this.cbo_Sexy.Location = new System.Drawing.Point(628, 49);
            this.cbo_Sexy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_Sexy.Name = "cbo_Sexy";
            this.cbo_Sexy.Size = new System.Drawing.Size(226, 28);
            this.cbo_Sexy.TabIndex = 30;
            // 
            // cbo_Dept
            // 
            this.cbo_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Dept.FormattingEnabled = true;
            this.cbo_Dept.Location = new System.Drawing.Point(126, 49);
            this.cbo_Dept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_Dept.Name = "cbo_Dept";
            this.cbo_Dept.Size = new System.Drawing.Size(226, 28);
            this.cbo_Dept.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 180);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "备    注";
            // 
            // tb_Anno
            // 
            this.tb_Anno.Location = new System.Drawing.Point(126, 177);
            this.tb_Anno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Anno.Multiline = true;
            this.tb_Anno.Name = "tb_Anno";
            this.tb_Anno.Size = new System.Drawing.Size(728, 174);
            this.tb_Anno.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "手    机";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(552, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "性    别";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(126, 121);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(226, 27);
            this.tb_Phone.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "部    门";
            // 
            // Frm_PersonInfoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PersonInfoAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加人员信息";
            this.Load += new System.EventHandler(this.Frm_PersonInfoAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_PersonName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_PersonID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Anno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbo_PersonType;
        private System.Windows.Forms.ComboBox cbo_Dept;
        private System.Windows.Forms.ComboBox cbo_Sexy;
    }
}