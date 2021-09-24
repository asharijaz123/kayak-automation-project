using DotTestProject.Base;
using DotTestProject.Config;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace DotTicketingProject.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            ConfigReader.SetFrameworkSettings();
            DriverContext.Driver = new ChromeDriver();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverContext.Driver.Quit();

        }
    }
}