using Classes;

namespace Testes
{
    public class MediaIdadeTest
    {
        [Fact]
        public void CalculaMedia_ListaDeIdadeMaiorQue18_ListaMaior18()
        {
            // Arrange
            MediaIdades idade = new();

            List<int> listaIdade = new()
        {
            18, 20, 35, 13, 07, 23
        };

            // act
            decimal mediaIdades = idade.CalculaMedia(listaIdade);

            Assert.Equal(24, mediaIdades);
        }
        [Fact]
        public void CalculaMedia_IdadesMenorQue18_ListaMenor18()
        {
            MediaIdades idades = new();

            List<int> idadeMenor18 = new()
        {
            07, 12, 15, 05
        };

            Action retorno = () => idades.CalculaMedia(idadeMenor18);

            Assert.Throws<DivideByZeroException>(retorno);
        }
    }
}