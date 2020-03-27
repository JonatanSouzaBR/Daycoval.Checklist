using Daycoval.Selenium.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace Dayconnect.Cenarios.Web
{
    public class CenarioBase : IDisposable
    {
        public void InicializarFireFox()
        {
            SeleniumProperties.Driver = new FirefoxDriver();
            SeleniumProperties.Driver.Navigate().GoToUrl("https://ecode.daycoval.com.br/");
        }

        public  void InicializarChrome()
        {
            SeleniumProperties.Driver = new ChromeDriver();
            SeleniumProperties.Driver.Navigate().GoToUrl("https://ecode.daycoval.com.br/");
        }

        public void Dispose()
        {
            SeleniumProperties.Driver.Quit();
        }
    }
}
