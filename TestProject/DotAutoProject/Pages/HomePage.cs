using DotTestProject.Base;
using System;

namespace DotAutoProject.Pages
{
    [Obsolete]
    class HomePage : BasePage
    {

        public FlightsPage ClickFlightsModule()
        {
            string locator = "a[aria-label='Search for flights']";
            Click("CssSelector", locator);
            return GetInstance<FlightsPage>();
        }

    }
}