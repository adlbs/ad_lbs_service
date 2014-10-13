using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LbsDAlUnitTest
{
    class Program_Test
    {

        /// <summary>
        /// 控制台测试
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region userinfoDA_test
            UserInfoDA_Test ut = new UserInfoDA_Test();
            //添加
            //ut.TestAddUser();
            //修改
            //ut.TestEditUser();
            //ut.TestXMlRead();
           // ut.TestUserIsExist();
            ut.TestUserSelect();
            #endregion
            #region adsellarinfoDA_test
          //  AdSellarInfo_Test at = new AdSellarInfo_Test();
           // at.TestAddAdSellar();
           // at.TestEidtAdSellar();
            #endregion
            #region typeDA_test
           // TypeDataAccess_Test tt = new TypeDataAccess_Test();
           // tt.TestAddType();
           // tt.TestEditType();
            #endregion
            #region  adInfoDA_test
          //  AdInfo_Test adit = new AdInfo_Test();
           // adit.TestAddAD();
           // adit.TestEditAD();
            #endregion
            #region userhobby_test
          //  UserHobbyDA_Test uht = new UserHobbyDA_Test();
            // uht.TestAddUh();
          //  uht.TestEditUh();
            #endregion

            #region AdByUserOperate_test
          //  AdByUserOperate_Test auot = new AdByUserOperate_Test();
            //auot.TestAdd();
          //  auot.TestSelect();
            #endregion
            #region ADOperate_test
           // ADOperate_Test ado = new ADOperate_Test();
           // ado.TestAdd();
          //  ado.TestSelectByADID();
            #endregion
            #region UserOperate_test
           // UserOperate_Test uo = new UserOperate_Test();
           // uo.TestAdd();
           // uo.TestSelect();
            #endregion
            //测试数据库链接字符串
            //SQlHelperTest st = new SQlHelperTest();
            //st.TestXMlRead();
            Console.Read();
        }

    }
}
