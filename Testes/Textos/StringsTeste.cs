using System;
using Xunit;
using Utilitarios.Textos;

namespace Testes.Texto
{
    public class StringsTeste
    {
        [Fact]
        public void DeveraRemoverAcentuacao()
        {
            Assert.Equal("Sao Joao", "S�o Jo�o".RemoveAcentuacao());
        }
        [Fact]
        public void QuandoStringForVaziaRetornarVazia()
        {
            Assert.Equal("", "".RemoveAcentuacao());
        }
    }
}
