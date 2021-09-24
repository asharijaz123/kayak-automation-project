using OpenQA.Selenium;
/**
 * @author Ashar Ijaz
 *
 * @date - 9/21/2021 
 */
namespace DotTestProject.Base
{
   public static class DriverContext
    {
        public static IWebDriver _driver;
        public static IWebDriver Driver
        {
            get {
                return _driver;
            }
            set {
                _driver = value;
            }
        }

    }
}
