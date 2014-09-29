using System;
using System.Data;
using System.Web;

namespace LBS
{
    public interface IServiceAction 
    {
        /*
         *接口名称类似JAVA编写语法首字母小写其余单词首字母大写专用名词全部大写 
         *get开头表示从服务器获取数据(有数据返回Of后面代表返回的内容形式没有规定则返回默认接口指定类型)
         *set开头代表让服务执行某个操作(一般为SQL),一般不返回实质性内容(带有Of的与get带有of的规则一致)
         *实例1 getADListByTypeOfXML(int,int)表示从服务以广告类别获取广告列表接口定义返回值为string
         *实质返回的内容为XML结构的文档,便于客户端的数据解析(SAX,Pull,Dom)
         *实例2 setSQLOfXML(string)表示让服务执行一条SQL语句并且返回具有XML文档结构的文档不带Of的表示
         *只返回SQL语句的执行成功与否其值为"True" or "False"
         *在本接口定义中基本所有接口的显式返回值为string,其具体意义可能会是Bool,XML等等的类型.
         *主要是考虑到类型通用,以及数据的传输,DataSet是为了方便PC管理系统的开发.下面每个接口会有详细介绍
         */
        //用于注册一个新用户type代表用户类型,并返回注册是否成功
        string register(string username, string userpassword, int type);
        //登录服务器,并返回登录是否成功
        string login(string username, string userpassword);
        //以广告类型获取广告列表,并返回具有XML文档结构的字符串
        string getADListByTypeOfXML(int adtype, int hobtype);
        //以用户名获取广告列表,并返回具有XML文档结构的字符串
        string getADListByUserNameOfXML(string username);
        //以地理位置获取广告列表,并返回具有XML文档结构的字符串
        string getADListByAddressOfXML(string address);
        //获取广告类型排行榜,并返回具有XML文档结构的字符串
        string getRankToNOfXML(int type, int number);
        //以广告的Id获取广告的详细信息,并返回具有XML文档结构的字符串
        string getADByIdOfXML(int id);
        //让服务执行一条SQL语句,并返回是否执行成功("True" or "False")
        string setSQL(string sql);
        //让服务执行一条SQL语句,并返回DataSet(数据集)结构的对象
        DataSet setSQLOfDataSet(string sql);
        //让服务执行一条SQL语句,并返回具有XML文档结构的字符串
        string setSQLOfXML(string sql);
        //以广告ID删除广告,并返回是否成功
        string setDeleteADById(int id);
        //以用户名删除广告,并返回是否成功
        string setDeleteADByUserName(string username);
        

    }
}
