using Daycoval.Selenium.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Dayconnect.Cenarios.Web.Models
{
    public class LoginModel
    {
        public LoginModel()
        {
            PageFactory.InitElements(SeleniumProperties.Driver, this);
        }

        [FindsBy(How = How.Name, Using = "ctl00$cphLogin$txtUsuario1")]
        public IWebElement CampoUsuario1 { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$cphLogin$txtUsuario2")]
        public IWebElement CampoUsuario2 { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$cphLogin$txtUsuario3")]
        public IWebElement CampoUsuario3 { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$cphLogin$txtUsuario4")]
        public IWebElement CampoUsuario4 { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphLogin_btnLogin")]
        public IWebElement BotaoLogin { get; set; }


        public void PreencherLogin(string campo1, string campo2, string campo3, string campo4)
        {
            CampoUsuario1.PreencherTexto(campo1);
            CampoUsuario2.PreencherTexto(campo2);
            CampoUsuario3.PreencherTexto(campo3);
            CampoUsuario4.PreencherTexto(campo4);
            BotaoLogin.Clicar();
        }
    }
}
