

using IoC;

var ProductService = new Service(new OracleDAL());

ProductService.GetAllProducts().ForEach(x => Console.WriteLine(x.Name));