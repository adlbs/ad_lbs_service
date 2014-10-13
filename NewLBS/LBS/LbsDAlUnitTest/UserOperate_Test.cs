using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LbsDAlUnitTest
{
    class UserOperate_Test
    {

        public void TestAdd()
        {
            LbsModel.UserOperate uo = new LbsModel.UserOperate();
            uo.U_ID = "2010";
            Console.WriteLine(LbsDAl.UserOperateDataAccess.AddUserOperate(uo));
        
        }

        public void TestSelect()
        {

            Console.WriteLine(LbsDAl.UserOperateDataAccess.SelectByUID("2010"));
        
        }
    }
}
