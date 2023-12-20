using Classes.ClienteDiscount;
using NSubstitute;

namespace Testes.ClientDiscountTest
{
    public class DiscountServiceTest
    {
        private readonly ICustomerService _mockCustomerService;
        private DiscountService _sut;

        public DiscountServiceTest()
        {
            _mockCustomerService = Substitute.For<ICustomerService>();
            _sut = new(_mockCustomerService);
        }
        [Fact]
        public void GetDiscount_ClienteRegular_RetornaDescontoDe5PorCento()
        {
            _mockCustomerService.GetCustomerType(1).Returns(CustomerType.Regular);

            double resultado = _sut.GetDiscount(1, 100);

            Assert.Equal(5, resultado);
        }
        [Fact]
        public void GetDiscount_ClientePremium_RetornaDescontoDe10PorCento()
        {
            _mockCustomerService.GetCustomerType(2).Returns(CustomerType.Premium);

            double resultado = _sut.GetDiscount(2, 100);

            Assert.Equal(10, resultado);
        }
        [Fact]
        public void GetDiscount_Default_RetornaSemDesconto()
        {
            _mockCustomerService.GetCustomerType(3).Returns(CustomerType.NotClient);

            double resultado = _sut.GetDiscount(3, 100);

            Assert.Equal(0, resultado);
        }
    }
}