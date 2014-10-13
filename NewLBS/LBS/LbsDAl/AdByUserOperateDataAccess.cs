using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace LbsDAl
{
    /// <summary>
    /// 用户对广告进行操作的记录表的数据访问类
    /// </summary>
 public static  class AdByUserOperateDataAccess
    {
     /// <summary>
     /// 添加记录
     /// </summary>
     /// <param name="auo">记录实体</param>
     /// <returns>true or  false</returns>
     public static bool AddAuo(LbsModel.AdByUserOperate auo)
     {

         string insert_command = "insert into AdByUserOperate (ad_id,u_id,auo_createtime,auo_altertime) ";
         insert_command += " values (@ad_id,@u_id,@auo_createtime,@auo_altertime)";

         SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@ad_id",auo.Ad_ID),
             new SqlParameter("@u_id",auo.U_ID),
             new SqlParameter("@auo_createtime",auo.Auo_CreateTime),
             new SqlParameter("@auo_altertime",auo.Auo_CreateTime)
            };

         int i = SQLHelper.ExecuteNonQuery(insert_command, CommandType.Text, p);
         return i > 0;

     }

     /// <summary>
     /// 根据用户ID查询用户操作记录
     /// </summary>
     /// <param name="u_ID">用户ID</param>
     /// <returns>用户实体类</returns>
     public static LbsModel.AdByUserOperate SelectByUserId(string u_ID)
     {
         LbsModel.AdByUserOperate auo = new LbsModel.AdByUserOperate();
         string selectAdByUserOperate_command = "select * from .AdByUserOperate ";
         selectAdByUserOperate_command += "where u_id=@u_id";
         SqlParameter[] p = new SqlParameter[] 
            {
               new SqlParameter("@u_id",u_ID),
              
            };

         SqlDataReader sdr = SQLHelper.ExecuteDataReader(selectAdByUserOperate_command, CommandType.Text, p);

         //将数据库中的此用户信息放入实体类
         while (sdr.Read())
         {
             auo.U_ID = sdr["u_id"].ToString();
             auo.Ad_ID = sdr["ad_id"].ToString();
             auo.Auo_CreateTime = sdr["auo_createtime"];
             auo.Auo_AlterTime = sdr["auo_altertime"];
         }
         return auo;
     }
    

}
}