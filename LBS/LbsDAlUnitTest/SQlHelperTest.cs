using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace LBS
{
  public  class SQlHelperTest
    {
      [Test]
      public void TestSQlHelpConnectionString()
      { 
        string constr=@"Data Source=PC-20140223IKWV\SQLEXPRESS;Initial Catalog=LbsDB;Integrated Security=True";
        Console.WriteLine(SQLHelper.constr);
        Assert.AreEqual(constr,SQLHelper.constr,"数据库链接字符串是否一样");
       
      }
      
    }
}
