using System;
using System.Windows.Forms;

namespace RMS.UI
{
    public partial class Frm_ChangeCoulumn : Form
    {
        public Frm_ChangeCoulumn(DataGridView dgv_temp)
        {
            InitializeComponent();
            dgv_ChangeColumn = dgv_temp;            
        }

        DataGridView _changeColumn = new DataGridView();
        public DataGridView dgv_ChangeColumn
        {
            get { return _changeColumn; }
            set { _changeColumn = value; }
        }
        //public Frm_BookInfoManager frmMatInfoManager = null;

        DataGridViewColumnCollection columns;

        public void BookInfoExitRows_UI_Load(object sender, EventArgs e)
        {
            //if (frmMatInfoManager != null)
            //{
            //    columns = frmMatInfoManager.dgv_BookInfo.Columns;
            //}
            columns = _changeColumn.Columns;

            for (int i = 0; i < columns.Count-2; i++)
            {
                if (columns[i].Visible == true)
                {
                    listBox1.Items.Add(columns[i].HeaderText);
                }
                else
                {
                    listBox2.Items.Add(columns[i].HeaderText);
                }
            }
            
            
        }

        /// <summary>
        /// 左移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeft_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectListBox2 = listBox2.SelectedItems;
            for (int i = 0; i < selectListBox2.Count; i++)
            {
                listBox1.Items.Add(selectListBox2[i]);
                for (int j = 0; j < columns.Count - 2; j++)
                {
                    if (columns[j].HeaderText == selectListBox2[i].ToString())
                    {
                        columns[j].Visible = true;
                    }
                }
            }


            ListBox.SelectedIndexCollection indices = listBox2.SelectedIndices;

            for (int i = indices.Count - 1; i >= 0; i--)
            {
                int index = indices[i];
                listBox2.Items.RemoveAt(index);
            }
        }

        /// <summary>
        /// 右移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectListBox1 = listBox1.SelectedItems;
            for (int i = 0; i < selectListBox1.Count; i++)
            {
                listBox2.Items.Add(selectListBox1[i]);
                for (int j = 0; j < columns.Count - 2; j++)
                {
                    if (columns[j].HeaderText == selectListBox1[i].ToString())
                    {
                        columns[j].Visible = false;
                    }
                }
            }


            ListBox.SelectedIndexCollection indices = listBox1.SelectedIndices;
            for (int i = indices.Count - 1; i >=0; i--)
            {
                int index = indices[i];
                listBox1.Items.RemoveAt(index);   
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
