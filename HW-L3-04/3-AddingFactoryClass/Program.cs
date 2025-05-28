namespace _3_AddingFactoryClass
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter data source type (database/api/file):");
            string input = Console.ReadLine()!.Trim().ToLower();

            try
            {
                IProductDataSource source = DataSourceFactory.CreateDataSource(input);
                var display = new ProductDisplay(source);
                display.ShowProducts();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

    }

    public interface IProductDataSource
    {

        public List<string> GetData();
    }


    public class DatabaseDataSource : IProductDataSource
    {
        public List<string> GetData()
        {
            return new List<string> {"Product1 from Database" ,
                                    "Product2 from Database" };
        }
    }

    public class ApiDataSource : IProductDataSource
    {
        public List<string> GetData()
        {
            return new List<string> { "Product1 from API",
                                      "Product2 from Database"};

        }
    }

    public class FileDataSource : IProductDataSource
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



    public static class DataSourceFactory
    {
        public static IProductDataSource CreateDataSource(string sourceType)
        {
            switch (sourceType.ToLower())
            {
                case "database":
                    return new DatabaseDataSource();
                case "api":
                    return new ApiDataSource();
                case "file":
                    return new FileDataSource();
                default:
                    throw new ArgumentException("Invalid data source type");
            }
        }
    }






}
