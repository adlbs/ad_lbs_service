using System;
using System.Collections.Generic;
using System.Text;


namespace LbsModel 

{
    /// <summary>
    /// �û�������¼���ʵ����
    /// </summary>
	public class UserOperate
	{
		private string u_ID;
        /// <summary>
        /// �û�ID
        /// </summary>
		public string U_ID
		{
			get { return u_ID; }
			set { u_ID = value; }
		}
	
		private int uo_OnlineStatus;
        /// <summary>
        /// �û�����״̬
        /// </summary>
		public int Uo_OnlineStatus
		{
			get { return uo_OnlineStatus; }
			set { uo_OnlineStatus = value; }
		}
	
		private object uo_OnlineTime;
        /// <summary>
        /// �û�����ʱ��
        /// </summary>
		public object Uo_OnlineTime
		{
			get { return uo_OnlineTime; }
			set { uo_OnlineTime = value; }
		}
	
		private object uo_OfflineTime;
        /// <summary>
        /// �û�����ʱ��
        /// </summary>
		public object Uo_OfflineTime
		{
			get { return uo_OfflineTime; }
			set { uo_OfflineTime = value; }
		}
	
		private string uo_IpAdress;
        /// <summary>
        /// �û�IP��ַ
        /// </summary>
		public string Uo_IpAdress
		{
			get { return uo_IpAdress; }
			set { uo_IpAdress = value; }
		}
	
		private object uo_CreateTime;
        /// <summary>
        /// �˼�¼����ʱ��
        /// </summary>
		public object Uo_CreateTime
		{
			get { return uo_CreateTime; }
			set { uo_CreateTime = value; }
		}
	
		private object uo_AlterTime;
        /// <summary>
        /// �˼�¼�޸�ʱ��
        /// </summary>
		public object Uo_AlterTime
		{
			get { return uo_AlterTime; }
			set { uo_AlterTime = value; }
		}
	}
}