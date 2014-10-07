using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
<<<<<<< HEAD
namespace LBS
=======
using System.Threading.Tasks;

namespace LbsDAl
>>>>>>> origin/master
{
    /// <summary>
    /// 用户基本信息表的数据访问类
    /// </summary>
    public static class UsersInfoDataAccess
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true or false</returns>
<<<<<<< HEAD
        public static bool AddUser(UsersInfo user)
=======
        public static bool AddUser(LbsModel.UsersInfo user)
>>>>>>> origin/master
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
<<<<<<< HEAD
        public static bool EditUserInfo(UsersInfo user)
=======
        public static bool EditUserInfo(LbsModel.UsersInfo user)
>>>>>>> origin/master
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
        /// 根据用户ID查询此用户信息
        /// </summary>
        /// <param name="u_ID">用户ID</param>
        /// <returns>返回此用户的实体类对象user</returns>
<<<<<<< HEAD
        public static UsersInfo SelectByUserID(string u_ID)
        {
            UsersInfo user = new UsersInfo();
=======
        public static LbsModel.UsersInfo SelectByUserID(string u_ID)
        {
            LbsModel.UsersInfo user = new LbsModel.UsersInfo();
>>>>>>> origin/master
            string selectUser_command = "select * from usersinfo ";
            selectUser_command += "where u_id=@u_id";
            SqlParameter[] p = new SqlParameter[] 
            {
               new SqlParameter("@u_id",u_ID)
            };
            
            SqlDataReader sdr = SQLHelper.ExecuteDataReader(selectUser_command,CommandType.Text,p);
          
            //将数据库中的此用户信息放入实体类User
            while (sdr.Read())
            {
                user.U_ID = sdr["u_id"].ToString();
                user.U_Nickname = sdr["u_nickname"].ToString();
                user.U_Password = sdr["u_password"].ToString();
                user.U_Email = sdr["u_email"].ToString();
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

    }
}
