namespace _5_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
        //این اصل میگوید سیستم های نرم افزاری زمانی انعطاف پذیر و کم هزینه تر برای تغییر هستند
        //که وابستگی های کد به جای جزئیات پیاده سازی کلاس ها یا ماژولهای عینی  به مفاهیم کلی و انتزاعی اینترفیس ها یا کلاس های انتزاع  اشاره کنند

        //Wrong 

        //public class SQLUserRepo
        //{
        //    public void Save() { }

        //}

        //public class User
        //{
        //    SQLUserRepo SQLUserRepo = new SQLUserRepo();

        //    void SaveUserToDatabase()
        //    {
        //        SQLUserRepo.Save();
        //    }

        //}

        //---------------------------------------------------------------------------------------------
        //Correct approach

        interface IUserRepository
        {
            public void Save();
        }

        class SQLUserRepo : IUserRepository
        {
            public void Save()
            {
                Console.WriteLine("User saved into repository");
            }
        }

        class User
        {
            private IUserRepository userRepository;

            public User(IUserRepository userRepository)
            {
                this.userRepository = userRepository;
            }

            void SaveUserToDatabase()
            {
                userRepository.Save();
            }
        }

    }
}
