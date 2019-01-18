using System;
using System.Windows;
using System.IO;
using System.Windows.Forms;

/**
 * 先以txt测试，然后研究如何加密，并设定自己的格式
 * 
 * */


namespace RMS.UI
{
    public partial class Frm_DairyInfoManager : Form
    {
        #region 单例模式
        private static Frm_DairyInfoManager _instance = null;
        public Frm_DairyInfoManager()
        {
            InitializeComponent();
            rtb_DairyText.AllowDrop = true;
            rtb_DairyText.DragEnter += new DragEventHandler(rtb_DairyText_DragEnter);
            rtb_DairyText.DragDrop += new DragEventHandler(rtb_DairyText_DragDrop);
        }
        public static Frm_DairyInfoManager CreateInstance()
        {
            if (_instance == null)
            {
                _instance = new Frm_DairyInfoManager();
            }
            return _instance;
        }
        #endregion

        string dairyPath = "";

        private void Frm_DairyInfoManager_Load(object sender, EventArgs e)
        {
            Init_lV_FileInfo();

        }

        private void Init_lV_FileInfo()
        {
            lV_FileInfo.View = View.List;

        }

        /// <summary>
        /// 设置字体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_SetFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            rtb_DairyText.Font = fontDialog.Font;
        }

        
        /// <summary>
        /// 设置字体颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_SetColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            rtb_DairyText.ForeColor = colorDialog.Color;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "保存";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter m_sw = new StreamWriter(saveFileDialog.FileName);
                    m_sw.WriteLine(rtb_DairyText.Text);
                    m_sw.Close();
                }
                catch (IOException ioex)
                {
                    MessageBox.Show(ioex.Message);
                    return;
                }
            }
        }

        private void TSMI_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog p_OpenFileDialog = new OpenFileDialog();
            p_OpenFileDialog.Filter = "word文件(*.doc)|*.doc";
            if (p_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("文件长度："+
                    File.Open(p_OpenFileDialog.FileName,FileMode.Open).Length.ToString()+
                    "字节","提示！");
            }
        }

        private void rtb_DairyText_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.FileDrop))
            //{
            //    e.Effect = DragDropEffects.Link;
            //}
            //else
            //{
            //    e.Effect = DragDropEffects.None;
            //}
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string f in files)
                {
                    FileInfo finfo = new FileInfo(f.ToString());
                    rtb_DairyText.Text += finfo.Name.ToString()+"\n";
                 }
            }
        }

        private void rtb_DairyText_DragDrop(object sender,DragEventArgs e)
        {

        }

        private void 设置文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                dairyPath = folderBrowserDialog.SelectedPath;
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(dairyPath);
            try
            {
                if (!directoryInfo.Exists)
                    return;
                FileSystemInfo[] files = directoryInfo.GetFileSystemInfos();
                foreach (FileSystemInfo f in files)
                {
                    FileInfo finfo = new FileInfo(f.ToString());
                    lV_FileInfo.Items.Add(finfo.Name.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
