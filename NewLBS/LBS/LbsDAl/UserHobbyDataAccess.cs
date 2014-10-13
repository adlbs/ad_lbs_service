using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace LbsDAl
{
    /// <summary>
    /// 用户爱好表的数据访问类
    /// </summary>
    public static class UserHobbyDataAccess
    {
        /// <summary>
        /// 添加用户爱好
        /// </summary>
        /// <param name="uh">用户爱好表实体类</param>
        /// <returns>true or false</returns>
        public static bool AddUserHoby(LbsModel.UserHobby uh)
        {

            string insert_command = "insert into userhobby (u_id,t_id,uh_createtime,uh_altertime)";
            insert_command += " values (@u_id,@t_id,@uh_createtime,@uh_altertime)";

            SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@u_id",uh.U_ID),
             new SqlParameter("@t_id",uh.T_ID),
             new SqlParameter("@uh_createtime",uh.Uh_CreateTime),
             new SqlParameter("@uh_altertime",uh.Uh_AlterTime)
            };

            int i = SQLHelper.ExecuteNonQuery(insert_command, CommandType.Text, p);
            return i > 0;

        }

       /// <summary>
       /// 修改用户爱好
       /// </summary>
       /// <param name="uh">用户爱好实体类</param>
       /// <param name="editAfter_t_id">修改值t_ID</param>
       /// <returns>true or false</returns>
        public static bool EditUserHobby(LbsModel.UserHobby uh,int editAfter_t_id)
        {
            string update_command = "update userhobby set u_id=@u_id,t_id=@editAfter_t_id,uh_createtime=@uh_createtime,uh_altertime=@uh_altertime";
            update_command += " where t_id=@t_id and u_id=@u_id";

            SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@u_id",uh.U_ID),
             new SqlParameter("@t_id",uh.T_ID),
             new SqlParameter("@editAfter_t_id",editAfter_t_id),
             new SqlParameter("@uh_createtime",uh.Uh_CreateTime),
             new SqlParameter("@uh_altertime",uh.Uh_AlterTime)
            };

            int i = SQLHelper.ExecuteNonQuery(update_command, CommandType.Text, p);
            return i > 0;
        }

        /// <summary>
        /// 根据用户ID和类型ID查询用户爱好
        /// </summary>
        /// <param name="u_ID">用户ID</param>
        /// <param name="t_ID">用户爱好类型ID</param>
        /// <returns>用户爱好信息实体类</returns>
        public static LbsModel.UserHobby SelectByUT(string u_ID,int t_ID)
        {
            LbsModel.UserHobby uh = new LbsModel.UserHobby();
            string selectAdInfo_command = "select * from userhobby ";
            selectAdInfo_command += "where u_id=@u_id and t_id=@t_id";
            SqlParameter[] p = new SqlParameter[] 
            {
               new SqlParameter("@u_id",u_ID),
               new SqlParameter("@t_id",t_ID)
            };

            SqlDataReader sdr = SQLHelper.ExecuteDataReader(selectAdInfo_command, CommandType.Text, p);

            //将数据库中的此用户信息放入实体类
            while (sdr.Read())
            {
                uh.U_ID = sdr["u_id"].ToString();
                uh.T_ID =(int) sdr["t_id"];
                uh.Uh_CreateTime = sdr["uh_createtime"];
                uh.Uh_AlterTime = sdr["uh_altertime"];
            }
            return uh;
        }
    }
}
