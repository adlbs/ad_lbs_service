﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
<<<<<<< HEAD
namespace LBS
=======
namespace LbsDAl
>>>>>>> origin/master
{
    /// <summary>
    /// 真正对数据库进行操作的类，固定的，在其他项目中可以直接使用
    /// </summary>
    public static class SQLHelper
    {
        //无法取出app.config中的链接字符串的值--还在解决中
        // public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        public static string constr = @"Data Source=PC-20140223IKWV\SQLEXPRESS;Initial Catalog=LbsDB;Integrated Security=True";
        /// <summary>
        /// 执行不带参数的增删改的SQL语句或存储过程，返回受影响的行数
        /// </summary>
        /// <param name="cmdText">cmd命令</param>
        /// <param name="cmdType">cmd类型</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNonQuery(string cmdText, CommandType cmdType)
        {
            int r;
            using (SqlConnection cn = new SqlConnection(constr))
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
        /// 执行带参数的增删改的SQL语句或存储过程，返回受影响的行数
        /// </summary>
        /// <param name="cmdText">cmd命令</param>
        /// <param name="cmdType">cmd类型</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNonQuery(string cmdText, CommandType cmdType, SqlParameter[] param)
        {

            CheckParamException(param);
            int r;
            using (SqlConnection cn = new SqlConnection(constr))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(cmdText, cn);
                    cmd.CommandType = cmdType;
                    cmd.Parameters.AddRange(param);
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
        /// 执行不带数据库参数的查询语句或存储过程，返回一个DataSet结果集
        /// </summary>
        /// <param name="cmdText">cmd命令</param>
        /// <param name="cmdType">cmd类型</param>
        /// <returns>返回DataSet结果集</returns>
        public static DataSet ExecuteDataSet(string cmdText, CommandType cmdType)
        {
            DataSet ds = new DataSet();
            using (SqlConnection cn = new SqlConnection(constr))
            {
                try
                {
                    cn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmdText, cn);
                    sda.SelectCommand.CommandType = cmdType;
                    sda.Fill(ds);
                }
                catch
                {
                    throw;
                }

            }
            return ds;
        }
        /// <summary>
        /// 执行带数据库参数的查询语句或存储过程，返回一个DataSet结果集
        /// </summary>
        /// <param name="cmdText">cmd命令</param>
        /// <param name="cmdType">cmd类型</param>
        /// <returns>返回DataSet结果集</returns>
        public static DataSet ExecuteDataSet(string cmdText, CommandType cmdType, SqlParameter[] param)
        {
            DataSet ds = new DataSet();
            using (SqlConnection cn = new SqlConnection(constr))
            {
                try
                {
                    cn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmdText, cn);
                    sda.SelectCommand.CommandType = cmdType;
                    sda.SelectCommand.Parameters.AddRange(param);
                    sda.Fill(ds);
                }
                catch
                {
                    throw;
                }

            }
            return ds;
        }
        /// <summary>
        /// 执行不带数据库参数的查询语句或存储过程，返回一个DataReader结果集
        /// </summary>
        /// <param name="cmdText">cmd命令</param>
        /// <param name="cmdType">cmd类型</param>
        /// <returns>返回DataReader结果集</returns>
        public static SqlDataReader ExecuteDataReader(string cmdText, CommandType cmdType)
        {
            SqlDataReader sdr;
            SqlConnection cn = new SqlConnection(constr);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(cmdText, cn);
                cmd.CommandType = cmdType;
                sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                throw;
            }
            return sdr;
        }
        /// <summary>
        /// 执行带数据库参数的查询语句或存储过程，返回一个DataReader结果集
        /// </summary>
        /// <param name="cmdText">cmd命令</param>
        /// <param name="cmdType">cmd类型</param>
        /// <returns>返回DataReader结果集</returns>
        public static SqlDataReader ExecuteDataReader(string cmdText, CommandType cmdType, SqlParameter[] param)
        {
            SqlDataReader sdr;
            SqlConnection cn = new SqlConnection(constr);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(cmdText, cn);
                cmd.CommandType = cmdType;
                cmd.Parameters.AddRange(param);
                sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                throw;
            }
            return sdr;
        }
        /// <summary>
        /// 执行不带数据库参数的查询语句或存储过程，返回首行首列
        /// </summary>
        /// <param name="cmdText">cmd命令</param>
        /// <param name="cmdType">cmd类型</param>
        /// <returns>返回首行首列</returns>
        public static object ExecuteScalar(string cmdText, CommandType cmdType)
        {
            object o;
            using (SqlConnection cn = new SqlConnection(constr))
            {

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(cmdText, cn);
                    cmd.CommandType = cmdType;
                    o = cmd.ExecuteScalar();
                }
                catch
                {
                    throw;
                }
            }
            return o;
        }
        /// <summary>
        /// 执行带数据库参数的查询语句或存储过程，返回首行首列
        /// </summary>
        /// <param name="cmdText">cmd命令</param>
        /// <param name="cmdType">cmd类型</param>
        /// <returns>返回首行首列</returns>
        public static object ExecuteScalar(string cmdText, CommandType cmdType, SqlParameter[] param)
        {
            object o;
            using (SqlConnection cn = new SqlConnection(constr))
            {

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(cmdText, cn);
                    cmd.CommandType = cmdType;
                    cmd.Parameters.AddRange(param);
                    o = cmd.ExecuteScalar();
                }
                catch
                {
                    throw;
                }
            }
            return o;
        }

        /// <summary>
        /// 检查参数是否为空
        /// </summary>
        public static void CheckParamException(SqlParameter[] commandParameters)
        {
            if (commandParameters != null)
            {
                foreach (SqlParameter p in commandParameters)
                {
                    if (p != null)
                    {
                        // 检查未分配值的输出参数,将其分配以DBNull.Value. 
                        if ((p.Direction == ParameterDirection.InputOutput || p.Direction == ParameterDirection.Input) &&
                            (p.Value == null))
                        {
                            p.Value = DBNull.Value;
                        }
                    }
                }
            }
        }

    }
}
