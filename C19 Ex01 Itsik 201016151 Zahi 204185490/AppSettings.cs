﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;

namespace C19_Ex01_Itsik_201016151_Zahi_204185490
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(1100, 600);
            RememberUser = false;
            LastAccessToken = null;
        }

        public void SaveToFile()
        {
            if (!File.Exists(@"D:\appSettings.xml"))
            {
                Stream s = new FileStream(@"D:\appSettings.xml", FileMode.Create);
                s.Dispose();
            }

                using (Stream stream = new FileStream(@"D:\appSettings.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        { 
            AppSettings obj = new AppSettings();
            if(File.Exists(@"D:\appSettings.xml"))
            {
                using (Stream stream = new FileStream(@"D:\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }
    }
}
