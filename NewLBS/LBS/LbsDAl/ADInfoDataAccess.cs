using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace LbsDAl
{
    /// <summary>
    /// 广告信息数据访问类
    /// </summary>
    public static class ADInfoDataAccess
    {
        /// <summary>
        /// 添加广告信息
        /// </summary>
        /// <param name="ad">广告实体类</param>
        /// <returns>true or false</returns>
        public static bool AddAdInfo(LbsModel.ADInfo ad)
        {

            string insert_command = " insert into adinfo(ad_id,t_id,ads_id,ad_title,ad_content,ad_contenttype,ad_createtime,ad_altertime)";
            insert_command += " values (@ad_id,@t_id,@ads_id,@ad_title,@ad_content,@ad_contenttype,@ad_createtime,@ad_altertime)";

            SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@ad_id",ad.Ad_ID),
             new SqlParameter("@t_id",ad.T_ID),
             new SqlParameter("@ads_id",ad.Ads_ID),
             new SqlParameter("@ad_title",ad.Ad_Title),
             new SqlParameter("@ad_content",ad.Ad_Content),
             new SqlParameter("@ad_contenttype",ad.Ad_ContentType),
             new SqlParameter("@ad_createtime",ad.Ad_CreateTime),
             new SqlParameter("@ad_altertime",ad.Ad_AlterTime)
            };

            int i = SQLHelper.ExecuteNonQuery(insert_command, CommandType.Text, p);
            return i > 0;

        }
        /// <summary>
        /// 修改广告信息
        /// </summary>
        /// <param name="ad">不为空的广告实体类</param>
        /// <returns>true or false</returns>
        public static bool EditAdInfo(LbsModel.ADInfo ad)
        {
            string update_command = "update adinfo set t_id=@t_id,ads_id=@ads_id,ad_title=@ad_title,ad_content=@ad_content,ad_contenttype=@ad_contenttype,ad_createtime=@ad_createtime,ad_altertime=@ad_altertime";
            update_command += " where ad_id=@ad_id";

            SqlParameter[] p = new SqlParameter[] 
            {
                new SqlParameter("@ad_id",ad.Ad_ID),
             new SqlParameter("@t_id",ad.T_ID),
             new SqlParameter("@ads_id",ad.Ads_ID),
             new SqlParameter("@ad_title",ad.Ad_Title),
             new SqlParameter("@ad_content",ad.Ad_Content),
             new SqlParameter("@ad_contenttype",ad.Ad_ContentType),
             new SqlParameter("@ad_createtime",ad.Ad_CreateTime),
             new SqlParameter("@ad_altertime",ad.Ad_AlterTime) 
            };

            int i = SQLHelper.ExecuteNonQuery(update_command, CommandType.Text, p);
            return i > 0;
        }

        /// <summary>
        ///根据广告ID获取广告
        /// </summary>
        /// <param name="Ad_ID">广告ID</param>
        /// <returns>广告实体类</returns>
        public static LbsModel.ADInfo SelectByAdID(string Ad_ID)
        {
            LbsModel.ADInfo ad = new LbsModel.ADInfo();
            string selectAdInfo_command = "select * from adinfo ";
            selectAdInfo_command += "where ad_id=@ad_id";
            SqlParameter[] p = new SqlParameter[] 
            {
               new SqlParameter("@ad_id",Ad_ID)
            };

            SqlDataReader sdr = SQLHelper.ExecuteDataReader(selectAdInfo_command, CommandType.Text, p);

            //将数据库中的此用户信息放入实体类
            while (sdr.Read())
            {
                ad.Ad_ID = sdr["ad_id"].ToString();
                ad.T_ID =(int) sdr["t_id"];
                ad.Ads_ID = sdr["ads_id"].ToString();
                ad.Ad_Title = sdr["ad_title"].ToString();
                ad.Ad_Content = sdr["ad_content"].ToString();
                ad.Ad_ContentType = (int)sdr["ad_contenttype"];
                ad.Ad_CreateTime = sdr["ad_createtime"];
                ad.Ad_AlterTime = sdr["ad_altertime"];
            }
            return ad;
        }

    }
}
