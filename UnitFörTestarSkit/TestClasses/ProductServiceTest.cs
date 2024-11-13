using FakeItEasy;
using Moq;
using testarskit.Mock.Entities;
using testarskit.Mock.Interfaces;
using testarskit.Repositories;

namespace UnitFörTestarSkit.TestClasses;

public class ProductServiceTest
{
    private readonly ProductService _productService;
    private readonly IProductService _mockRepo;

    public ProductServiceTest()
    {
        _mockRepo = A.Fake<IProductService>();
        _productService = new ProductService(_mockRepo);
    }

    [Fact]
    public void GetAllProducts_ShouldReturnAllProducts()
    {
        // Arrange
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 100 },
            new Product { Id = 2, Name = "Product 2", Price = 200 },
            new Product { Id = 3, Name = "Product 3", Price = 300 }
        };

        A.CallTo(() => _mockRepo.GetAllProducts()).Returns(products);

        // Act
        var result = _productService.GetAllProducts();

        // Assert
        Assert.Equal(products, result);
    }


}