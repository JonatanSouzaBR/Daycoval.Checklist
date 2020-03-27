using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Daycoval.Selenium.Framework
{
    public static class SeleniumSetMethods
    {
        /// <summary>
        /// Preenche um campo de texto
        /// </summary>
        public static void PreencherTexto(this IWebElement elemento, string valor)
        {
            elemento.SendKeys(valor);

        }

        /// <summary>
        /// Clica em um objeto da tela
        /// </summary>
        public static void Clicar(this IWebElement elemento)
        {
            elemento.Click();
        }

        /// <summary>
        /// Seleciona um ítem do combo
        /// </summary>
        public static void SelecionarCombo(this IWebElement elemento, string valor)
        {
            new SelectElement(elemento).SelectByText(valor);
        }
    }
}
