using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LbsModel
{
    /// <summary>
    /// �û�������Ϣ���ʵ����
    /// </summary>
    public class UsersInfo
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

        private string u_Nickname;
        /// <summary>
        /// �û��ǳ�
        /// </summary>
        public string U_Nickname
        {
            get { return u_Nickname; }
            set { u_Nickname = value; }
        }

        private string u_Password;
        /// <summary>
        /// �û�����
        /// </summary>
        public string U_Password
        {
            get { return u_Password; }
            set { u_Password = value; }
        }

        private string u_Email;
        /// <summary>
        /// �û�Email
        /// </summary>
        public string U_Email
        {
            get { return u_Email; }
            set { u_Email = value; }
        }

        private string u_Gender;
        /// <summary>
        /// �û��Ա�
        /// </summary>
        public string U_Gender
        {
            get { return u_Gender; }
            set { u_Gender = value; }
        }

        private object u_Birthday;
        /// <summary>
        /// �û�����
        /// </summary>
        /// setΪobject����
        public object U_Birthday
        {
            get { return u_Birthday; }
            set { u_Birthday = value; }
        }

        private string u_Phone;
        /// <summary>
        /// �û��绰����
        /// </summary>
        public string U_Phone
        {
            get { return u_Phone; }
            set { u_Phone = value; }
        }

        private string u_Address;
        /// <summary>
        /// �û���ַ
        /// </summary>
        public string U_Address
        {
            get { return u_Address; }
            set { u_Address = value; }
        }

        private object u_RegisterTime;
        /// <summary>
        /// �û�ע��ʱ��
        /// </summary>
        /// set����Ϊobject����
        public object U_RegisterTime
        {
            get { return u_RegisterTime; }
            set { u_RegisterTime = value; }
        }

        private string u_Icon;
        /// <summary>
        /// �û�ͷ��
        /// </summary>
        public string U_Icon
        {
            get { return u_Icon; }
            set { u_Icon = value; }
        }

        private object u_CreateTime;
        /// <summary>
        /// �˼�¼����ʱ��
        /// </summary>
        ///  setΪobject����
        public object U_CreateTime
        {
            get { return u_CreateTime; }
            set { u_CreateTime = value; }
        }

        private object u_AlterTime;
        /// <summary>
        /// �˼�¼�޸�ʱ��
        /// </summary>
        /// setΪobject����
        public object U_AlterTime
        {
            get { return u_AlterTime; }
            set { u_AlterTime = value; }
        }
    }
}