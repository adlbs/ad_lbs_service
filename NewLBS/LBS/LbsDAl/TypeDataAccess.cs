using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace LbsDAl
{
    /// <summary>
    /// 用户爱好或者商家类型表数据访问类
    /// </summary>
    public static class TypeDataAccess
    {
        /// <summary>
        /// 添加类型
        /// </summary>
        /// <param name="type">类型描述</param>
        /// <returns>true or  false</returns>
        public static bool AddType(LbsModel.Type type)
        {

            string insert_command = "insert into [type] (t_id,t_name)";
            insert_command += " values (@t_id,@t_name)";

            SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@t_id",type.T_ID),
             new SqlParameter("@t_name",type.T_Name),
            };

            int i = SQLHelper.ExecuteNonQuery(insert_command, CommandType.Text, p);
            return i > 0;

        }

        /// <summary>
        /// 修改商家广告类型
        /// </summary>
        /// <param name="type">不为空的type实体类</param>
        /// <returns>true or false</returns>
        public static bool EditTypeInfo(LbsModel.Type type)
        {
            string update_command = "update [type] set t_name=@t_name";
            update_command += " where t_id=@t_id";

            SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@t_id",type.T_ID),
             new SqlParameter("@t_name",type.T_Name),  
            };

            int i = SQLHelper.ExecuteNonQuery(update_command, CommandType.Text, p);
            return i > 0;
        }
        /// <summary>
        /// 根据类型ID查询类型详情
        /// </summary>
        /// <param name="t_ID">类型ID</param>
        /// <returns>类型实体类</returns>
        public static LbsModel.Type SelectByTypeID(int t_ID)
        {
            LbsModel.Type type = new LbsModel.Type();
            string selectType_command = "select * from [type] ";
            selectType_command += "where t_id=@t_id";
            SqlParameter[] p = new SqlParameter[] 
            {
               new SqlParameter("@t_id",t_ID)
            };

            SqlDataReader sdr = SQLHelper.ExecuteDataReader(selectType_command, CommandType.Text, p);

            //将数据库中的此用户信息放入实体类
            while (sdr.Read())
            {
                type.T_ID = (int)sdr["t_id"];
                type.T_Name = sdr["t_name"].ToString();
            }
            return type;
        }


    }
}
