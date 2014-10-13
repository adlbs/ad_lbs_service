using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LbsDAlUnitTest
{
  public  class UserHobbyDA_Test
    {
      public void TestAddUh()
      {
          LbsModel.UserHobby uh = new LbsModel.UserHobby();
          uh.U_ID = "2013zx";
          uh.T_ID = 2;
          Console.WriteLine(LbsDAl.UserHobbyDataAccess.AddUserHoby(uh));
      }
      public void TestEditUh()
      {
          LbsModel.UserHobby uh = new LbsModel.UserHobby();
          uh = LbsDAl.UserHobbyDataAccess.SelectByUT("2013zx",2);       
          Console.WriteLine(LbsDAl.UserHobbyDataAccess.EditUserHobby(uh,1));
      }
    }
}
