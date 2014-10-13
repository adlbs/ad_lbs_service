using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
namespace LbsXmlConfig
{
    public  class XmlConfigReader
    {
        string _filePath;


        /// <summary>
        /// XmlConfigReader的构造函数
        /// </summary>
        /// <param name="filepath">xml文件路径</param>
        public XmlConfigReader(string filepath)
        {
            _filePath = Path.GetFullPath(filepath).ToUpper();//得到此文件的绝对路径
        }


        /// <summary>
        /// 处理XML文件进行字符串读写
        /// </summary>
        /// <param name="sectionName">配置节</param>
        /// <param name="key">配置节点名</param>
        /// <returns>配置节点值</returns>
        public  string Process(string sectionName, string key)
        {
            bool inConfiguration = false;
            bool inSection = false;
            string values = string.Empty;
            XmlTextReader reader = new XmlTextReader(_filePath);
            while (reader.Read())
            {
                if (reader.IsStartElement())//XML是否为空
                {
                    if (reader.Prefix == String.Empty) //空间前缀是否为空
                    {
                        if (reader.LocalName == "configuration") //判断本地节是否为configuration
                        {
                            inConfiguration = true;
                        }
                        else if (inConfiguration == true) //可判断其他配置节
                        {
                            if (reader.LocalName == sectionName) //判断其他配置节点
                            {
                                inSection = true;
                            }
                            else if (inSection && reader.LocalName == "add") //取值
                            {
                                if (reader.GetAttribute("key") == null || reader.GetAttribute("value") == null)
                                {
                                    throw new Exception(sectionName + " key or value is null");
                                }
                                if (reader.GetAttribute("key") == key)
                                {
                                    values = reader.GetAttribute("value");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            reader.Close(); //关闭此Reader
            return values;
        }
    }
}
