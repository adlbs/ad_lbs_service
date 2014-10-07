using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
namespace LBS
=======
using System.Threading.Tasks;

namespace LbsModel
>>>>>>> origin/master
{
    /// <summary>
    /// 广告商家基本信息表的实体类
    /// </summary>
    public class ADSellarInfo
    {
        private string ads_ID;
        /// <summary>
        /// 商家ID
        /// </summary>
        public string Ads_ID
        {
            get { return ads_ID; }
            set { ads_ID = value; }
        }

        private string u_ID;
        /// <summary>
        /// 用户ID
        /// </summary>
        public string U_ID
        {
            get { return u_ID; }
            set { u_ID = value; }
        }

        private string ads_Company;
        /// <summary>
        /// 商家公司名称
        /// </summary>
        public string Ads_Company
        {
            get { return ads_Company; }
            set { ads_Company = value; }
        }

        private DateTime ads_CreateTime;
        /// <summary>
        /// 此记录创建时间
        /// </summary>
        public DateTime Ads_CreateTime
        {
            get { return ads_CreateTime; }
            set { ads_CreateTime = value; }
        }

        private DateTime ads_AlterTime;
        /// <summary>
        /// 此记录修改时间
        /// </summary>
        public DateTime Ads_AlterTime
        {
            get { return ads_AlterTime; }
            set { ads_AlterTime = value; }
        }
    }
}
