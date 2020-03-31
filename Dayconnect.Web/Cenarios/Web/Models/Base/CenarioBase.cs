using Daycoval.Selenium.Framework;
using Daycoval.Selenium.Framework.Parametros;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace Dayconnect.Cenarios.Web.Models.Base
{
    public class CenarioBase : IDisposable
    {
        public void InicializarBrowser(EnumBrowser browser)
        {
            switch (browser)
            {
                case (EnumBrowser.Chrome):
                {
                    InicializarChrome();
                    break;
                }
                case (EnumBrowser.FireFox):
                {
                    InicializarFireFox();
                    break;
                }
            }
        }

        private void InicializarFireFox()
        {
            SeleniumProperties.Driver = new FirefoxDriver();
            SeleniumProperties.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(3);
            SeleniumProperties.Driver.Navigate().GoToUrl(DayconnectUrl.Login);
        }

        private void InicializarChrome()
        {
            SeleniumProperties.Driver = new ChromeDriver();
            SeleniumProperties.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(3);
            SeleniumProperties.Driver.Navigate().GoToUrl(DayconnectUrl.Login);
        }

        public void ExecutarLogin(string login, string senha)
        {
            EfetuarLogin(login, senha);
        }

        private void EfetuarLogin(string login, string senha)
        {
            PreencherLogin(login);
            PreencherSenha(senha);
        }

        private static void PreencherLogin(string login)
        {
            var page = new LoginModel();
            var campo1 = login.Substring(0, 3);
            var campo2 = login.Substring(3, 3);
            var campo3 = login.Substring(6, 3);
            var campo4 = login.Substring(9, 2);

            page.PreencherLogin(campo1, campo2, campo3, campo4);
        }

        private void PreencherSenha(string senha)
        {
            var page = new LoginSenhaModel();
            page.PreencherSenha(senha);
            page.EnviarSenha();
        }

        public void Desconectar()
        {
            var desconectarModel = new DesconectarModel();
            desconectarModel.Desconectar();
        }

        public void NaoDesconectar()
        {
            var desconectarModel = new DesconectarModel();
            desconectarModel.NaoDesconectar();
        }

        public void Dispose()
        {
            SeleniumProperties.Driver.Quit();
            SeleniumProperties.Driver.Close();
            SeleniumProperties.Driver.Dispose();
        }
    }
}
