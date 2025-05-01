namespace _1_SRP
{
    //   استفاده نکردن از این اصل باعث وابسته شدن کد ها به هم میشه و ارث بری بی فایده و اضافی توسط فرزندان

    internal class Program
    {
        

        static void Main(string[] args)
        {


        }


        //Wrong Approach


        //public class User
        //{
        //    public string name {  get; set; }
        //    public string password { get; set; }

        //    public User() { }

        //    public void UserSendEmail() { }


        //    public void UserSendSms() { }

        //    public void UserSaveToDatabase() { }
        //}
    //-------------------------------------------------------------------------------------------------------------------------------------


    // Correct Approach

        public class User
        {
            public string name { get; set; }
            public string password { get; set; }

            public User() { }
        }


        public class UserRepo
        {
            public void UserSaveToDatabase() { }


        }

        public class UserEmailSender
        {
            public void UserSendEmail() { }
        }
    }



}
