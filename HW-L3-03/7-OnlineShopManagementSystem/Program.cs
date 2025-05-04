
namespace _3_OnlineShopManagementSystem
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Electronic LG_monitor = new Electronic(
                name: "LG",
                price: 1000,
                warrantyperiod: "3 years"
                );

            LG_monitor.GetProductDetail();
            (LG_monitor).ApplyDiscount(discountPercentage: 10);

            Console.WriteLine();

            Clothing coat = new Clothing(
                name:"coat",
                price: 1000,
                size: "XL",
                material: "jeans"
                );

            coat.GetProductDetail();
            (coat).ApplyDiscount(discountPercentage: 10);

        }

    }
}

   