using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ReadXmlNode(@"D:\workspaces\learnc#space\learn-csharp\XMLParse\test.xml");
            Console.Read();
        }

        public void ReadXmlNode(string filename)
        {
            XmlDocument xmlDoc = new XmlDocument();
            try 
            {
                xmlDoc.Load(filename);
                // 读取Activity节点下的数据。SelectSingleNode匹配第一个Activity节点
                XmlNode root = xmlDoc.SelectSingleNode("//Activity"); // 当节点Workflow带有属性时，使用SelectSingleNode无法读取
                if (root != null)
                {
                    string ActivityId = root.SelectSingleNode("ActivityId").InnerText;
                    string ActivityName = root.SelectSingleNode("ActivityName").InnerText;
                    string ActivityLevel = root.SelectSingleNode("ActivityLevel").InnerText;
                    Console.WriteLine("ActivityId: " + ActivityId + "/nActivityName: " + ActivityName + "/nActivityLevel: " + ActivityLevel);
                } 
                else
                {
                    Console.WriteLine("the node is not existed");
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
