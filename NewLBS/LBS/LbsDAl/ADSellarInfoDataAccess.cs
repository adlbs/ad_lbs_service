using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace LbsDAl
{
    /// <summary>
    /// 商家基本信息表数据访问类
    /// </summary>
    public class ADSellarInfoDataAccess
    {

      /// <summary>
      /// 添加商家
      /// </summary>
      /// <param name="adSellar">商家实体</param>
      /// <returns>true or false</returns>
        public static bool AddAdSellar(LbsModel.ADSellarInfo adSellar)
        {

            string insert_command = "insert into adsellarinfo (ads_id,u_id,ads_company,ads_createtime,ads_altertime)";
            insert_command += " values(@ads_id,@u_id,@ads_company,@ads_createtime,@ads_altertime)";

            SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@ads_id",adSellar.Ads_ID),
             new SqlParameter("@u_id",adSellar.U_ID),
             new SqlParameter("@ads_company",adSellar.Ads_Company),
             new SqlParameter("@ads_createtime",adSellar.Ads_CreateTime),
             new SqlParameter("@ads_altertime",adSellar.Ads_AlterTime),
            };

            int i = SQLHelper.ExecuteNonQuery(insert_command, CommandType.Text, p);
            return i > 0;

        }

        /// <summary>
        /// 修改商家基本资料
        /// </summary>
        /// <param name="adSellar">不为空的adSellar实体类</param>
        /// <returns>true or false</returns>
        public static bool EditADSellarInfo(LbsModel.ADSellarInfo adSellar)
        {
            string update_command = "update adsellarinfo set u_id=@u_id,ads_company=@ads_company,ads_createtime=@ads_createtime,ads_altertime=@ads_altertime";
            update_command += " where ads_id=@ads_id";

            SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@u_id",adSellar.U_ID),
             new SqlParameter("@ads_company",adSellar.Ads_Company),  
             new SqlParameter("@ads_createtime",adSellar.Ads_CreateTime),
             new SqlParameter("@ads_altertime",adSellar.Ads_AlterTime),
             new SqlParameter("@ads_id",adSellar.Ads_ID)
            };

            int i = SQLHelper.ExecuteNonQuery(update_command, CommandType.Text, p);
            return i > 0;
        }
        /// <summary>
        /// 根据商家ID查询商家资料
        /// </summary>
        /// <param name="ads_ID">商家ID</param>
        /// <returns>商家资料实体类</returns>
        public static LbsModel.ADSellarInfo SelectByAdsID(string ads_ID)
        {
            LbsModel.ADSellarInfo adSellar = new LbsModel.ADSellarInfo();
            string selectAdSellar_command = "select * from adsellarinfo ";
            selectAdSellar_command += "where ads_id=@ads_id";
            SqlParameter[] p = new SqlParameter[] 
            {
               new SqlParameter("@ads_id",ads_ID)
            };

            SqlDataReader sdr = SQLHelper.ExecuteDataReader(selectAdSellar_command, CommandType.Text, p);

            //将数据库中的此用户信息放入实体类adSellar
            while (sdr.Read())
            {
                adSellar.Ads_ID = sdr["ads_id"].ToString();
                adSellar.U_ID = sdr["u_id"].ToString();
                adSellar.Ads_Company = sdr["ads_company"].ToString();
                adSellar.Ads_CreateTime = sdr["ads_createtime"];
                adSellar.Ads_AlterTime = sdr["ads_altertime"];
            }
            return adSellar;
        }

    }
}
