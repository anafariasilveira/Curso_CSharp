using Classes.ShippingCost;
using NSubstitute;

namespace Testes.ShippingCostTest
{
    public class ShippingServiceTest
    {
        private readonly IDeliveryCostCalculator _mockDeliveryCostCalculator;
        private ShippingService _sut;

        public ShippingServiceTest()
        {
            _mockDeliveryCostCalculator = Substitute.For<IDeliveryCostCalculator>();
            _sut = new(_mockDeliveryCostCalculator);
        }
        [Fact]
        public void CalculateShippingCost_DeliveryComun_RetornaValorSemDesconto()
        {
            _mockDeliveryCostCalculator.CalculateCost(100, DeliveryType.Ordinary).Returns(10);

            double resultado = _sut.CalculateShippingCost(100, DeliveryType.Ordinary);

            Assert.Equal(10, resultado);
        }
        [Fact]
        public void CalculateShippingCost_DeliveryExpresso_RetornaValorSemDesconto()
        {
            _mockDeliveryCostCalculator.CalculateCost(100, DeliveryType.Express).Returns(10);

            double resultado = _sut.CalculateShippingCost(100, DeliveryType.Express);

            Assert.Equal(10, resultado);
        }
        [Fact]
        public void CalculateShippingCost_DeliveryExpresso_RetornaValorComDesconto()
        {
            _mockDeliveryCostCalculator.CalculateCost(250, DeliveryType.Express).Returns(10);

            double resultado = _sut.CalculateShippingCost(250, DeliveryType.Express);

            Assert.Equal(5, resultado);
        }
    }
}