using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace LbsModel

{
    /// <summary>
    /// 广告操作表的实体类
    /// </summary>
  public  class ADOpearte
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

        private object ado_ReleaseTime;
      /// <summary>
      /// 广告投放时间
      /// </summary>
        public object Ado_ReleaseTime
        {
            get { return ado_ReleaseTime; }
            set { ado_ReleaseTime = value; }
        }

        private object ado_ExpiredTime;
      /// <summary>
      /// 广告过期时间
      /// </summary>
        public object Ado_ExpiredTime
        {
            get { return ado_ExpiredTime; }
            set { ado_ExpiredTime = value; }
        }

        private string ado_Address;
      /// <summary>
      /// 广告投放地址 
      /// </summary>
        public string Ado_Address
        {
            get { return ado_Address; }
            set { ado_Address = value; }
        }

        private int ado_ClickCount;
      /// <summary>
      /// 广告被点击次数
      /// </summary>
        public int Ado_ClickCount
        {
            get { return ado_ClickCount; }
            set { ado_ClickCount = value; }
        }

        private object ado_CreateTime;
      /// <summary>
      /// 此记录创建时间
      /// </summary>
        public object Ado_CreateTime
        {
            get { return ado_CreateTime; }
            set { ado_CreateTime = value; }
        }

        private object ado_AlterTime;
      /// <summary>
      /// 此记录修改时间
      /// </summary>
        public object Ado_AlterTime
        {
            get { return ado_AlterTime; }
            set { ado_AlterTime = value; }
        }
    }

}
