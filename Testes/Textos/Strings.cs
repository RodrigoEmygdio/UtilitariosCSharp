using System;
using Xunit;
using Utilitarios.Textos;

namespace Testes.Texto
{
    public class Strings
    {
        [Fact]
        public void DeveraRemoverAcentuacao()
        {
            Assert.Equal("Sao Joao", "São João".RemoveAcentuacao());
        }
    }
}
