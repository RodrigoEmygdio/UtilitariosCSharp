using System;
using System.Text;
using System.Globalization;
namespace Utilitarios.Textos
{
    public static class StringExtension
    {
        public static string RemoveAcentuacao(this string texto)
        {
            StringBuilder textoSemAcentuacao = new StringBuilder();
            foreach(char caracter in texto.Normalize(NormalizationForm.FormD))
            {
                var categoricaUnicode = CharUnicodeInfo.GetUnicodeCategory(caracter);
                if(categoricaUnicode != UnicodeCategory.NonSpacingMark)
                {
                    textoSemAcentuacao.Append(caracter);
                }
            }
            return textoSemAcentuacao.ToString();
        }
    }
}
