using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace LbsDAl
{
    /// <summary>
    /// 广告操作记录表
    /// </summary>
  public static  class ADOperateDataAccess
    {
      /// <summary>
      /// 添加广告操作记录
      /// </summary>
      /// <param name="ado">广告操作记录实体类</param>
      /// <returns>true or false</returns>
        public static bool AddADoperate(LbsModel.ADOpearte ado)
        {


            string insert_command = "insert into ADOperate (ad_ID,ado_ReleaseTime,ado_ExpiredTime,ado_Address,ado_ClickCount,ado_CreateTime,ado_AlterTime) ";
            insert_command += " values (@ad_id,@ado_ReleaseTime,@ado_ExpiredTime,@ado_Address,@ado_ClickCount,@ado_CreateTime,@ado_AlterTime)";

            SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@ad_id",ado.Ad_ID),
             new SqlParameter("@ado_ReleaseTime",ado.Ado_ReleaseTime),
             new SqlParameter("@ado_ExpiredTime",ado.Ado_ExpiredTime),
             new SqlParameter("@ado_Address",ado.Ado_Address),
             new SqlParameter("@ado_ClickCount",ado.Ado_ClickCount),
             new SqlParameter("@ado_CreateTime",ado.Ado_CreateTime),
             new SqlParameter("@ado_AlterTime",ado.Ado_AlterTime)
            };

            int i = SQLHelper.ExecuteNonQuery(insert_command, CommandType.Text, p);
            return i > 0;


        }
      /// <summary>
      /// 根据广告id查询广告操作记录
      /// </summary>
      /// <param name="ad_id">广告id</param>
      /// <returns>广告操作记录实体类</returns>
        public static LbsModel.ADOpearte SelectByAdID(string ad_id)
        {
            LbsModel.ADOpearte ado = new LbsModel.ADOpearte();
            string selectADOpearte_command = "select * from ADOperate ";
            selectADOpearte_command += "where ad_id=@ad_id";
            SqlParameter[] p = new SqlParameter[] 
            {
               new SqlParameter("@ad_id",ad_id),
              
            };

            SqlDataReader sdr = SQLHelper.ExecuteDataReader(selectADOpearte_command, CommandType.Text, p);

            //将数据库中的此用户信息放入实体类
            while (sdr.Read())
            {
                ado.Ad_ID = sdr["ad_id"].ToString();
                ado.Ado_ReleaseTime = sdr["ado_releasetime"];
                ado.Ado_ExpiredTime = sdr["ado_expiredtime"];
                ado.Ado_Address = sdr["ado_address"].ToString();
                ado.Ado_ClickCount =(int) sdr["ado_clickcount"];
                ado.Ado_CreateTime = sdr["ado_createtime"];
                ado.Ado_AlterTime = sdr["ado_altertime"];

            }
            return ado;



        }

    }
}