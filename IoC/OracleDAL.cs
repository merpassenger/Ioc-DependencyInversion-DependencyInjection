namespace IoC;

public class OracleDAL : IDAL
{
    public List<Product> GetProducts()
    {
        return new List<Product>()
        {
            new Product {Id= 1, Name = "P1oracle", Stock = 123},
            new Product {Id= 2, Name = "P2oracle", Stock = 123},
            new Product {Id= 3, Name = "P3oracle", Stock = 123},
        };
    }
    

    public int Calculate()
    {
        return 1500;
    }
}