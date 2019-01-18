using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RMS.BLL;

namespace RMS.UI
{
    public partial class Frm_BulkImportMatInfo : Form
    {
        DateBaseInfo_BLL dateBaseInfo_BLL = new DateBaseInfo_BLL();

        public Frm_BulkImportMatInfo()
        {
            InitializeComponent();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePath = new OpenFileDialog(); //定义一个文件打开空间
            filePath.InitialDirectory = Application.StartupPath;//设置打开目录，.exe文件所在目录
            filePath.Filter = "所有文件|（*.*）|Excel文件|*.xls;*.xlsx";
            filePath.RestoreDirectory = true;
            filePath.FilterIndex = 1;
            if (filePath.ShowDialog() == DialogResult.OK)
            {
                tb_FilePath.Text = filePath.FileName.ToString();
            }
        }

        private void Init_cbb_DataBase()
        {
            cbb_DataBase.DataSource = dateBaseInfo_BLL.GetDataTableName();
        }

        private void Frm_BulkImportMatInfo_Load(object sender, EventArgs e)
        {
            Init_cbb_DataBase();
        }

    }
}
