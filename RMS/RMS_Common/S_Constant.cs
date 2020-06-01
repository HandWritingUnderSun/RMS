using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Common
{
    class S_Constant
    {
        public static string PAGE_END = ".do";
        public static string AppPath;
        public static string TemplateBase;
        public static string VirtualDir;
        public static string PreProcessRequest;
        public static string PreAction;
        public static string ModulesPath;
        public static string DEBUG_ACTION_MAPPING_TEMPLATE;
        public static IevLog logger;
        public static ILog logger4 = LogManager.GetLogger(typeof(Constant));
        public static string ProductID;
        public static string LogSecurityRecord; //记录审计日志记录情况。
        public static Hashtable s_ConstantHashtable = new Hashtable();

        public static string ReadProperty(string name)
        {
            switch (name)
            {
                case "AppPath":
                    return AppPath;
                case "TemplateBase":
                    return TemplateBase;
                case "VirtualDir":
                    return VirtualDir;
                case "ProductID":
                    return ProductID;
            }
            return "";
        }

        public string ReadProperty2(string name)
        {
            return ReadProperty(name);
        }

        static Constant()
        {
            if (HttpContext.Current != null && HttpContext.Current.Request != null)
                AppPath = HttpContext.Current.Request.PhysicalApplicationPath;
            else
                AppPath = ConfigurationManager.AppSettings["AppPath"];

            //VirtualDir = ConfigurationManager.AppSettings["VirtualDir"];
            PreProcessRequest = ConfigurationManager.AppSettings["PreProcessRequest"];
            //PreAction = ConfigurationManager.AppSettings["PreAction"];
            DEBUG_ACTION_MAPPING_TEMPLATE = ConfigurationManager.AppSettings["DEBUG_ACTION_MAPPING_TEMPLATE"];
            if (DEBUG_ACTION_MAPPING_TEMPLATE + "" == "")
                DEBUG_ACTION_MAPPING_TEMPLATE = @"/modules/portal/view/ezweb/mc.htm";
            ModulesPath = Constant.AppPath + "/modules";

            //ProductID = ConfigurationManager.AppSettings["ProductID"];



            //将s_Constant写入Hashtable 中
            string sql = @"SELECT    cname,CValue FROM dbo.s_Constant WHERE CName IN(
                            SELECT  cname  FROM  s_Constant GROUP BY CName  HAVING COUNT(*)=1
                            )";
            DataTable dt = DataSource.ExecuteQuery(sql);

            //Hashtable s_ConstantHashtable = new Hashtable(); 
            constant_tempvalue cvlue = new constant_tempvalue();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s_ConstantHashtable.Add(dt.Rows[i]["cname"].ToString().ToUpper(), dt.Rows[i]["CValue"].ToString());
            }
            if (Constant.s_ConstantHashtable["TEMPLATEPATH"] != null)
            {
                TemplateBase = Constant.s_ConstantHashtable["TEMPLATEPATH"].ToString() + "";
            }
            else
            {
                TemplateBase = cvlue.templatepath.ToString(); ;
                Constant.s_ConstantHashtable.Add("TEMPLATEPATH", "");
            }
            if (Constant.s_ConstantHashtable["ZHAOPIAN_PATH"] == null)
            {
                Constant.s_ConstantHashtable.Add("ZHAOPIAN_PATH", cvlue.zhaopian_path.ToString());
            }
            if (Constant.s_ConstantHashtable["PDAOUTPUTPATH"] == null)
            {
                Constant.s_ConstantHashtable.Add("PDAOUTPUTPATH", cvlue.PDAOutputPath.ToString());
            }
            if (Constant.s_ConstantHashtable["LOGPATH"] == null)
            {
                Constant.s_ConstantHashtable.Add("LOGPATH", cvlue.LogPath.ToString());
            }
            if (Constant.s_ConstantHashtable["LOGSECURITYRECORD"] == null)
            {
                LogSecurityRecord = "true";
            }
            else
            {
                LogSecurityRecord = Constant.s_ConstantHashtable["LOGSECURITYRECORD"].ToString();
            }
            if (Constant.s_ConstantHashtable["GBRM_MEETBACKUP"] == null)
            {
                Constant.s_ConstantHashtable.Add("GBRM_MEETBACKUP", cvlue.GBRM_MeetBackUp.ToString());
            }
            if (Constant.s_ConstantHashtable["GBRM_PPTPATH"] == null)
            {
                Constant.s_ConstantHashtable.Add("GBRM_PPTPATH", cvlue.GBRM_PPTPATH.ToString());
            }
        }



        public static void Log(Hashtable data)
        {
            if (logger != null)
                logger.Log(data);
        }

        public static void LogUrl(string raw, string path)
        {
            Hashtable ht = new Hashtable();
            ht.Add("url", raw);
            ht.Add("path", path);
            Log(ht);
        }

        public static void InitLog()
        {
            if (logger == null)
            {
                //string logClass = ConfigurationManager.AppSettings["LogClass"];
                string logClass = "";
                if (Constant.s_ConstantHashtable.ContainsKey("LOGCLASS") == true)
                {
                    logClass = Constant.s_ConstantHashtable["LOGCLASS"].ToString();
                }
                logger4.Info("begin InitLog:" + logClass);
                int pos = logClass.IndexOf(",");
                if (logClass + "" != "" && pos > 0)
                {
                    //object o= Activator.CreateInstance(logClass.Substring(pos + 1), logClass.Substring(0, pos));
                    object o = ReflectionUtil.GetInstance(logClass.Substring(0, pos), logClass.Substring(pos + 1));
                    if (o == null)
                    {
                        throw new ApplicationException(
                            string.Format("create instantce {1},{0}", logClass.Substring(pos + 1),
                                          logClass.Substring(0, pos) + "failed"));
                    }
                    else
                    {
                        logger = (IevLog)o;
                    }
                }
            }
            logger4.Info("finish InitLog" + logger);
        }
    }
}
