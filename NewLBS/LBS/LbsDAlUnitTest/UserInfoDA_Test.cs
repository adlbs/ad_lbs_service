using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using System.Data.SqlClient;
namespace LBS
{
    [TestFixture]
    public class UserInfoDA_Test
    {
        [Test]
        public void TestAddUser()
        {
            bool flag=true;
            UsersInfo user = new UsersInfo();
            user.U_ID = "2013";
            Assert.AreEqual(flag,UsersInfoDataAccess.AddUser(user),"测试数据库中是否能添加进去用户");
            //flag = LbsDAl.UsersInfoDataAccess.AddUser(user);
            Console.WriteLine(flag);
            Console.Read();
        }
        [Test]
        public void TestEditUser()
        {
            UsersInfo user = new UsersInfo();
            user = UsersInfoDataAccess.SelectByUserID("2013");
            bool flag = true;
            user.U_Nickname = "zx";
            flag = UsersInfoDataAccess.EditUserInfo(user);
            Console.WriteLine(flag);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            UserInfoDA_Test ut = new UserInfoDA_Test();
            ut.TestEditUser();
            Console.Read();
        }
    }
}
