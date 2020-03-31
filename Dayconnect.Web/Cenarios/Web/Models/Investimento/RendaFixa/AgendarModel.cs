using Daycoval.Selenium.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace Dayconnect.Cenarios.Web.Models
{
    public class AgendarModel
    {
        public AgendarModel()
        {
            PageFactory.InitElements(SeleniumProperties.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_gdvProdutoCDB_ctl02_lbAgendar")]
        public IWebElement LinkAgendar { get; set; }

        public void Agendar()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)SeleniumProperties.Driver;
            executor.ExecuteScript("arguments[0].click();", LinkAgendar);
        }
    }
}
