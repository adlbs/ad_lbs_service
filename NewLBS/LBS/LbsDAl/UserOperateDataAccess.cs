using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace LbsDAl
{
    /// <summary>
    /// 用户操作记录
    /// </summary>
   public static class UserOperateDataAccess
    {
       /// <summary>
       /// 添加用户操作记录
       /// </summary>
       /// <param name="uo">用户操作记录实体</param>
       /// <returns>true or false</returns>
       public static bool AddUserOperate(LbsModel.UserOperate uo) 
       {
           string insert_command = "insert into UserOperate (u_id,uo_onlinestatus,uo_onlinetime,uo_offlinetime,uo_ipadress,uo_createtime,uo_altertime) ";
           insert_command += " values (@u_id,@uo_onlinestatus,@uo_onlinetime,@uo_offlinetime,@uo_ipadress,@uo_createtime,@uo_altertime)";

           SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@u_id",uo.U_ID),
             new SqlParameter("@uo_onlinestatus",uo.Uo_OnlineStatus),
             new SqlParameter("@uo_onlinetime",uo.Uo_OnlineTime),
             new SqlParameter("@uo_offlinetime",uo.Uo_OfflineTime),
             new SqlParameter("@uo_ipadress",uo.Uo_IpAdress),
             new SqlParameter("@uo_createtime",uo.Uo_CreateTime),
             new SqlParameter("@uo_altertime",uo.Uo_AlterTime)
            };

           int i = SQLHelper.ExecuteNonQuery(insert_command, CommandType.Text, p);
           return i > 0;
       
       }


       /// <summary>
       /// 根据用户ID查询用户操作记录
       /// </summary>
       /// <param name="u_id">用户ID</param>
       /// <returns>用户操作实体类</returns>
       public static LbsModel.UserOperate SelectByUID(string u_id)
       {


           LbsModel.UserOperate uo = new LbsModel.UserOperate();
           string selectUserOperate_command = "select * from UserOperate ";
           selectUserOperate_command += "where u_id=@u_id";
           SqlParameter[] p = new SqlParameter[] 
            {
               new SqlParameter("@u_id",u_id),
              
            };

           SqlDataReader sdr = SQLHelper.ExecuteDataReader(selectUserOperate_command, CommandType.Text, p);

           //将数据库中的此用户信息放入实体类
           while (sdr.Read())
           {
               uo.U_ID = sdr["u_id"].ToString();
               uo.Uo_OnlineStatus=(int )sdr["uo_onlinestatus"];
                   uo.Uo_OnlineTime=sdr["uo_onlinetime"];
                   uo.Uo_OfflineTime=sdr["uo_offlinetime"];
                   uo.Uo_IpAdress=sdr["uo_ipadress"].ToString();
                   uo.Uo_CreateTime=sdr["uo_createtime"];
                   uo.Uo_AlterTime=sdr["uo_altertime"];

             
           }
           return uo;
       
       
       }

    }
}
