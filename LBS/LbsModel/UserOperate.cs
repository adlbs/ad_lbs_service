using System;
using System.Collections.Generic;
using System.Text;

<<<<<<< HEAD
namespace LBS 
=======
namespace LbsModel 
>>>>>>> origin/master
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
	
		private DateTime uo_OnlineTime;
        /// <summary>
        /// �û�����ʱ��
        /// </summary>
		public DateTime Uo_OnlineTime
		{
			get { return uo_OnlineTime; }
			set { uo_OnlineTime = value; }
		}
	
		private DateTime uo_OfflineTime;
        /// <summary>
        /// �û�����ʱ��
        /// </summary>
		public DateTime Uo_OfflineTime
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
	
		private DateTime uo_CreateTime;
        /// <summary>
        /// �˼�¼����ʱ��
        /// </summary>
		public DateTime Uo_CreateTime
		{
			get { return uo_CreateTime; }
			set { uo_CreateTime = value; }
		}
	
		private DateTime uo_AlterTime;
        /// <summary>
        /// �˼�¼�޸�ʱ��
        /// </summary>
		public DateTime Uo_AlterTime
		{
			get { return uo_AlterTime; }
			set { uo_AlterTime = value; }
		}
	}
}