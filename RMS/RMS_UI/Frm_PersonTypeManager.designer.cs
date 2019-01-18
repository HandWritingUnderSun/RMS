namespace RMS.UI
{
    partial class Frm_PersonTypeManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_PersonType = new System.Windows.Forms.DataGridView();
            this.tb_PersonType = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PersonType
            // 
            this.dgv_PersonType.AllowUserToAddRows = false;
            this.dgv_PersonType.AllowUserToDeleteRows = false;
            this.dgv_PersonType.AllowUserToResizeColumns = false;
            this.dgv_PersonType.AllowUserToResizeRows = false;
            this.dgv_PersonType.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_PersonType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_PersonType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PersonType.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PersonType.Location = new System.Drawing.Point(14, 13);
            this.dgv_PersonType.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_PersonType.Name = "dgv_PersonType";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_PersonType.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PersonType.RowTemplate.Height = 23;
            this.dgv_PersonType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PersonType.Size = new System.Drawing.Size(422, 352);
            this.dgv_PersonType.TabIndex = 8;
            this.dgv_PersonType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PersonType_CellContentClick);
            // 
            // tb_PersonType
            // 
            this.tb_PersonType.Location = new System.Drawing.Point(15, 389);
            this.tb_PersonType.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PersonType.Name = "tb_PersonType";
            this.tb_PersonType.Size = new System.Drawing.Size(177, 22);
            this.tb_PersonType.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(215, 385);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 31);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "新增";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(336, 385);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 31);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Frm_PersonTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 438);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dgv_PersonType);
            this.Controls.Add(this.tb_PersonType);
            this.Controls.Add(this.btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PersonTypeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人员类型管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_FormClosing);
            this.Load += new System.EventHandler(this.Frm_PersonTypeAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_PersonType;
        private System.Windows.Forms.TextBox tb_PersonType;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Close;

    }
}