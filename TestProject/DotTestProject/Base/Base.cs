using OpenQA.Selenium;
using System;

namespace DotTestProject.Base
{
    public class Base
    {
        public BasePage CurrentPage
        {
            get;
            set;
        }
        private IWebDriver _driver
        {
            get;
            set;
        }
        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {

            return (TPage)Activator.CreateInstance(typeof(TPage));

        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}