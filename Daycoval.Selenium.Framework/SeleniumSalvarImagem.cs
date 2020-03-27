using OpenQA.Selenium;
using System;
using System.IO;
using System.Text;

namespace Daycoval.Selenium.Framework
{
    public static class SeleniumSalvarImagem
    {
        public static void SalvarImagemBotao(this IWebElement elemento, string nomeBotao)
        {
            var filePath = new StringBuilder();
            filePath.AppendFormat("{0}/{1}.jpg", Parametros.DirImagens, nomeBotao);

            var imagemBase64 = elemento.GetAttribute("src");

            imagemBase64 = imagemBase64.Split(',')[1];

            byte[] imageBytes = Convert.FromBase64String(imagemBase64);

            using (var imageFile = new FileStream(filePath.ToString(), FileMode.Create))
            {
                imageFile.Write(imageBytes, 0, imageBytes.Length);
                imageFile.Flush();
            }
        }
    }
}