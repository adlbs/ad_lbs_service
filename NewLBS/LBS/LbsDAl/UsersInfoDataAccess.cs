
using LbsDAl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
namespace LbsDAl
{

    /// <summary>
    /// 用户基本信息表的数据访问类
    /// </summary>
    public static class UsersInfoDataAccess
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns>true or false</returns>
        public static bool AddUser(LbsModel.UsersInfo user)
        {

            string insert_command = "insert into usersinfo (u_id,u_nickname,u_password,u_email,u_gender,u_birthday,u_phone,u_address,u_registertime,u_icon,u_createtime,u_altertime)";
            insert_command += " values(@u_id,@u_nickname,@u_password,@u_email,@u_gender,@u_birthday,@u_phone,@u_address,@u_registertime,@u_icon,@u_createtime,@u_altertime)";

            SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@u_id",user.U_ID),
             new SqlParameter("@u_nickname",user.U_Nickname),
             new SqlParameter("@u_password",user.U_Password),
             new SqlParameter("@u_email",user.U_Email),
             new SqlParameter("@u_gender",user.U_Gender),
             new SqlParameter("@u_birthday",user.U_Birthday),
             new SqlParameter("@u_phone",user.U_Phone),
             new SqlParameter("@u_address",user.U_Address),
             new SqlParameter("@u_registertime",user.U_RegisterTime),
             new SqlParameter("@u_icon",user.U_Icon),
             new SqlParameter("@u_createtime",user.U_CreateTime),
             new SqlParameter("@u_altertime",user.U_AlterTime)
            };

            int i = SQLHelper.ExecuteNonQuery(insert_command, CommandType.Text, p);
            return i > 0;

        }

        /// <summary>
        /// 修改用户基本资料
        /// </summary>
        /// <param name="user">不为空的user实体类</param>
        /// <returns>true or false</returns>
        public static bool EditUserInfo(LbsModel.UsersInfo user)
        {
            string update_command = "update  usersinfo set u_nickname=@u_nickname,u_password=@u_password,u_email=@u_email,u_gender=@u_gender,u_birthday=@u_birthday,u_address=@u_address,u_registertime=@u_registertime,u_icon=@u_icon,u_createtime=@u_createtime,u_altertime=@u_altertime";
            update_command += " where u_id=@u_id";

            SqlParameter[] p = new SqlParameter[] 
            {
             new SqlParameter("@u_id",user.U_ID),
             new SqlParameter("@u_nickname",user.U_Nickname),  
             new SqlParameter("@u_password",user.U_Password),
             new SqlParameter("@u_email",user.U_Email),
             new SqlParameter("@u_gender",user.U_Gender),
             new SqlParameter("@u_birthday",user.U_Birthday),        
             new SqlParameter("@u_address",user.U_Address),
             new SqlParameter("@u_registertime",user.U_RegisterTime),
             new SqlParameter("@u_icon",user.U_Icon),
             new SqlParameter("@u_createtime",user.U_CreateTime),
             new SqlParameter("@u_altertime",user.U_AlterTime)
            };

            int i = SQLHelper.ExecuteNonQuery(update_command, CommandType.Text, p);
            return i > 0;
        }

        /// <summary>
        /// 查询用户基本信息
        /// </summary>
        /// <param name="keyword">查询信息</param>
        /// <param name="keyType">查询类型</param>
        /// <returns>返回用户基本信息实体类</returns>
        public static LbsModel.UsersInfo SelectByKeyWord(string keyword, UserSelectKeyWordType keyType)
        {
            LbsModel.UsersInfo user = new LbsModel.UsersInfo();

            string selectUser_command = "select * from usersinfo ";
            //进行查询类型选择
            switch (keyType)
            {
                case UserSelectKeyWordType.ID:
                    {
                        selectUser_command += "where u_id=@keyword";
                    }; break;
                case UserSelectKeyWordType.Email:
                    {
                        selectUser_command += "where u_email=@keyword";
                    }; break;
                case UserSelectKeyWordType.PhoneNumber:
                    {
                        selectUser_command += "where u_phone=@keyword";
                    }; break;
            }
            SqlParameter[] p = new SqlParameter[] 
            {
                 new SqlParameter("@keyword",keyword)
            };
            SqlDataReader sdr = SQLHelper.ExecuteDataReader(selectUser_command, CommandType.Text, p);

            //将数据库中的此用户信息放入实体类User
            while (sdr.Read())
            {
                user.U_ID = sdr["u_id"].ToString();
                user.U_Nickname = sdr["u_nickname"].ToString();
                user.U_Password = sdr["u_password"].ToString();
                user.U_Email = sdr["u_email"].ToString();
                user.U_Phone = sdr["u_phone"].ToString();
                user.U_Gender = sdr["u_gender"].ToString();
                user.U_Birthday = sdr["u_birthday"];
                user.U_Address = sdr["u_address"].ToString();
                user.U_RegisterTime = sdr["u_registertime"];
                user.U_Icon = sdr["u_icon"].ToString();
                user.U_CreateTime = sdr["u_createtime"];
                user.U_AlterTime = sdr["u_altertime"];
            }
            return user;
        }

        /// <summary>
        /// 查询用户是否存在
        /// </summary>
        /// <param name="keyword">查询信息</param>
        /// <param name="keyType">查询类型</param>
        /// <returns>true or false</returns>
        public static bool IsUserExist(string keyword, UserSelectKeyWordType keyType)
        {
            string selectUser_command = String.Empty;
            //进行查询类型选择
            switch (keyType)
            {
                case UserSelectKeyWordType.ID:
                    {
                        selectUser_command = "select count(u_id) from usersinfo";
                        selectUser_command += " where u_id=@keyword";
                    }; break;
                case UserSelectKeyWordType.Email:
                    {
                        selectUser_command = "select count(u_email) from usersinfo";
                        selectUser_command += " where u_email=@keyword";
                    }; break;
                case UserSelectKeyWordType.PhoneNumber:
                    {
                        selectUser_command = "select count(u_phone) from usersinfo";
                        selectUser_command += " where u_phone=@keyword";
                    }; break;
            }
            SqlParameter[] p = new SqlParameter[] 
            {
                 new SqlParameter("@keyword",keyword)
            };

            int i = (int)SQLHelper.ExecuteScalar(selectUser_command, CommandType.Text, p);

            return i > 0;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userName">用户名/电子邮箱/电话号码</param>
        /// <param name="password">密码</param>
        /// <param name="keyType">登录名的类型选择</param>
        /// <returns>true or false</returns>
        public static bool IsUserLogin(string userName, string password, UserSelectKeyWordType keyType)
        {
            string selectUser_command = String.Empty;
            //进行查询类型选择
            switch (keyType)
            {
                case UserSelectKeyWordType.NickName:
                    {
                        selectUser_command = "select count(*) from usersinfo";
                        selectUser_command += " where u_nickname=@userName and u_password=@password";
                    }; break;
                case UserSelectKeyWordType.Email:
                    {
                        selectUser_command = "select count(*) from usersinfo";
                        selectUser_command += " where u_email=@userName and u_password=@password";
                    }; break;
                case UserSelectKeyWordType.PhoneNumber:
                    {
                        selectUser_command = "select count(*) from usersinfo";
                        selectUser_command += " where u_phone=@userName and u_password=@password";
                    }; break;

            }
            SqlParameter[] p = new SqlParameter[] 
            {
                 new SqlParameter("@userName",userName),
                 new SqlParameter("@password",password)
            };

            int i = (int)SQLHelper.ExecuteScalar(selectUser_command,CommandType.Text,p);

            return i > 0;

        }
    }
}
