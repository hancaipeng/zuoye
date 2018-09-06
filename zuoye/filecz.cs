using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace zuoye
{
    class filecz
    {
     
        
        string path = @"C:\Users\Administrator\source\repos\zuoye\zuoye\file.xml";

        public List<String> getFromXml()

        {
            file fi = new file();
            List<string> list = new List<string>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNodeList topM = xmlDoc.DocumentElement.ChildNodes;
            XmlNode node;
            node = xmlDoc.SelectSingleNode("file/sj/id");
            fi.Id = int.Parse(node.InnerText);
            node = xmlDoc.SelectSingleNode("file/sj/yx");
           // fi.Yx = int.Parse(node.InnerText);


            XmlNodeList nodelist = xmlDoc.SelectNodes("//sj");
            if (nodelist.Count > 0)
            {

                foreach (XmlElement el in nodelist) 
                {
                    list.Add(el.GetElementsByTagName("id")[0].InnerText);
                }
            }



            return list;


        }
        public List<file> getXml(string file)
        {
            List<file> fil = new List<file>();
            XmlDocument doc = new XmlDocument();
            doc.Load(file);  //加载Xml文件 
            XmlElement rootElem = doc.DocumentElement;  //获取根节点
            XmlNodeList RowpersonNodes = rootElem.GetElementsByTagName("sj"); //获取行节点数组 
            foreach (XmlNode node in RowpersonNodes)
            {
                file fi = new file();
                fi.Id = int.Parse(node.SelectSingleNode("id").InnerText);
                fi.Yx = node.SelectSingleNode("yx").InnerText;
                fi.Fl =node.SelectSingleNode("fl").InnerText;
                fi.Xx= node.SelectSingleNode("xx").InnerText;
                fi.Pl= node.SelectSingleNode("pl").InnerText;
                fi.Fj= node.SelectSingleNode("fj").InnerText;
                fi.User= node.SelectSingleNode("user").InnerText;
                fi.Date= DateTime.Parse(node.SelectSingleNode("date").InnerText);
                fi.Zyz= node.SelectSingleNode("zyz").InnerText;
                fi.Zt= node.SelectSingleNode("zt").InnerText;
                fi.Qrz= node.SelectSingleNode("qrz").InnerText;
                fi.Qr = DateTime.Parse(node.SelectSingleNode("qrr").InnerText);
                fi.Gx = DateTime.Parse(node.SelectSingleNode("gx").InnerText);
                fil.Add(fi);
              
            }
            return fil;
        }

        public void updateXml(string id, string yx, string fl, string xx, string pl, string fj,string user,string date,string zyz, string zt,string qrz,string qr,string gx)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(Program.mypath);  //加载Xml文件 
            XmlElement rootElem = doc.DocumentElement;  //获取根节点
            XmlNodeList RowpersonNodes = rootElem.GetElementsByTagName("sj"); //获取行节点数组 
            foreach (XmlNode node in RowpersonNodes)
            {
                if (node.SelectSingleNode("id").InnerText == id)
                {
                    node.SelectSingleNode("gx").InnerText = gx;
                    node.SelectSingleNode("yx").InnerText = yx;
                    node.SelectSingleNode("fl").InnerText = fl;
                    node.SelectSingleNode("xx").InnerText = xx;
                    node.SelectSingleNode("pl").InnerText = pl;
                    node.SelectSingleNode("fj").InnerText = fj;
                    node.SelectSingleNode("user").InnerText = user;
                    node.SelectSingleNode("date").InnerText = date;
                    node.SelectSingleNode("zyz").InnerText = zyz;
                    node.SelectSingleNode("zt").InnerText = zt;
                    node.SelectSingleNode("qrz").InnerText = qrz;
                    node.SelectSingleNode("qrr").InnerText = qr;

                }
            }
            doc.Save(Program.mypath);
        }

    }



    }
    




