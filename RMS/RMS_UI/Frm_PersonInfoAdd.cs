using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RMS.Command;
using RMS.Model;
using RMS.BLL;

namespace RMS.UI
{
    public partial class Frm_PersonInfoAdd : Form
    {
        public Frm_PersonInfoAdd()
        {
            InitializeComponent();
        }

        public Frm_PersonInfoManager personInfoManager = null;

        PersonInfo_BLL personInfo_BLL = new PersonInfo_BLL();
        UserType_BLL personType_BLL = new UserType_BLL();
        Department_BLL department_BLL = new Department_BLL();

        Com com = new Com();


        private void Frm_PersonInfoAdd_Load(object sender, EventArgs e)
        {
            Init_cbo_PersonType();
            Init_cbo_Sexy();
            Init_cbo_Dept();

        }

        /// <summary>
        /// 初始化性别下来菜单
        /// </summary>
        private void Init_cbo_Sexy()
        {
            cbo_Sexy.Items.Add("男");
            cbo_Sexy.Items.Add("女");
            cbo_Sexy.SelectedIndex = 0;
        }

        /// <summary>
        /// 人员类型的下拉框绑定
        /// </summary>
        private void Init_cbo_PersonType()
        {
            //cbo_PersonType.Items.Clear();
            //cbo_PersonType.DataSource = personType_BLL.SelectPersonType();
            //cbo_PersonType.DisplayMember = "PersonTypeName";
            //cbo_PersonType.ValueMember = "PersonTypeGuid";
        }

        /// <summary>
        /// 部门的下拉框绑定
        /// </summary>
        private void Init_cbo_Dept()
        {
            cbo_Dept.DataSource = department_BLL.selectDepartment();
            cbo_Dept.DisplayMember = "DeptName";
            cbo_Dept.ValueMember = "DeptID";
        }


        /// <summary>
        /// 新增人员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //人员编号必须唯一
            int rows = personInfoManager.dgv_UserInfo.RowCount;
            for (int i = 0; i < rows; i++)
            {
                if (personInfo_BLL.IsPersonIDHaving(tb_PersonID.Text.Trim()))
                {
                    MessageBox.Show("人员编号已存在！！！");
                    return;
                }
            }


            PersonInfo personInfo = new PersonInfo();
            personInfo.PersonID =Convert.ToInt32(tb_PersonID.Text.Trim());
            personInfo.PersonName = tb_PersonName.Text.Trim();


            if (personInfo_BLL.AddPersonInfo(personInfo))
            {
                MessageBox.Show("新增成功！");
                //单击查询 刷新人员信息表
                personInfoManager.ShowLayout_dgv_UserInfo();
                personInfoManager.ShowData_dgv_PersonInfo();

                //自动找到刚刚添加成功的新行，并选中
                com.AutoFindRow(tb_PersonID.Text.Trim(), personInfoManager.dgv_UserInfo);
                this.Close();
            }
            else
            {
                MessageBox.Show("新增失败！");
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
