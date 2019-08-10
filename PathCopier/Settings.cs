using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml;
using System.IO;

namespace PathCopier
{
    static class Settings
    {

        private static Color gtop = Color.Navy;

        public static Color GradientTopColor
        {
            get { return gtop; }
            set
            {
                gtop = value;
            }
        }

        private static Color gbottom = Color.Blue;

        public static Color GradientBottomColor
        {
            get { return gbottom; }
            set
            {
                gbottom = value;
            }
        }

        private static Color ol = Color.Blue;

        public static Color OutlineColor
        {
            get { return ol; }
            set
            {
                ol = value;
            }
        }

        private static Color text = Color.White;

        public static Color TextColor
        {
            get { return text; }
            set
            {
                text = value;
            }
        }

        public static string SettingsFolder
        {
            get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Path Copier"); }
        }

        public static string SettingsPath
        {
            get { return Path.Combine(SettingsFolder, "Settings.xml"); }
        }

        public static void Load()
        {
            string path = SettingsPath;

            try
            {
                if (!System.IO.File.Exists(path))
                    path = Path.Combine(System.Windows.Forms.Application.StartupPath, "Settings.xml");
                System.Xml.XmlDocument Xml = new System.Xml.XmlDocument();

                Xml.Load(path);

                gtop = ColorTranslator.FromHtml(Xml["Settings"]["GradientTop"].InnerText);
                gbottom = ColorTranslator.FromHtml(Xml["Settings"]["GradientBottom"].InnerText);
                ol = ColorTranslator.FromHtml(Xml["Settings"]["OutlineColor"].InnerText);
                text = ColorTranslator.FromHtml(Xml["Settings"]["TextColor"].InnerText);


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An Error Occured");
            }
        }

        public static void Save()
        {



            try
            {

                if (!Directory.Exists(SettingsFolder))
                    Directory.CreateDirectory(SettingsFolder);

                System.Xml.XmlDocument Xml = new System.Xml.XmlDocument();
                Xml.AppendChild(Xml.CreateXmlDeclaration("1.0", "utf-8", null));
                XmlNode Pnode = Xml.CreateElement("Settings");
                XmlNode Temp;
                Temp = Xml.CreateElement("GradientTop");
                Temp.InnerText = ColorTranslator.ToHtml(GradientTopColor);
                Pnode.AppendChild(Temp);
                Temp = Xml.CreateElement("GradientBottom");
                Temp.InnerText = ColorTranslator.ToHtml(GradientBottomColor);
                Pnode.AppendChild(Temp);
                Temp = Xml.CreateElement("OutlineColor");
                Temp.InnerText = ColorTranslator.ToHtml(OutlineColor);
                Pnode.AppendChild(Temp);
                Temp = Xml.CreateElement("TextColor");
                Temp.InnerText = ColorTranslator.ToHtml(TextColor);
                Pnode.AppendChild(Temp);

                Xml.AppendChild(Pnode);
                Xml.Save(SettingsPath);


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An Error Occured");

            }
        }


    }
}
