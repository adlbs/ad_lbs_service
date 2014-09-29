using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PELessons.DAL
{
    /// <summary>
    /// 真正对数据库进行操作的类，固定的，在其它项目中可以直接使用
    /// </summary>
    public class SQLHelper
    {
        //从Web.config中取数据库的连接字符串
        static string conString = @"Server=172.16.3.109;Database=LbsDB ;uid=admin888;pwd=lbsadmin";
        //static string conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        /// <summary>
        /// 执行增、删、改的SQL语句或存储过程，返回受影响的行数
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="cmdType"></param>
        /// <returns></returns>
        public static  int ExecuteNonQuery(string cmdText, CommandType cmdType)
        {
            int r;
            using (SqlConnection cn = new SqlConnection(conString))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(cmdText, cn);
                    cmd.CommandType = cmdType;
                    r = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return r;
        }

        /// <summary>
        /// 执行带参数的增、删、改的SQL语句或存储过程，返回受影响的行数
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="cmdType"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string cmdText, CommandType cmdType, SqlParameter[] paras)
        {
            int r;
            using (SqlConnection cn = new SqlConnection(conString))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(cmdText, cn);
                    cmd.CommandType = cmdType;
                    cmd.Parameters.AddRange(paras);
                    r = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return r;
        }

        /// <summary>
        /// 执行SQL查询语句或存储过程，返回DataSet
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="cmdType"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string cmdText, CommandType cmdType)
        {
            DataSet ds = new DataSet();
            using (SqlConnection cn = new SqlConnection(conString))
            {
                try
                {
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmdText, cn);
                    da.SelectCommand.CommandType = cmdType;
                    da.Fill(ds);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return ds;
        }

        /// <summary>
        /// 执行带参数的SQL查询语句或存储过程，返回DataSet
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="cmdType"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string cmdText, CommandType cmdType, SqlParameter[] paras)
        {
            DataSet ds = new DataSet();
            using (SqlConnection cn = new SqlConnection(conString))
            {
                try
                {
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmdText, cn);
                    da.SelectCommand.CommandType = cmdType;
                    da.SelectCommand.Parameters.AddRange(paras);
                    da.Fill(ds);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return ds;
        }

        /// <summary>
        /// 执行不带参数的SQL查询语句或存储过程，返回DataReader
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="cmdType"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteDataReader(string cmdText, CommandType cmdType)
        {
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(conString);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(cmdText, cn);
                    cmd.CommandType = cmdType;
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return dr;
        }


        /// <summary>
        /// 执行带参数的SQL查询语句或存储过程，返回DataReader
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="cmdType"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteDataReader(string cmdText, CommandType cmdType, SqlParameter[] paras)
        {
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(conString);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(cmdText, cn);
                    cmd.CommandType = cmdType;
                    cmd.Parameters.AddRange(paras);
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return dr;
        }

        /// <summary>
        /// 执行不带参数的SQL查询语句或存储过程，返回结果集的首行首列
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="cmdType"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string cmdText, CommandType cmdType)
        {
            object o;
            using (SqlConnection cn = new SqlConnection(conString))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(cmdText, cn);
                    cmd.CommandType = cmdType;
                    o = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return o;
        }

        /// <summary>
        /// 执行带参数的SQL查询语句或存储过程，返回结果集的首行首列
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="cmdType"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string cmdText, CommandType cmdType, SqlParameter[] paras)
        {
            object o;
            using (SqlConnection cn = new SqlConnection(conString))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(cmdText, cn);
                    cmd.CommandType = cmdType;
                    cmd.Parameters.AddRange(paras);
                    o = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return o;
        }
    }
}
