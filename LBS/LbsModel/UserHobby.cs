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
    /// �û����ñ�
    /// </summary>
	public class UserHobby
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
	
		private int t_ID;
        /// <summary>
        /// �û�����ID
        /// </summary>
		public int T_ID
		{
			get { return t_ID; }
			set { t_ID = value; }
		}
	
		private DateTime uh_CreateTime;
        /// <summary>
        /// �˼�¼����ʱ��
        /// </summary>
		public DateTime Uh_CreateTime
		{
			get { return uh_CreateTime; }
			set { uh_CreateTime = value; }
		}
	
		private DateTime uh_AlterTime;
        /// <summary>
        /// �˼�¼�޸�ʱ��
        /// </summary>
		public DateTime Uh_AlterTime
		{
			get { return uh_AlterTime; }
			set { uh_AlterTime = value; }
		}
	}
}