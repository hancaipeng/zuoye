using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace zuoye
{
    class filecz
    {

     
        public List<file> getXml(string file)
        {
            Program.fill = new List<file>();
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
                Program.fill.Add(fi);
              
            }
            return Program.fill;
        }

        public void saveXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", ""));
            XmlElement one = doc.CreateElement("file");   
            doc.AppendChild(one);
            XmlElement two = doc.CreateElement("sj");
            one.AppendChild(two);
          
            doc.Save(Program.mypath);
        }

        public void updateXml(string id, string yx, string fl, string xx, string pl, string fj, string user, string date, string zyz, string zt, string qrz, string qr, string gx)
        {
            foreach(file x in Program.fill)
            {
                if (x.Id == int.Parse(id))
                {
                    x.Yx = yx;
                    x.Fl = fl;
                    x.Xx = xx;
                    x.Pl = pl;
                    x.Fj = fj;
                    x.User = user;
                    x.Date = DateTime.Parse(date);
                    x.Zyz = zyz;
                    x.Zt = zt;
                    x.Qrz = qrz;
                    x.Qr = DateTime.Parse(qr);
                    x.Gx = DateTime.Parse(gx);

                }
            }
            
        }

        public void addxml(string id, string yx, string fl, string xx, string pl, string fj, string user, string date, string zyz, string zt, string qrz, string qr, string gx)
        {
            file fi = new file();
            fi.Id = int.Parse(id);
            fi.Yx = yx;
            fi.Fl = fl;
            fi.Xx = xx;
            fi.Pl = pl;
            fi.Fj = fj;
            fi.User =user;
            fi.Date = DateTime.Parse(date);
            fi.Zyz = zyz;
            fi.Zt = zt;
            fi.Qrz = qrz;
            fi.Qr = DateTime.Parse(qr);
            fi.Gx = DateTime.Parse(gx);
            Program.fill.Add(fi);
        }
        public void deletexml(string id)
        {
          for(int i=Program.fill.Count-1; i >= 0; i--)
            {
                if (Program.fill[i].Id == int.Parse(id))
                {
                    Program.fill.Remove(Program.fill[i]);
                }
            }
        }
        public List<file> fii()
        {
            return Program.fill;
        }

    }
   


    }
    




