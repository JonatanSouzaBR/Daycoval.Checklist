using Daycoval.Selenium.Framework;
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
        }

        [Test]
        public void DeveExecutarLoginComSucesso()
        {
            for (int i = 0; i < 1000000; i++)
            {

                _login.ExecutarNoFirefox(Parametros.Login, Parametros.Senha);

                //Assert.AreEqual("https://ecode.daycoval.com.br/Home/Default", _login.Url);

                _login.Dispose();
            }
        }

        [Test]
        public void NaoDeveExecutarLoginComSenhaInvalida()
        {
            _login.ExecutarNoFirefox(Parametros.Login, "12345678");

            _login.VerificarErro();

            var errorResponse = _login.VerificarErro();

            Assert.True(errorResponse.Contains("Dados incorretos. Após 3 tentativas o usuário será bloqueado."));

            _login.Dispose();
        }

    }
}