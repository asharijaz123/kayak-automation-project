using DotTestProject.Base;
using OpenQA.Selenium;
using System;
using DotTestProject.Extensions;
using OpenQA.Selenium.Support.UI;

namespace DotAutoProject.Pages
{
    [Obsolete]
    public class FlightsPage : BasePage
    {
        public void selectTripType(string typeOfTrip)
        {
            string locator = "//div[@class='kml-layout zEiP-formAndCmp2Container']//div[@class='zEiP-formContainer']//div[@class='zcIg']//div//div[@role='button']//span[@class='svg wIIH-chevron-icon-wrapper']//*[name()='svg']";
            Click("XPath", locator);
            string locatorTripType = $"li[aria-label='{typeOfTrip}']";
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            Click("CssSelector", locatorTripType);
        }
        public void selectPassengers(int totalPassenger, string passengerType)
        {
            string locator = "//span[text()='1 adult']";
            Click("XPath", locator);
            if (passengerType == "Adults")
            {
                if (totalPassenger > 1)
                {
                    for (int i = 0; i < totalPassenger - 1; i++)
                    {
                        string plusLoc = $"//span[text()='{passengerType}']/parent::label/following-sibling::div/button[2]";
                        Click("XPath", plusLoc);

                    }
                }

            }
            DriverContext.Driver.FindElement(By.CssSelector("h2.title.dark")).Click();
        }
        public void SelectEconomy(string classType)
        {
            string locator = "//span[text()='Economy'][1]/following-sibling::span[1]";
            Click("XPath", locator);
            string classTypeLoc = $"//span[text()='{classType}']";
            Click("XPath", classTypeLoc);
            DriverContext.Driver.FindElement(By.CssSelector("h2.title.dark")).Click();

        }

        public void EnterFromLocation(string fromLocation)
        {
            string locator = "div[aria-label='Remove']";
            string txtFromLoC = "input.k_my-input";
            string btnfromLocationfromSuggestion = ".JyN0-item.JyN0-pres-item-horizon";
            string strategy = "CssSelector";
            Click(strategy, locator);
            type(strategy, txtFromLoC, fromLocation);
            Click(strategy, btnfromLocationfromSuggestion);

        }

        public void EnterToLocation(string toLocation)
        {
            string strategy = "CssSelector";
            string txtToLoation = "input[placeholder='To?']";
            string btnToLocationfromSuggestion = ".JyN0-item.JyN0-pres-item-horizon";
            Click(strategy, "div.zEiP-formField.zEiP-destination");
            type(strategy, txtToLoation, toLocation);
            Click(strategy, btnToLocationfromSuggestion);
        }
        public void EnterFromLocationMultiCity(string strtoLocation)
        {
            string strategy = "CssSelector";
            string btnToLocationfromSuggestion = ".JyN0-item.JyN0-pres-item-horizon";
            string txtFromLocation = "input[placeholder='From?']";
            for (int i = 2; i <= 2; i++)
            {
                string btnToLocation = $".zEiP-formBody:nth-child({i}) .zEiP-formField.zEiP-origin";
                Click("CssSelector", btnToLocation);
                type(strategy, txtFromLocation, strtoLocation);
                Click(strategy, btnToLocationfromSuggestion);

            }

        }

        public void EnterToLocationMultiCity(string strToLocation)
        {
            string strategy = "CssSelector";
            string btnToLocationfromSuggestion = ".JyN0-name-row";
            string btnToLocation = ".zEiP-formField.zEiP-destination";
            string txtToLocation = "input[placeholder='To?']";
            Click("CssSelector", btnToLocation);
            type(strategy, txtToLocation, strToLocation);
            Click(strategy, btnToLocationfromSuggestion);

        }
        public void ClickSearhButton()
        {
            string strategy = "CssSelector";
            string btnSearch = "button[aria-label='Search']";
            Click(strategy, btnSearch);
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(45);

        }

        public void verifySearch()
        {
            WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(60));
            IWebElement btnToAssert = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("ol.flights")));
            WebElementExtension.AssertElementPresent(btnToAssert);
        }

    }
}