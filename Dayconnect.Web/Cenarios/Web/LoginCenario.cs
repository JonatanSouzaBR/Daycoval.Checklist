using Dayconnect.Cenarios.Web.Models;
using Dayconnect.Cenarios.Web.Models.Base;

namespace Testes.Cenarios.Web
{
    public class LoginCenario : CenarioBase
    {
        public string VerificarErro()
        {
            var page = new LoginModalErroModel();

            return page.RetornarMensageErro();
        }
    }
}
