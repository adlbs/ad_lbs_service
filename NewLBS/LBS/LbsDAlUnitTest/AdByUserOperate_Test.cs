using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LbsDAlUnitTest
{
    class AdByUserOperate_Test
    {
        public void TestAdd()
        {

            LbsModel.AdByUserOperate auo = new LbsModel.AdByUserOperate();
            auo.U_ID = "2010";
            auo.Ad_ID = "zx";
           
            Console.WriteLine(LbsDAl.AdByUserOperateDataAccess.AddAuo(auo));
        
        }
        public void TestSelect()
        {
            Console.WriteLine(LbsDAl.AdByUserOperateDataAccess.SelectByUserId("2010"));
        
        
        }


    }
}
