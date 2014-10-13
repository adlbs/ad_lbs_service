using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using LbsDAl;


namespace LbsDAlUnitTest

{
    public class SQlHelperTest
    {

        [Test]
        public void TestSQlHelpConnectionString()
        {
            string constr = @"Data Source=PC-20140223IKWV\SQLEXPRESS;Initial Catalog=LbsDB;Integrated Security=True";
            Console.WriteLine(LbsDAl.SQLHelper.Constr);
            Assert.AreEqual(constr, LbsDAl.SQLHelper.Constr, "数据库链接字符串是否一样");

        }
        [Test]
        public void TestXMlRead()
        {
            //  string constr = @"Data Source=PC-20140223IKWV\SQLEXPRESS;Initial Catalog=LbsDB;Integrated Security=True";
            LbsXmlConfig.XmlConfigReader xrd = new LbsXmlConfig.XmlConfigReader(@"..\..\SqlConnConfig.xml");
            string xmlcon = xrd.Process("appSettings", "SqlConnectionString");
            Console.WriteLine(xmlcon);
            //  Assert.AreEqual(constr, xmlcon, "数据库链接字符串是否读取");
        }

    }
}
