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
    /// 用户爱好表
    /// </summary>
	public class UserHobby
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
	
		private int t_ID;
        /// <summary>
        /// 用户爱好ID
        /// </summary>
		public int T_ID
		{
			get { return t_ID; }
			set { t_ID = value; }
		}
	
		private DateTime uh_CreateTime;
        /// <summary>
        /// 此记录创建时间
        /// </summary>
		public DateTime Uh_CreateTime
		{
			get { return uh_CreateTime; }
			set { uh_CreateTime = value; }
		}
	
		private DateTime uh_AlterTime;
        /// <summary>
        /// 此记录修改时间
        /// </summary>
		public DateTime Uh_AlterTime
		{
			get { return uh_AlterTime; }
			set { uh_AlterTime = value; }
		}
	}
}