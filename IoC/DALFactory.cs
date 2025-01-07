namespace IoC;

public class DALFactory
{
    public static IDAL GetDal()
    {
        return new DAL();
    }
}