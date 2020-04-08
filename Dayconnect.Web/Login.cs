using Dayconnect.Cenarios.Web.Models.Base;
using Daycoval.Selenium.Framework;
using Daycoval.Selenium.Framework.Parametros;
using NUnit.Framework;
using Testes.Cenarios.Web;

namespace Testes
{
    public class Login
    {
        //private readonly IWebDriver driver = new ChromeDriver();
        private readonly LoginCenario _login;

        public Login()
        {
            _login = new LoginCenario();
            _login.InicializarBrowser(EnumBrowser.Chrome);
        }

        [Test]
        public void DeveExecutarLoginComSucesso()
        {
            _login.ExecutarLogin(Sistema.Login, Sistema.Senha);
            Assert.AreEqual(DayconnectUrl.Home, SeleniumProperties.Driver.Url);
            _login.Dispose();
        }

        [Test]
        public void NaoDeveExecutarLoginComSenhaInvalida()
        {
            _login.ExecutarLogin(Sistema.Login, "00000000");

            _login.VerificarErro();

            var errorResponse = _login.VerificarErro();

            Assert.True(errorResponse.Contains("Dados incorretos. Após 3 tentativas o usuário será bloqueado."));

            _login.Dispose();
        }

    }
}