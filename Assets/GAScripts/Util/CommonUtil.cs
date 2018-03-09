using UnityEngine;
using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using Config;
using Config.ConfigObj;


public class CommonUtil
{

    /// <summary>
    /// 加载XML配表
    /// </summary>
    public static XmlDocument LoadXML(TextAsset asset)
    {
        byte[] bytes = asset.bytes;

        SecretInfo.Decrypt(bytes);

        MemoryStream ms = new MemoryStream(bytes);
        XmlReaderSettings setting = new XmlReaderSettings();
        setting.IgnoreComments = true;
        XmlReader reader = XmlReader.Create(ms, setting);
        XmlDocument doc = new XmlDocument();
        doc.Load(reader);

        return doc;
    }
}
