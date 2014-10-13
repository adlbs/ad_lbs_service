using System;
using System.Collections.Generic;
using System.Text;


namespace LbsModel 

{
    /// <summary>
    /// 用户操作记录表的实体类
    /// </summary>
	public class UserOperate
	{
		private string u_ID;
        /// <summary>
        /// 用户ID
        /// </summary>
		public string U_ID
		{
			get { return u_ID; }
			set { u_ID = value; }
		}
	
		private int uo_OnlineStatus;
        /// <summary>
        /// 用户在线状态
        /// </summary>
		public int Uo_OnlineStatus
		{
			get { return uo_OnlineStatus; }
			set { uo_OnlineStatus = value; }
		}
	
		private object uo_OnlineTime;
        /// <summary>
        /// 用户上线时间
        /// </summary>
		public object Uo_OnlineTime
		{
			get { return uo_OnlineTime; }
			set { uo_OnlineTime = value; }
		}
	
		private object uo_OfflineTime;
        /// <summary>
        /// 用户离线时间
        /// </summary>
		public object Uo_OfflineTime
		{
			get { return uo_OfflineTime; }
			set { uo_OfflineTime = value; }
		}
	
		private string uo_IpAdress;
        /// <summary>
        /// 用户IP地址
        /// </summary>
		public string Uo_IpAdress
		{
			get { return uo_IpAdress; }
			set { uo_IpAdress = value; }
		}
	
		private object uo_CreateTime;
        /// <summary>
        /// 此记录创建时间
        /// </summary>
		public object Uo_CreateTime
		{
			get { return uo_CreateTime; }
			set { uo_CreateTime = value; }
		}
	
		private object uo_AlterTime;
        /// <summary>
        /// 此记录修改时间
        /// </summary>
		public object Uo_AlterTime
		{
			get { return uo_AlterTime; }
			set { uo_AlterTime = value; }
		}
	}
}