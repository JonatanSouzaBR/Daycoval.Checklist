using System.Text;

namespace Daycoval.Selenium.Framework.Parametros
{
    public static class DayconnectUrl
    {
        public static string Login { get; } = "http://localhost:47396/";
        public static string Home { get => new StringBuilder().Append(Login).Append("Home/Default").ToString(); }
        public static string Sair { get => new StringBuilder().Append(Login).Append("Home/Sair").ToString(); }
        public static string RendaFixa
        {
            get => new StringBuilder().Append(Login)
                .Append("Investimentos/Aplicacao/SolicitaAplicacaoRendaFixa").ToString();
        }
        public static string Fundos
        {
            get => new StringBuilder().Append(Login)
                .Append("Investimentos/Aplicacao/SolicitaAplicacaoRendaFixa").ToString();
        }
        public static string AvisoGeral { get => new StringBuilder().Append(Login).Append("Aviso/AvisoGeral").ToString(); }
    }
}
