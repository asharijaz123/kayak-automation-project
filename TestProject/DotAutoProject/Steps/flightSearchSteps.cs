using DotAutoProject.Pages;
using TechTalk.SpecFlow;
using DotTestProject.Base;
using DotTestProject.Config;
using TechTalk.SpecFlow.Assist;

namespace DotAutoProject
{
    [Binding]
    [System.Obsolete]
    public class flightSearchSteps : Base
    {
        [Given(@"I navigate to the Kayak Appliation")]
        public void GivenINavigateToTheKayakAppliationp()
        {
            ConfigReader.SetFrameworkSettings();
            DriverContext.Driver.Navigate().GoToUrl(Settings.AUT);
            DriverContext.Driver.Manage().Window.Maximize();
        }

        [When(@"I Click on Flights Module")]
        public void WhenIClickonFlightsModule()
        {

            CurrentPage = GetInstance<HomePage>();
            CurrentPage = CurrentPage.As<HomePage>().ClickFlightsModule();
        }

        [When(@"I Select the Type of Trip")]
        public void WhenISelecttheTypeofTrip(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage = GetInstance<FlightsPage>();
            CurrentPage.As<FlightsPage>().selectTripType(data.tripType);
        }

        [When(@"I Select the Number of Passengers")]
        public void WhenISelecttheNumberofPassengers(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage = GetInstance<FlightsPage>();
            CurrentPage.As<FlightsPage>().selectPassengers(data.totalPassenger, data.passengerType);
        }

        [When(@"I Select the Type of Class")]
        public void WhenSelecttheTypeofClass(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage = GetInstance<FlightsPage>();
            CurrentPage.As<FlightsPage>().SelectEconomy(data.classType);
        }

        [When(@"I Enter the From Location for Flight")]
        public void WhenIEntertheFromLocationforFlight(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage = GetInstance<FlightsPage>();
            CurrentPage.As<FlightsPage>().EnterFromLocation(data.fromLocation);
        }

        [When(@"I Enter the From Location for Multi City Flight")]
        public void WhenIEntertheFromLocationforMultiCityFlight(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage = GetInstance<FlightsPage>();
            CurrentPage.As<FlightsPage>().EnterFromLocationMultiCity(data.fromLocation);
        }

        [When(@"I Enter the To Location for Flight")]
        public void WhenIEntertheToLocationforFlight(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage = GetInstance<FlightsPage>();
            CurrentPage.As<FlightsPage>().EnterToLocation(data.toLocation);
        }

        [When(@"I Enter the To Location for Multi City for Flight")]
        public void WhenIEntertheToLocationforMultiCityforFlight(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage = GetInstance<FlightsPage>();
            CurrentPage.As<FlightsPage>().EnterToLocationMultiCity(data.toLocation);
        }

        [When(@"I Click on the Searh Button")]
        public void WhenIClickOnTheSearhButton()
        {
            CurrentPage = GetInstance<FlightsPage>();
            CurrentPage.As<FlightsPage>().ClickSearhButton();
        }

        [Then(@"I Verify the Search")]
        public void WhenIVerifytheSearch()
        {
            CurrentPage = GetInstance<FlightsPage>();
            CurrentPage.As<FlightsPage>().verifySearch();
        }
    }
}