using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LbsDAlUnitTest
{
  public  class AdSellarInfo_Test
    {
      public void TestAddAdSellar()
      {
          //不可以插入重复值
          //u_ID不可以为空白字符串
         // bool flag = true;
          LbsModel.ADSellarInfo adSellar = new LbsModel.ADSellarInfo();
          adSellar.Ads_ID = "ym2";
          adSellar.U_ID = "2010";
          adSellar.Ads_Company = "zx";
          adSellar.Ads_CreateTime = DateTime.Now.ToShortDateString();
          Console.WriteLine(  LbsDAl.ADSellarInfoDataAccess.AddAdSellar(adSellar));
      }
      public void TestEidtAdSellar()
      {
          //修改adsellar的U_ID时，表usersinfo中一定要有相对应的U_ID值才能成功。
          LbsModel.ADSellarInfo adSellar = new LbsModel.ADSellarInfo();
          adSellar = LbsDAl.ADSellarInfoDataAccess.SelectByAdsID("ym");
          adSellar.U_ID = "2010";
          Console.WriteLine(LbsDAl.ADSellarInfoDataAccess.EditADSellarInfo(adSellar));
      }
    }
}
