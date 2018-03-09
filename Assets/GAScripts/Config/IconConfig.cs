using System.Collections.Generic;
using System.Xml;
using UnityEngine;
/**
 * \data\头像与分享.xlsx
 * 自动生成，请务修改
 */

namespace Config.ConfigObj
{
    public class IconConfig
    {
        /** ID */
        public int Id;
        /** 关键字 */
        public string Key;

        public List<int> ShopIDList = new List<int>();

        static public readonly string urlKey = "IconConfig";

        static Dictionary<int, IconConfig> Dictionary;

        static public void Parse(TextAsset xmlAsset)
        {
            //XmlDocument doc = CommonUtil.LoadXML(xmlAsset);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlAsset.text);
            XmlNode node = doc.SelectSingleNode("Config");

            Dictionary = new Dictionary<int, IconConfig>();

            if (node != null)
            {

                XmlNodeList nodeList = node.ChildNodes;

                if (nodeList != null && nodeList.Count > 0)
                {

                    foreach (XmlElement el in nodeList)
                    {

                        IconConfig config = new IconConfig();

                        config.Id = int.Parse(el.GetAttribute("Id"));

                        config.Key = el.GetAttribute("Key");

                        if (!string.IsNullOrEmpty(el.GetAttribute("ShopId")))
                        {
                            string str = el.GetAttribute("ShopId");
                            string[] list = str.Split(',');
                            foreach (string s in list)
                            {
                                config.ShopIDList.Add(int.Parse(s));
                            }
                        }

                        Dictionary.Add(config.Id, config);
                        //Debug.Log(" --->> key : " + config.Id + "  Value: " + config.Key);
                    }
                }
            }
        }

        static public IconConfig Get(int id)
        {
            if (Dictionary != null && Dictionary.ContainsKey(id))
            {
                return Dictionary[id];
            }
            return null;
        }

        static public Dictionary<int, IconConfig> Get()
        {
            return Dictionary;
        }
    }
}
