using System;
using Xunit;
using Restaurantes.Classes;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int quantidade = 0;
bool quantidade_valida = quantidade <= 0 ? false : true;
Assert.False(quantidade_valida, "A quantidade não é válida!");
Ingrediente teste = new Ingrediente("Teste", quantidade);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)];
        [InlineData(1)];
        public void Test2(int valor)
        {
            bool quantidade_valida = valor <= 0 ? false : true;
            Assert.False(quantidade_valida, "Quantidade inválida para criar ingrediente!");
            Ingrediente teste = new Ingrediente("Teste", valor);
        }
    }
}
