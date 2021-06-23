using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace HexoOnlineEditor.Models
{
    public class HelpData
    {
        public static string GetMD5(string Text)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(Text);
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider check;
                check = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] somme = check.ComputeHash(buffer);
                string ret = "";
                foreach (var item in somme)
                {
                    if (item < 16)
                    {
                        ret += "0" + item.ToString("X");
                    }
                    else
                    {
                        ret += item.ToString("X");
                    }
                }
                return ret.ToLower();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string GetXmlNote(string note)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "config.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                XmlNode root = xmlDoc.SelectSingleNode(string.Format("//{0}", "root"));
                return root.SelectSingleNode(note).InnerText;
            }
            catch
            {
                return "";
            }
        }
        public static bool SetXmlNote(string note,string value)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "config.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                XmlNode root = xmlDoc.SelectSingleNode(string.Format("//{0}", "root"));
                root.SelectSingleNode(note).InnerText = value;
                xmlDoc.Save(path);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
