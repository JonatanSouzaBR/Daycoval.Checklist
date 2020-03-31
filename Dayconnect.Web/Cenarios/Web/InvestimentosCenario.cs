using Dayconnect.Cenarios.Web.Models;
using Dayconnect.Cenarios.Web.Models.Base;
using Dayconnect.Cenarios.Web.Models.Investimento.RendaFixa;
using Daycoval.Selenium.Framework;
using Daycoval.Selenium.Framework.Parametros;
using System;

namespace Testes.Cenarios.Web
{
    public class InvestimentosCenario : CenarioBase
    {
        private readonly AgendarModel _agendarModel;
        private readonly AplicacaoModel _aplicacaoModel;
        private readonly ConfirmacaoModel _confimacaoModel;

        public InvestimentosCenario(EnumBrowser browser)
        {
            InicializarBrowser(browser);
            _agendarModel = new AgendarModel();
            _aplicacaoModel = new AplicacaoModel();
            _confimacaoModel = new ConfirmacaoModel();
        }

        public void InvestirRendaFixa()
        {
            SeleniumProperties.Driver.Navigate().GoToUrl(DayconnectUrl.RendaFixa);
            AgendarRendaFixa();
        }

        private void AgendarRendaFixa()
        {
            _agendarModel.Agendar();
            var dataAgendamento = DateTime.Now.AddDays(1).ToShortDateString();
            var valorAplicacao = "500000";
            _aplicacaoModel.CriarAgendamentoAplicacao(valorAplicacao, dataAgendamento);
            _aplicacaoModel.Solicitar();
            _confimacaoModel.PreencherSenha(Sistema.Senha);
            //_confimacaoModel.EnviarSenha();
        }

        public void InvestirFundos()
        {
            SeleniumProperties.Driver.Navigate().GoToUrl(DayconnectUrl.Fundos);
            AgendarInvestimentoFundos();
        }

        private void AgendarInvestimentoFundos()
        {
            _agendarModel.Agendar();
            var dataAgendamento = DateTime.Now.AddDays(1).ToShortDateString();
            var valorAplicacao = "500000";
            _aplicacaoModel.CriarAgendamentoAplicacao(valorAplicacao, dataAgendamento);
            _aplicacaoModel.Solicitar();
            _confimacaoModel.PreencherSenha(Sistema.Senha);
            //_confimacaoModel.EnviarSenha();
        }
    }
}
