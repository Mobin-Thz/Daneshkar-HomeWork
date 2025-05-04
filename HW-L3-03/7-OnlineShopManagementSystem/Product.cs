
namespace _3_OnlineShopManagementSystem
{
    internal partial class Program
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public Product(string name, int price)
            {
                this.Name = name;
                this.Price = price;
            }

            public virtual void GetProductDetail()
            {
                Console.WriteLine(" Product Details \n" +
                    $" product: {this.Name} \n" +
                    $" price: {this.Price}");
            }

        }



    }
}

   