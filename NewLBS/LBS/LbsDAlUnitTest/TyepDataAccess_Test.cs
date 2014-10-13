using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LbsDAlUnitTest
{
  public  class TypeDataAccess_Test
    {
      public void TestAddType()
      {
          LbsModel.Type type = new LbsModel.Type();
          type.T_ID = 1;
          type.T_Name = "zx";
          Console.WriteLine(LbsDAl.TypeDataAccess.AddType(type));
      }
      public void TestEditType()
      {
          LbsModel.Type type = new LbsModel.Type();
          type = LbsDAl.TypeDataAccess.SelectByTypeID(1);
          type.T_Name = "ym";
          Console.WriteLine(LbsDAl.TypeDataAccess.EditTypeInfo(type));
      }
    }
}
