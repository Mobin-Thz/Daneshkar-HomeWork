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
            LG_monitor.ApplyDiscount(discountPercentage: 10);

            Console.WriteLine();

            Clothing coat = new Clothing(
                name:"coat",
                price: 1000,
                size: "XL",
                material: "jeans"
                );

            coat.GetProductDetail();
            coat.ApplyDiscount(discountPercentage:30);

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
                this.Name = name;
                this.Price = price;
                this.WarrantyPeriod = warrantyperiod;
            }

            public override void GetProductDetail()
            {
                base.GetProductDetail();
                Console.WriteLine($" WarrantyPeriod: {this.WarrantyPeriod}");

            }


            public void ApplyDiscount(float discountPercentage)
            {
                float discountAmount = (discountPercentage / 100) * this.Price;
                float finalPrice = this.Price - discountAmount;
                Console.WriteLine($"The final price is {finalPrice}.\n");
            }


        }


        class Clothing : Product, Idiscountable
        {
            public string Size { get; set; }
            public string Material { get; set; }

            public Clothing(string name, int price, string size, string material) : base(name, price)
            {
                this.Name = name;
                this.Price = price;
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

            public void ApplyDiscount(float discountPercentage)
            {
                float discountAmount = (discountPercentage / 100) * this.Price;
                float finalPrice = this.Price - discountAmount;
                Console.WriteLine($"The final price is {finalPrice}.\n");
            }


        }

        interface Idiscountable
        {

            void ApplyDiscount(int discount)
            {
            }
        }
    }
}
