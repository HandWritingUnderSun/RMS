using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RMS.UI
{
    public partial class CardInfo : Form
    {
        //BLL m_bl = new BLL();

        //List<People> people = new List<People>();

        //BindingSource bs = new BindingSource();

        public CardInfo()
        {
            InitializeComponent();
        }

        private void CardInfo_Load(object sender, EventArgs e)
        {
            //Init_PeopleList();
            //bs.DataSource = people;
            //bN_CardInfo.BindingSource = bs;
            ////Get_CardInfo(Convert .ToInt32(bNPI_Num.Text)-1);
        }

        private void pB_Logo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List 1.0.\nWritten by : zhuyu","About");
        }




        private void Get_CardInfo(int num)
        {
            //tB_CID.Text = people[num].ID.ToString();
            //tB_Name.Text = people[num].Name.ToString();
            //tB_Company.Text = people[num].Company.ToString();
            //tB_Telephone.Text = people[num].Telephone.ToString();
            //tB_Email.Text = people[num].Email.ToString();
            //cB_Client.Checked = Convert.ToBoolean(people[num].Client.ToString());
            //dTP_LC.Value = Convert.ToDateTime(people[num].LastCall.ToString());
        }



        /// <summary>
        /// 查询所有联系人信息
        /// </summary>
        private void Init_PeopleList()
        {
            //int num = m_bl.select_CardInfo().Tables[0].Rows.Count;
            //for (int i = 0; i < num; i++)
            //{
            //    people.Add(new People(Convert.ToInt32(m_bl.select_CardInfo().Tables[0].Rows[i][0].ToString()),
            //                      m_bl.select_CardInfo().Tables[0].Rows[i][1].ToString(),
            //                      m_bl.select_CardInfo().Tables[0].Rows[i][2].ToString(),
            //                      m_bl.select_CardInfo().Tables[0].Rows[i][3].ToString(),
            //                      m_bl.select_CardInfo().Tables[0].Rows[i][4].ToString(),
            //                      Convert.ToBoolean(m_bl.select_CardInfo().Tables[0].Rows[i][5].ToString()),
            //                      Convert.ToDateTime(m_bl.select_CardInfo().Tables[0].Rows[i][6].ToString())));
            //}
        }

        /// <summary>
        /// 移动到第一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNMFI_First_Click(object sender, EventArgs e)
        {
            //this.bs.MoveFirst();
        }

        /// <summary>
        /// 移动到前一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            //this.bs.MovePrevious();
        }

        /// <summary>
        /// 移动到下一个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNMNI_Next_Click(object sender, EventArgs e)
        {
            //this.bs.MoveNext();
        }

        /// <summary>
        /// 移动到最后一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNMLI_Last_Click(object sender, EventArgs e)
        {
            //this.bs.MoveLast();
        }

        private void bNPI_Num_TextChanged(object sender, EventArgs e)
        {
            //Get_CardInfo(Convert.ToInt32(bNPI_Num.Text) - 1);
        }

    }
}
