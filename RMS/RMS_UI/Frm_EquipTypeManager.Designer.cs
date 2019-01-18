namespace RMS.UI
{
    partial class Frm_EquipTypeManager
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
            this.dGV_EquipType = new System.Windows.Forms.DataGridView();
            this.tB_EquipType = new System.Windows.Forms.TextBox();
            this.btn_AddMatType = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_EquipType)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_EquipType
            // 
            this.dGV_EquipType.AllowUserToAddRows = false;
            this.dGV_EquipType.AllowUserToDeleteRows = false;
            this.dGV_EquipType.AllowUserToResizeColumns = false;
            this.dGV_EquipType.AllowUserToResizeRows = false;
            this.dGV_EquipType.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dGV_EquipType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGV_EquipType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_EquipType.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_EquipType.Location = new System.Drawing.Point(17, 16);
            this.dGV_EquipType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dGV_EquipType.Name = "dGV_EquipType";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dGV_EquipType.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_EquipType.RowTemplate.Height = 23;
            this.dGV_EquipType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_EquipType.Size = new System.Drawing.Size(550, 440);
            this.dGV_EquipType.TabIndex = 5;
            this.dGV_EquipType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_MatUnit_CellContentClick);
            // 
            // tB_EquipType
            // 
            this.tB_EquipType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_EquipType.Location = new System.Drawing.Point(17, 501);
            this.tB_EquipType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tB_EquipType.Name = "tB_EquipType";
            this.tB_EquipType.Size = new System.Drawing.Size(256, 23);
            this.tB_EquipType.TabIndex = 7;
            // 
            // btn_AddMatType
            // 
            this.btn_AddMatType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMatType.Location = new System.Drawing.Point(314, 495);
            this.btn_AddMatType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddMatType.Name = "btn_AddMatType";
            this.btn_AddMatType.Size = new System.Drawing.Size(112, 39);
            this.btn_AddMatType.TabIndex = 6;
            this.btn_AddMatType.Text = "新增";
            this.btn_AddMatType.UseVisualStyleBackColor = true;
            this.btn_AddMatType.Click += new System.EventHandler(this.btn_AddMatUnit_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(455, 495);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 39);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Frm_EquipTypeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 591);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.tB_EquipType);
            this.Controls.Add(this.btn_AddMatType);
            this.Controls.Add(this.dGV_EquipType);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EquipTypeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配属装备类型管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_MatUnitManager_FormClosing);
            this.Load += new System.EventHandler(this.Frm_EquipTypeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_EquipType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dGV_EquipType;
        private System.Windows.Forms.TextBox tB_EquipType;
        private System.Windows.Forms.Button btn_AddMatType;
        private System.Windows.Forms.Button btn_Close;

    }
}