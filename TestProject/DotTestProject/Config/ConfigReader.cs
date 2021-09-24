using System;
using System.Xml.XPath;
using System.IO;

namespace DotTestProject.Config
{
    public class ConfigReader
    {

        public static void SetFrameworkSettings()
        {

            XPathItem aut;

            string strFilename = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFilename, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            aut = navigator.SelectSingleNode("TestProject/RunSettings/AUT");

            //Set XML Details in the property to be used accross framework
            Settings.AUT = aut.Value.ToString();

        }

    }
}