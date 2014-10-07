using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;
namespace LBS
{
    public class LogHelper
    {
        //日志
        /// <summary>
        /// 创建本地日志
        /// </summary>
        /// <param name="path">文件的名称</param>
        /// <param name="logtext">插入的日志内容</param>
        public static void CreateLocalLog(string path,string filename, string logtext)
        {
            try
            {
                string currentpath;
                currentpath = Directory.GetCurrentDirectory() + "\\"+path;
                string pathandfilename;
                if (Directory.Exists(currentpath) == false)
                {
                    Directory.CreateDirectory(currentpath);
                }
                pathandfilename = currentpath + "\\" + filename;

                FileStream fs;
                if (File.Exists(pathandfilename))
                    fs = new FileStream(pathandfilename, FileMode.Append, FileAccess.Write);
                else
                    fs = new FileStream(pathandfilename, FileMode.Create, FileAccess.Write);
                fs.Write(Encoding.Default.GetBytes(logtext), 0, Encoding.Default.GetBytes(logtext).Length);
                fs.Close();
            }
            catch (Exception)
            {
                
            }
            
        }
        /// <summary>
        /// 创建错误日志 ---在数据库中
        /// </summary>
        /// <param name="logid"> 日志id</param>
        /// <param name="logdate">时间</param>
        /// <param name="logtext">内容</param>
        /// <param name="logtype">内别</param>
        public static void CreateSQLLog(string logid, string logdate, string logtext, string logtype)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into ErrorLog(");
                strSql.Append("logid,logdate,logtext,ogtype)");
                strSql.Append(" values (");
                strSql.Append("@LoginDate,@LoginName,@LoginStatus,@EmployeeNo)");
                SqlParameter[] parameters = {
                    new SqlParameter("@LoginDate", SqlDbType.NVarChar),
                    new SqlParameter("@LoginName", SqlDbType.NVarChar),
                    new SqlParameter("@LoginStatus", SqlDbType.NVarChar),
                    new SqlParameter("@EmployeeNo", SqlDbType.NVarChar)};
                parameters[0].Value = logid;//当前日间
                parameters[1].Value = logdate;
                parameters[2].Value = logtext;
                parameters[3].Value = logtype;
                SQLHelper.ExecuteScalar(strSql.ToString(), CommandType.Text, parameters);

            }
            catch (Exception e)
            {
                CreateLocalLog("ErrorLog", "SQLError", e.Message);
            }

        }
    }
}
