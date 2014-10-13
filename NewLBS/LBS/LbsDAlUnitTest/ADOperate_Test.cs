using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LbsDAlUnitTest
{
   public class ADOperate_Test
    {

       public void TestAdd()
       {
           LbsModel.ADOpearte ado = new LbsModel.ADOpearte();
           ado.Ad_ID = "zx";
           Console.WriteLine(LbsDAl.ADOperateDataAccess.AddADoperate(ado));


       }

       public void TestSelectByADID()
       {
           Console.WriteLine(LbsDAl.ADOperateDataAccess.SelectByAdID("zx"));
       
       }
         


    }
}
