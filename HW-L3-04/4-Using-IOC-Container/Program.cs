using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Using_IOC_Container
{
    internal class Program
    {
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IProductDataSource, DatabaseDataSource>()
                .AddTransient<IProductDataSource, ApiDataSource>()
                .AddTransient<IProductDataSource, FileDataSource>()
                .AddTransient<DataSourceResolver>()
                .BuildServiceProvider();

            Console.WriteLine("Enter data source type (database/api/file):");
            string input = Console.ReadLine()!.Trim().ToLower();

            try
            {
                var resolver = serviceProvider.GetRequiredService<DataSourceResolver>();
                IProductDataSource source = resolver.GetDataSource(input);
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
        List<string> GetData();
        string SourceType { get; }
    }

    public class DatabaseDataSource : IProductDataSource
    {
        public string SourceType => "database";
        public List<string> GetData() => new() { "Product1 from Database", "Product2 from Database" };
    }

    public class ApiDataSource : IProductDataSource
    {
        public string SourceType => "api";
        public List<string> GetData() => new() { "Product1 from API", "Product2 from API" };
    }

    public class FileDataSource : IProductDataSource
    {
        public string SourceType => "file";
        public List<string> GetData() => new() { "Product1 from File", "Product2 from File" };
    }


    public class DataSourceResolver
    {
        private readonly IEnumerable<IProductDataSource> _dataSources;

        public DataSourceResolver(IEnumerable<IProductDataSource> dataSources)
        {
            _dataSources = dataSources;
        }

        public IProductDataSource GetDataSource(string sourceType)
        {
            foreach (var ds in _dataSources)
            {
                if (ds.SourceType.ToLower() == sourceType.ToLower())
                {
                    return ds; 
                }
            }
            throw new ArgumentException($"Unknown data source: {sourceType}");
        }
    }


    class ProductDisplay
    {
        private readonly IProductDataSource _dataSource;

        public ProductDisplay(IProductDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void ShowProducts()
        {
            foreach (var product in _dataSource.GetData())
            {
                Console.WriteLine(product);
            }
        }
    }
}