using testarskit.Mock.Entities;
using testarskit.Mock.Interfaces;

namespace testarskit.Repositories;

public class ProductService(IProductService repo)
{
    public IEnumerable<Product> GetAllProducts()
    {
        var products = repo.GetAllProducts();

        return products;
    }
    Product GetProductById(int id)
    {
        var product = repo.GetProductById(id);

        return product;
    }
    void AddProduct(Product product)
    {
        repo.AddProduct(product);
    }
    void UpdateProduct(Product product)
    {
        repo.UpdateProduct(product);
    }
    void DeleteProduct(int id)
    {
        repo.DeleteProduct(id);
    }
}