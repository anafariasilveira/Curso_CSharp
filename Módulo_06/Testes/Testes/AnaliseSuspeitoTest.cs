using Classes;

namespace Testes
{
    public class AnaliseSuspeitoTest
    {
        [Theory(DisplayName = "0 ou 1 resposta positiva")]
        [InlineData(false, false, false, false, false)]
        [InlineData(true, false, false, false, false)]
        [InlineData(false, true, false, false, false)]
        [InlineData(false, false, true, false, false)]
        [InlineData(false, false, false, true, false)]
        [InlineData(false, false, false, false, true)]
        public void AnaliseSuspeito_ZeroOuUmaRespostasPositivas_RetornaInocente(bool telefonouVitima, bool esteveNoLocal, bool moraPerto, bool devedor, bool trabalhaComVitima)
        {
            AnaliseSuspeitos suspeitos = new();

            var respostas = suspeitos.ExecutarQuestionarioSuspeito(telefonouVitima, esteveNoLocal, moraPerto, devedor, trabalhaComVitima);

            Assert.Equal("Inocente", respostas);
        }
        [Theory(DisplayName = "2 respostas positiva")]
        [InlineData(true, true, false, false, false)]
        [InlineData(false, true, true, false, false)]
        [InlineData(false, false, true, true, false)]
        [InlineData(false, false, false, true, true)]
        [InlineData(true, false, true, false, false)]
        [InlineData(true, false, false, true, false)]
        [InlineData(true, false, false, false, true)]
        [InlineData(false, true, false, true, false)]
        [InlineData(false, true, false, false, true)]
        [InlineData(false, false, true, false, true)]
        public void AnaliseSuspeito_DuasRespostasPositivas_RetornaSuspeita(bool telefonouVitima, bool esteveNoLocal, bool moraPerto, bool devedor, bool trabalhaComVitima)
        {
            AnaliseSuspeitos suspeitos = new();

            var respostas = suspeitos.ExecutarQuestionarioSuspeito(telefonouVitima, esteveNoLocal, moraPerto, devedor, trabalhaComVitima);

            Assert.Equal("Suspeita", respostas);
        }
        [Theory(DisplayName = "3 ou 4 respostas positiva")]
        [InlineData(true, true, true, false, false)]
        [InlineData(false, true, true, true, false)]
        [InlineData(false, false, true, true, true)]
        [InlineData(true, false, true, true, false)]
        [InlineData(true, false, false, true, true)]
        [InlineData(false, true, false, true, true)]
        [InlineData(false, true, true, true, true)]
        [InlineData(true, true, true, true, false)]
        [InlineData(true, false, true, true, true)]
        [InlineData(true, true, false, true, true)]
        [InlineData(true, true, true, false, true)]
        public void AnaliseSuspeito_TresOuQuatroRespostasPositivas_RetornaCumplice(bool telefonouVitima, bool esteveNoLocal, bool moraPerto, bool devedor, bool trabalhaComVitima)
        {
            AnaliseSuspeitos suspeitos = new();

            var respostas = suspeitos.ExecutarQuestionarioSuspeito(telefonouVitima, esteveNoLocal, moraPerto, devedor, trabalhaComVitima);

            Assert.Equal("Cúmplice", respostas);
        }
        [Theory(DisplayName = "5 respostas positiva")]
        [InlineData(true, true, true, true, true)]
        public void AnaliseSuspeito_CincoRespostasPositivas_RetornaCumplice(bool telefonouVitima, bool esteveNoLocal, bool moraPerto, bool devedor, bool trabalhaComVitima)
        {
            AnaliseSuspeitos suspeitos = new();

            var respostas = suspeitos.ExecutarQuestionarioSuspeito(telefonouVitima, esteveNoLocal, moraPerto, devedor, trabalhaComVitima);

            Assert.Equal("Assassino", respostas);
        }
    }
}