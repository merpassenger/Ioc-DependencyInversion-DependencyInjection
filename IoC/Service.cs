namespace IoC;

public class Service
{
    private readonly IDAL _dal;

    public Service(IDAL dal)
    {
        //_dal = DALFactory.GetDal(); // DALFactory: dal instance i verir
        _dal = dal; //dependency injection ile constructordan aldık
    }

    public List<Product> GetAllProducts()
    {
        //_dal.Calculate();
        return _dal.GetProducts();
    }
    
}