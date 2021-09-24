using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DotTestProject.Base
{
    public class BasePage : Base
    {
        [Obsolete]
        public void Click(string strategy, string locator)
        {

            WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(60));
            IWebElement btnToClick;
            if (strategy == "Id")
            {
                btnToClick = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));
                btnToClick.Click();

            }
            else if (strategy == "XPath")
            {
                btnToClick = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
                btnToClick.Click();

            }
            else if (strategy == "CssSelector")
            {
                btnToClick = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator)));
                btnToClick.Click();

            }

        }

        [Obsolete]
        public void type(string strategy, string locator, string strValue)
        {
            WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(60));
            IWebElement btnToSendKeys;
            if (strategy == "Id")
            {
                btnToSendKeys = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));
                btnToSendKeys.Clear();
                btnToSendKeys.SendKeys(strValue);

            }
            else if (strategy == "XPath")
            {
                btnToSendKeys = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
                btnToSendKeys.Clear();
                btnToSendKeys.SendKeys(strValue);

            }
            else if (strategy == "CssSelector")
            {
                btnToSendKeys = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator)));
                //   btnToSendKeys.Clear();
                btnToSendKeys.SendKeys(strValue);

            }

        }

    }

}