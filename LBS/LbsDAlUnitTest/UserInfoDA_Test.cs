using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD

using NUnit.Framework;
using System.Data.SqlClient;
namespace LBS
=======
using System.Threading.Tasks;
using NUnit.Framework;
using System.Data.SqlClient;
namespace LbsDAlUnitTest
>>>>>>> origin/master
{
    [TestFixture]
    public class UserInfoDA_Test
    {
        [Test]
        public void TestAddUser()
        {
            bool flag=true;
<<<<<<< HEAD
            UsersInfo user = new UsersInfo();
            user.U_ID = "2013";
            Assert.AreEqual(flag,UsersInfoDataAccess.AddUser(user),"测试数据库中是否能添加进去用户");
=======
            LbsModel.UsersInfo user = new LbsModel.UsersInfo();
            user.U_ID = "2013";
            Assert.AreEqual(flag,LbsDAl.UsersInfoDataAccess.AddUser(user),"测试数据库中是否能添加进去用户");
>>>>>>> origin/master
            //flag = LbsDAl.UsersInfoDataAccess.AddUser(user);
            Console.WriteLine(flag);
            Console.Read();
        }
        [Test]
        public void TestEditUser()
        {
<<<<<<< HEAD
            UsersInfo user = new UsersInfo();
            user = UsersInfoDataAccess.SelectByUserID("2013");
            bool flag = true;
            user.U_Nickname = "zx";
            flag = UsersInfoDataAccess.EditUserInfo(user);
=======
            LbsModel.UsersInfo user = new LbsModel.UsersInfo();
            user = LbsDAl.UsersInfoDataAccess.SelectByUserID("2013");
            bool flag = true;
            user.U_Nickname = "zx";
            flag = LbsDAl.UsersInfoDataAccess.EditUserInfo(user);
>>>>>>> origin/master
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
