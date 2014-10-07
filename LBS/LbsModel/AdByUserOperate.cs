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
    /// 用户对广告进行的操作记录表的实体类
    /// </summary>
  public  class AdByUserOperate
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

        private string u_ID;
      /// <summary>
      /// 用户ID
      /// </summary>
        public string U_ID
        {
            get { return u_ID; }
            set { u_ID = value; }
        }

        private DateTime auo_CreateTime;
      /// <summary>
      /// 此记录创建时间
      /// </summary>
        public DateTime Auo_CreateTime
        {
            get { return auo_CreateTime; }
            set { auo_CreateTime = value; }
        }

        private DateTime auo_AlterTime;
      /// <summary>
      /// 此记录修改时间
      /// </summary>
        public DateTime Auo_AlterTime
        {
            get { return auo_AlterTime; }
            set { auo_AlterTime = value; }
        }

    }
}
