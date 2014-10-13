using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LbsDAlUnitTest
{
    public class AdInfo_Test
    {
        public void TestAddAD()
        {
            LbsModel.ADInfo ad = new LbsModel.ADInfo();
            ad.Ads_ID = "ym";
            ad.Ad_ID = "ym";
            ad.T_ID = 1;
            Console.WriteLine(LbsDAl.ADInfoDataAccess.AddAdInfo(ad));
        }
        public void TestEditAD()
        {
            LbsModel.ADInfo ad = new LbsModel.ADInfo();
            ad = LbsDAl.ADInfoDataAccess.SelectByAdID("ym");
            ad.Ad_Title = "2013zx";
            Console.WriteLine(LbsDAl.ADInfoDataAccess.EditAdInfo(ad));
        }
    }
}
