using Classes;

namespace Testes
{
    public class FuncionarioTest
    {
        /* [Fact(DisplayName = "Salário acima de 7998")]   => DisplayName vai mudar o nome que aparece nos testes. Pode ser usado no Fact tbm.
         public void DefinirNivelProfissional_SalariosVariados_RetornaNivelProfissional()
        {
            List<decimal> salarios = new()
            {
                0, 1500, 1998, 1999, 5000, 7998, 7999, 8000 
            };
           /foreach (decimal salario in salarios)
            {
                Funcionario funcionario = new("Ana", salario);

                if (salario < 1999)
                    Assert.Equal("Junior", funcionario.NivelProfissional);
                else if (salario < 7999)
                    Assert.Equal("Pleno", funcionario.NivelProfissional);
                else
                    Assert.Equal("Senior", funcionario.NivelProfissional);
            }  * Esta forma de se fazer não é uma boa pratica, pois os testes unitários não devem conter "inteligência".
               * Podem passar erros que os testes não pegam, e se for refatorar, vai ficar dificil de achar o erro.
        }*/

        // Se eu usar o Theory, eu preciso passar o InlineData, e ele pode ter mais de um parâmetro.
        [Theory]
        [InlineData(0)]
        [InlineData(1500)]
        [InlineData(1998)]
        [Trait("DefinirNivelProfissional", "ProfissionalJunior")]
        public void DefinirNivelProfissional_SalarioAbaixoDe1999_RetornaNivelProfissionalJunior(decimal salario)
        {
            Funcionario funcionario = new("Ana", salario);

            Assert.Equal("Junior", funcionario.NivelProfissional);
        }
        [Theory]
        [InlineData(1999)]
        [InlineData(5000)]
        [InlineData(7998)]
        [Trait("DefinirNivelProfissional", "ProfissionalPleno")]
        public void DefinirNivelProfissional_SalarioAbaixoDe7999_RetornaNivelProfissionalPleno(decimal salario)
        {
            Funcionario funcionario = new("Ana", salario);

            Assert.Equal("Pleno", funcionario.NivelProfissional);
        }
        [Theory]
        [InlineData(7999)]
        [InlineData(10000)]
        [Trait("DefinirNivelProfissional", "ProfissionalSenior")]
        public void DefinirNivelProfissional_SalarioAcimaDe7998_RetornaNivelProfissionalSenior(decimal salario)
        {
            Funcionario funcionario = new("Ana", salario);

            Assert.Equal("Senior", funcionario.NivelProfissional);
        }
    }
}