using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using NUnit.Framework;
namespace LBS
=======
using System.Threading.Tasks;
using NUnit.Framework;
namespace LbsDAlUnitTest
>>>>>>> origin/master
{
  public  class SQlHelperTest
    {
      [Test]
      public void TestSQlHelpConnectionString()
      { 
        string constr=@"Data Source=PC-20140223IKWV\SQLEXPRESS;Initial Catalog=LbsDB;Integrated Security=True";
<<<<<<< HEAD
        Console.WriteLine(SQLHelper.constr);
        Assert.AreEqual(constr,SQLHelper.constr,"数据库链接字符串是否一样");
=======
        Console.WriteLine(LbsDAl.SQLHelper.constr);
        Assert.AreEqual(constr,LbsDAl.SQLHelper.constr,"数据库链接字符串是否一样");
>>>>>>> origin/master
       
      }
      
    }
}
