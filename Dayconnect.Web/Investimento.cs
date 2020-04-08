using Dayconnect.Cenarios.Web.Models.Base;
using Daycoval.Selenium.Framework.Parametros;
using NUnit.Framework;
using Testes.Cenarios.Web;

namespace Dayconnect
{
    public class Investimento
    {
        private readonly InvestimentosCenario _cenario;

        public Investimento()
        {
            _cenario = new InvestimentosCenario(EnumBrowser.Chrome);
        }

        [Test]
        public void RendaFixaFirefox()
        {
            _cenario.ExecutarLogin(Sistema.Login,Sistema.Senha);
            _cenario.InvestirRendaFixa();
            _cenario.Desconectar();
            _cenario.Dispose();
        }
    }
}
