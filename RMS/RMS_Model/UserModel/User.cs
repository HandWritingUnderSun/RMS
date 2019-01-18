using System;
using System.Collections.Generic;
using System.Linq;

/***
 * 模型，用户实例类
 * 2017年02月08日修改
 * zhuyu
 * */


namespace RMS.Model
{
    /// <summary>
    /// 系统用户类
    /// </summary>
    public class User
    {
        public string LoginId { get; set; }
        public string LoginPwd { get; set; }
        public string LoginType { get; set; }
        public string LoginRemark { get; set; }
        /// <summary>
        /// 与单位人员相关联
        /// </summary>
        public string PersonID { get; set; }


    }
}
