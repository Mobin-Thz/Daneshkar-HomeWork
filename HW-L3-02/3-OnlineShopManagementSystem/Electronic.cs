
namespace _3_OnlineShopManagementSystem
{
    internal partial class Program
    {
        class Electronic : Product, Idiscountable,IEmailSender,IRecieptBuilder
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

   