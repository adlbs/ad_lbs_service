using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;
using LbsModel;
using LbsDAl;



namespace LbsDAlUnitTest

{
    [TestFixture]
    public class UserInfoDA_Test
    {
        [Test]
        public void TestAddUser()
        {

            bool flag = true;
            LbsModel.UsersInfo user = new LbsModel.UsersInfo();
            user.U_ID = "2013zx";
            user.U_Nickname = "zx";
            user.U_Password = "123";
            user.U_Phone = "12345";
            user.U_Address = "zx";
            user.U_Birthday = DateTime.Now.ToShortDateString();
            user.U_CreateTime = DateTime.Now.ToShortTimeString();
            user.U_RegisterTime = DateTime.Now.ToShortDateString();
            user.U_Gender = "f";
            user.U_AlterTime = DateTime.Now.ToShortDateString();
          //  Assert.AreEqual(flag, LbsDAl.UsersInfoDataAccess.AddUser(user), "测试数据库中是否能添加进去用户");
            flag = LbsDAl.UsersInfoDataAccess.AddUser(user);
            Console.WriteLine(flag);
            Console.Read();
        }
        [Test]
        public void TestEditUser()
        {

         
            LbsModel.UsersInfo user = new LbsModel.UsersInfo();
            user = LbsDAl.UsersInfoDataAccess.SelectByKeyWord("2013", LbsDAl.UserSelectKeyWordType.ID);
            bool flag = true;
            user.U_Nickname = "bl";
            flag = LbsDAl.UsersInfoDataAccess.EditUserInfo(user);

            //Assert.AreEqual(flag, LbsDAl.UsersInfoDataAccess.EditUserInfo(user), "测试数据库中是否能修改用户");

            Console.WriteLine(flag);
        }
        public void TestXMlRead()
        {
            string constr = "Data Source=PC-20140223IKWV\\SQLEXPRESS;Initial Catalog=LbsDB;Integrated Security=True";
            LbsXmlConfig.XmlConfigReader xrd = new LbsXmlConfig.XmlConfigReader(@"..\..\SqlConnConfig.xml");
            string xmlcon = xrd.Process("appSettings", "SqlConnectionString");
            //Assert.AreEqual(constr, xmlcon, "数据库链接字符串是否读取");
            if (!constr.Equals(xmlcon))
            {
                Console.Write("true     ");
                Console.WriteLine(constr);
                Console.WriteLine(xmlcon);
            }
            else
            {
                Console.Write("false   ");
                Console.WriteLine(xmlcon);
            }
        }

        public void TestUserIsExist()
        {
            Console.WriteLine(LbsDAl.UsersInfoDataAccess.IsUserExist("12345",LbsDAl.UserSelectKeyWordType.PhoneNumber));
        }
        public void TestUserSelect()
        {
            Console.WriteLine(LbsDAl.UsersInfoDataAccess.SelectByKeyWord("2013",LbsDAl.UserSelectKeyWordType.ID));
        }
        public void TestUserIsLogin()
        {
            Console.WriteLine(LbsDAl.UsersInfoDataAccess.IsUserLogin("zx","123",LbsDAl.UserSelectKeyWordType.NickName));
        }
    }
  
}
