namespace IoC;

public class DAL : IDAL
{
    public List<Product> GetProducts()
    {
        return new List<Product>()
        {
            new Product {Id= 1, Name = "P1", Stock = 123},
            new Product {Id= 2, Name = "P2", Stock = 123},
            new Product {Id= 3, Name = "P3", Stock = 123},
        };
    }

    public int Calculate()
    {
        return 100;
    }
}