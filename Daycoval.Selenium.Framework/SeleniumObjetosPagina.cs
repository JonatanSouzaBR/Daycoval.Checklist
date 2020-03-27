using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Daycoval.Selenium.Framework
{
    public class SeleniumObjetosPagina
    {
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleID { get; set; }
    }
}
