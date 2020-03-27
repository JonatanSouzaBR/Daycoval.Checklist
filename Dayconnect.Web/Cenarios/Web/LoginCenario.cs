using Dayconnect.Cenarios.Web;
using Dayconnect.Cenarios.Web.Models;
using Daycoval.Selenium.Framework;
using System;

namespace Testes.Cenarios.Web
{
    public class LoginCenario : CenarioBase
    {
        public string Url { get; private set; }

        public void ExecutarNoFirefox(string login, string senha)
        {
            InicializarFireFox();
            EfetuarLogin(login, senha);
            Url =  SeleniumProperties.Driver.Url;
        }

        public void ExecutarNoChrome(string login, string senha)
        {
            InicializarChrome();
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

        internal string VerificarErro()
        {
            var page = new LoginModalErroModel();

            return page.RetornarMensageErro();
        }

        private void PreencherSenha(string senha)
        {
            var page = new LoginSenhaModel();

            page.PreencherSenha(senha);
            
        }
    }
}
