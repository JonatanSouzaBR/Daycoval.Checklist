using Dayconnect.Cenarios.Web.Models;
using Daycoval.Selenium.Framework;
using OpenQA.Selenium.Chrome;

namespace Testes.Cenarios.Web
{
    public class Login
    {
        public void Executar()
        {
            Inicializar();
            EfetuarLogin();
        }

        private void Inicializar()
        {
            SeleniumProperties.Driver = new ChromeDriver();
            SeleniumProperties.Driver.Navigate().GoToUrl("https://ecode.daycoval.com.br/");
        }


        private void EfetuarLogin()
        { 
            var page = new LoginModel();

            page.PreencherLogin("000", "220", "051", "01");
        }
    }
}
