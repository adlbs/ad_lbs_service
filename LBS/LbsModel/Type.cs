using System;
using System.Collections.Generic;
using System.Text;

namespace LbsModel 
{
    /// <summary>
    /// ������ͻ����û����ñ��ʵ����
    /// </summary>
	public class Type
	{
		private int t_ID;
        /// <summary>
        /// ����ID
        /// </summary>
		public int T_ID
		{
			get { return t_ID; }
			set { t_ID = value; }
		}
	
		private string t_Name;
        /// <summary>
        /// ��������
        /// </summary>
		public string T_Name
		{
			get { return t_Name; }
			set { t_Name = value; }
		}
	}
}