using Testes.Cenarios.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Testes
{
    public class Web
    {
        private readonly IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Iniciar()
        {

        }

        [Test]
        public void Login()
        {
            var _login = new Login();

            _login.Executar();
        }

        //[Test]
        public void ContaCorrente()
        {
            var _contaCorrente = new ContaCorrente();

            _contaCorrente.Executar();
        }

        //[Test]
        public void Transferencia()
        {
            var _transferencia = new Transferencia();

            _transferencia.Executar();
        }

        //[Test]
        public void Pagamentos()
        {
            var _pagamentos = new Pagamentos();

            _pagamentos.Executar();
        }

        //[Test]
        public void Investimentos()
        {
            var _investimentos = new Investimentos();

            _investimentos.Executar();
        }

        //[Test]
        public void Cambio()
        {
            var _cambio = new Cambio();

            _cambio.Executar();
        }

        [TearDown]
        public void Encerrar()
        {
            driver.Close();
        }
    }
}