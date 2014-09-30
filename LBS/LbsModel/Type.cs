using System;
using System.Collections.Generic;
using System.Text;

namespace LbsModel 
{
    /// <summary>
    /// 广告类型或者用户爱好表的实体类
    /// </summary>
	public class Type
	{
		private int t_ID;
        /// <summary>
        /// 类型ID
        /// </summary>
		public int T_ID
		{
			get { return t_ID; }
			set { t_ID = value; }
		}
	
		private string t_Name;
        /// <summary>
        /// 类型名称
        /// </summary>
		public string T_Name
		{
			get { return t_Name; }
			set { t_Name = value; }
		}
	}
}