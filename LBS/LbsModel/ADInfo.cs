using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LbsModel
{
    /// <summary>
    /// 广告基本信息表的实体类
    /// </summary>
    public class ADInfo
    {
        private string ad_ID;
        /// <summary>
        /// 广告ID
        /// </summary>
        public string Ad_ID
        {
            get { return ad_ID; }
            set { ad_ID = value; }
        }

        private int t_ID;
        /// <summary>
        /// 广告类型ID
        /// </summary>
        public int T_ID
        {
            get { return t_ID; }
            set { t_ID = value; }
        }

        private string ads_ID;
        /// <summary>
        /// 商家ID
        /// </summary>
        public string Ads_ID
        {
            get { return ads_ID; }
            set { ads_ID = value; }
        }

        private string ad_Title;
        /// <summary>
        /// 广告标题
        /// </summary>
        public string Ad_Title
        {
            get { return ad_Title; }
            set { ad_Title = value; }
        }

        private string ad_Content;
        /// <summary>
        /// 广告内容
        /// </summary>
        public string Ad_Content
        {
            get { return ad_Content; }
            set { ad_Content = value; }
        }

        private int ad_ContentType;
        /// <summary>
        /// 广告内容类型
        /// </summary>
        public int Ad_ContentType
        {
            get { return ad_ContentType; }
            set { ad_ContentType = value; }
        }

        private DateTime ad_CreateTime;
        /// <summary>
        /// 此记录创建时间
        /// </summary>
        public DateTime Ad_CreateTime
        {
            get { return ad_CreateTime; }
            set { ad_CreateTime = value; }
        }

        private DateTime ad_AlterTime;
        /// <summary>
        /// 此记录修改时间
        /// </summary>
        public DateTime Ad_AlterTime
        {
            get { return ad_AlterTime; }
            set { ad_AlterTime = value; }
        }

    }
}
