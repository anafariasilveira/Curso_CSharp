using NSubstitute;
using Classes.CartDiscount;

namespace Testes.CartDiscountTest
{
    public class CartServiceTest
    {
        private readonly IDiscountService _mockdiscountService;
        private CartService _sut;

        public CartServiceTest()
        {
            _mockdiscountService = Substitute.For<IDiscountService>();
            _sut = new(_mockdiscountService);
        }
        [Fact]
        public void CalculateTotalWithDiscount_CalculaComDesconto_RetornaTotal()
        {
            
            var items = new List<CartItem>
            {
                new CartItem { ProductId = "01", Price = 15 },
                new CartItem { ProductId = "02", Price = 25 }
            };

            _mockdiscountService.CalculateDiscount(items).Returns(5);

          
            double resultado = _sut.CalculateTotalWithDiscount(items);

           
            Assert.Equal(35, resultado);
        }
        [Fact]
        public void CalculateTotalWithDiscount_CalculaSemDesconto_RetornarTotal()
        {
            var items = new List<CartItem>
            {
                new CartItem { ProductId = "01", Price = 15 },
                new CartItem { ProductId = "02", Price = 25 }
            };

            _mockdiscountService.CalculateDiscount(items).Returns(0);

            double resultado = _sut.CalculateTotalWithDiscount(items);

            Assert.Equal(40, resultado);
        }
    }
}
