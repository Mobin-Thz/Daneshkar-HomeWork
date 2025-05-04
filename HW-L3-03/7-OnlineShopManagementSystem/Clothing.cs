
namespace _3_OnlineShopManagementSystem
{
    internal partial class Program
    {
        class Clothing : Product, Idiscountable, IEmailSender, IRecieptBuilder
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

            public void ApplyDiscount(int discountAmount)
            {
                int finalprice = this.Price - discountAmount;
            }


            public void SendEmail(string email) { }


            public void SendReciept() { }


        }



    }
}

   