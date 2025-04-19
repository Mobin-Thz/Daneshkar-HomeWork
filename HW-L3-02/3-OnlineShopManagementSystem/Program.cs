
namespace _3_OnlineShopManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electronic LG_monitor = new Electronic(
                name: "LG",
                price: 1000,
                warrantyperiod: "3 years"
                );

            LG_monitor.GetProductDetail();
            ((Idiscountable)LG_monitor).ApplyDiscount(discountPercentage: 10);

            Console.WriteLine();

            Clothing coat = new Clothing(
                name:"coat",
                price: 1000,
                size: "XL",
                material: "jeans"
                );

            coat.GetProductDetail();
            ((Idiscountable)coat).ApplyDiscount(discountPercentage: 10);

        }

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


        class Electronic : Product, Idiscountable
        {
            public string WarrantyPeriod { get; set; }

            public Electronic(string name, int price, string warrantyperiod) : base(name, price)
            {
                this.WarrantyPeriod = warrantyperiod;
            }

            public override void GetProductDetail()
            {
                base.GetProductDetail();
                Console.WriteLine($" WarrantyPeriod: {this.WarrantyPeriod}");

            }

        }


        class Clothing : Product, Idiscountable
        {
            public string Size { get; set; }
            public string Material { get; set; }

            public Clothing(string name, int price, string size, string material) : base(name, price)
            {

                this.Size = size;
                this.Material = material;

            }

            public override void GetProductDetail()
            {
                base.GetProductDetail();
                Console.WriteLine(
                    $" Size: {this.Size} \n" +
                    $" Material: {this.Material}");

            }


        }

        interface Idiscountable
        {
            int Price { get; set; }

            public void ApplyDiscount(float discountPercentage)
            {
                if (discountPercentage < 0 || discountPercentage >= 100)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    float discountAmount = (discountPercentage / 100) * Price;
                    float finalPrice = Price - discountAmount;
                    Console.WriteLine($"The final price is {finalPrice}.\n");

                }
            }
        }
    }
}
