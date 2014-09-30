using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LbsModel
{
    /// <summary>
    /// 用户基本信息表的实体类
    /// </summary>
    public class UsersInfo
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

        private string u_Nickname;
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string U_Nickname
        {
            get { return u_Nickname; }
            set { u_Nickname = value; }
        }

        private string u_Password;
        /// <summary>
        /// 用户密码
        /// </summary>
        public string U_Password
        {
            get { return u_Password; }
            set { u_Password = value; }
        }

        private string u_Email;
        /// <summary>
        /// 用户Email
        /// </summary>
        public string U_Email
        {
            get { return u_Email; }
            set { u_Email = value; }
        }

        private string u_Gender;
        /// <summary>
        /// 用户性别
        /// </summary>
        public string U_Gender
        {
            get { return u_Gender; }
            set { u_Gender = value; }
        }

        private object u_Birthday;
        /// <summary>
        /// 用户生日
        /// </summary>
        /// set为object类型
        public object U_Birthday
        {
            get { return u_Birthday; }
            set { u_Birthday = value; }
        }

        private string u_Phone;
        /// <summary>
        /// 用户电话号码
        /// </summary>
        public string U_Phone
        {
            get { return u_Phone; }
            set { u_Phone = value; }
        }

        private string u_Address;
        /// <summary>
        /// 用户地址
        /// </summary>
        public string U_Address
        {
            get { return u_Address; }
            set { u_Address = value; }
        }

        private object u_RegisterTime;
        /// <summary>
        /// 用户注册时间
        /// </summary>
        /// set对象为object类型
        public object U_RegisterTime
        {
            get { return u_RegisterTime; }
            set { u_RegisterTime = value; }
        }

        private string u_Icon;
        /// <summary>
        /// 用户头像
        /// </summary>
        public string U_Icon
        {
            get { return u_Icon; }
            set { u_Icon = value; }
        }

        private object u_CreateTime;
        /// <summary>
        /// 此记录创建时间
        /// </summary>
        ///  set为object类型
        public object U_CreateTime
        {
            get { return u_CreateTime; }
            set { u_CreateTime = value; }
        }

        private object u_AlterTime;
        /// <summary>
        /// 此记录修改时间
        /// </summary>
        /// set为object类型
        public object U_AlterTime
        {
            get { return u_AlterTime; }
            set { u_AlterTime = value; }
        }
    }
}