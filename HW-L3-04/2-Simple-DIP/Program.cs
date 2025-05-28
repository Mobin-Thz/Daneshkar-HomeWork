namespace _2_Simple_DIP
{
    internal class Program
    {
        static void Main()
        {
            IProductDataSource dataSource = new IDatabase();

            var display = new ProductDisplay(dataSource);
            display.ShowProducts();

        }

    }

    interface IProductDataSource
    {

        List<string> GetData();
    }


    public class Database : IProductDataSource
    {
        public List<string> GetData()
        {
            return new List<string> {"Product1 from Database" ,
                                    "Product2 from Database" };
        }
    }

    public class Api : IProductDataSource
    {
        public List<string> GetData()
        {
            return new List<string> { "Product1 from API",
                                      "Product2 from Database"};
  
        }
    }

    public class File : IProductDataSource
    {
        public List<string> GetData()
        {
            return new List<string> { "Product1 from File",
                                      "Product2 from File" };
        }
    }

    class ProductDisplay
    {
        private IProductDataSource _dataSource;

        public ProductDisplay(IProductDataSource dataSource)
        {  
            _dataSource = dataSource;
        }

        public void ShowProducts()
        {
            var products = _dataSource.GetData();
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }


}
