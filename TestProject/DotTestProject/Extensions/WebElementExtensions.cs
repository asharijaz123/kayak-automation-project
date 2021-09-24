using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DotTestProject.Extensions
{
    public static class WebElementExtension
    {

        public static void SelectDDL(this IWebElement element, string value)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByText(value);
        }

        public static string GetText(IWebElement element)
        {
            return element.Text;
        }

        private static bool IsElementPresent(IWebElement element)
        {
            try
            {
                bool b = element.Displayed;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void AssertElementPresent(this IWebElement element)
        {
            if (!IsElementPresent(element))
                throw new AssertionException(String.Format("AssertElementNotPresent exception"));
        }
    }
}