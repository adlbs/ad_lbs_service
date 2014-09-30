using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LBS
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://intelligentfreestyle.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。
    // [System.Web.Script.Services.ScriptService]
    public class LBS : System.Web.Services.WebService
    {
        private const string strcon = @"Server=bds-032.hichina.com;Database=bds0320516_db;uid=bds0320516;pwd=dbyangyao";

        //--------------------------------------------------------------------------------------------
        [WebMethod(Description = "登录服务器")]
        public string login(string username, string userpassword)
        {

            SqlConnection lo_conn = new SqlConnection(strcon);
            try
            {
                lo_conn.Open();
            }
            catch (Exception e)
            {
                return false.ToString() + " " + e.Message;
            }
            try
            {
                SqlCommand Sqlcom = new SqlCommand();
                string sql = "Select tb_user.u_id from tb_user where tb_user.u_name=\'" + username.Trim() + "\' and tb_user.u_password=\'" + userpassword.Trim() + "\'" + " ;";
                Sqlcom.Connection = lo_conn;
                Sqlcom.CommandText = sql;
                int f = (int)Sqlcom.ExecuteScalar();
                lo_conn.Close();
                lo_conn.Dispose();
                if (f > 0)
                    return true.ToString();
                else
                    return false.ToString();
            }
            catch (Exception e)
            {
                return false.ToString()+e.Message;
            }

        }
        //--------------------------------------------------------------------------------------------
        [WebMethod(Description = "获取广告列表")]
        public string getADListByType(string adtype,string hobtype)
        {
            SqlConnection lo_conn = new SqlConnection(strcon);
            try
            {
                lo_conn.Open();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            SqlCommand Sqlcom = new SqlCommand();
            string sql = "";//查询广告的Sql语句
            Sqlcom.Connection = lo_conn;
            Sqlcom.CommandText = sql;
            //SqlDataReader SqlReder = Sqlcom.ExecuteReader();
            SqlDataAdapter dbAdapter = new SqlDataAdapter(Sqlcom);
            DataSet ds = new DataSet();
            dbAdapter.Fill(ds);
            string xml = ds.GetXml();
            lo_conn.Close();
            lo_conn.Dispose();
            return xml;
       
        }
        //--------------------------------------------------------------------------------------------
        [WebMethod(Description = "获取事件详情")]
        public string getADById(int id)
        {
            SqlConnection lo_conn = new SqlConnection(strcon);
            try
            {
                lo_conn.Open();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            SqlCommand Sqlcom = new SqlCommand();
            string sql = "";//SQL语句
            Sqlcom.Connection = lo_conn;
            Sqlcom.CommandText = sql;
            //SqlDataReader SqlReder = Sqlcom.ExecuteReader();
            SqlDataAdapter dbAdapter = new SqlDataAdapter(Sqlcom);
            DataSet ds = new DataSet();
            dbAdapter.Fill(ds);
            string xml = ds.GetXml();
            lo_conn.Close();
            lo_conn.Dispose();
            return xml;

        }
        //--------------------------------------------------------------------------------------------
        [WebMethod(Description = "执行一条指定SQL只返回执行是否成功")]
        public string setSQL(string sql)
        {
            SqlConnection lo_conn = new SqlConnection(strcon);
            try
            {
                lo_conn.Open();
            }
            catch (Exception )
            {
                return false.ToString();
            }
            try
            {
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.Connection = lo_conn;
                Sqlcom.CommandText = sql;
                Sqlcom.ExecuteScalar();
                lo_conn.Close();
                lo_conn.Dispose();
                return true.ToString();
            }
            catch (Exception )
            {
                return false.ToString();
            }
        }
        //--------------------------------------------------------------------------------------------
        [WebMethod(Description = "注册新用户  目前只是模型,具体不一定这么写")]
        public string register(string username, string userpassword,string type)
        { 
             SqlConnection lo_conn = new SqlConnection(strcon);
            try
            {
                lo_conn.Open();
            }
            catch (Exception )
            {
                return false.ToString();
            }
            try
            {
                SqlCommand Sqlcom = new SqlCommand();
                string sql = @"insert into tb_user(u_name,u_password,u_type) values(\'" + username + "\',\'" + userpassword + "\',"+type+"\');";
                Sqlcom.Connection = lo_conn;
                Sqlcom.CommandText = sql;
                Sqlcom.ExecuteScalar();

                lo_conn.Close();
                lo_conn.Dispose();
                return true.ToString();
            }
            catch (Exception)
            {
                return false.ToString();
            }
           
        }
       
        //--------------------------------------------------------------------------------------------
        [WebMethod(Description = "执行一条指定SQL只返回执行结果-DataSet")]
        public DataSet setSQLOfDataSet(string sql)
        {
            SqlConnection lo_conn = new SqlConnection(strcon);
            try
            {
                lo_conn.Open();
            }
            catch (Exception)
            {
                return null;
            }
            try
            {
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.Connection = lo_conn;
                Sqlcom.CommandText = sql;
                SqlDataAdapter dbAdapter = new SqlDataAdapter(Sqlcom);
                DataSet ds = new DataSet();
                dbAdapter.Fill(ds);
               
                lo_conn.Close();
                lo_conn.Dispose();
                return ds;
               
            }
            catch (Exception)
            {
                return null;
            }
        }
        //--------------------------------------------------------------------------------------------
        [WebMethod(Description = "执行一条指定SQL只返回执行结果-XML")]
        public string setSQLOfXML(string sql)
        {
            SqlConnection lo_conn = new SqlConnection(strcon);
            try
            {
                lo_conn.Open();
            }
            catch (Exception)
            {
                return "";
            }
            try
            {
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.Connection = lo_conn;
                Sqlcom.CommandText = sql;
                
                SqlDataAdapter dbAdapter = new SqlDataAdapter(Sqlcom);
                DataSet ds = new DataSet();
                dbAdapter.Fill(ds);
                string xml = ds.GetXml();
                lo_conn.Close();
                lo_conn.Dispose();
                return xml;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}