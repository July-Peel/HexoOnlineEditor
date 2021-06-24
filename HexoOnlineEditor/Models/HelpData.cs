using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
        public static string Get(string url)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36";
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return result;
        }
    }
}
