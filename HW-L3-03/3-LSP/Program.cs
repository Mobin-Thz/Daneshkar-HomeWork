namespace _3_LSP
{
    internal class Program
    {
        /// <summary>
        /// این اصل میگوید فرزندان باید بتوانن جایکزین پدر خود شوند
        /// </summary>

        static void Main(string[] args)
        {
        }


        //Wrong Approach




        //class Bird
        //{
        //    void Fly() { }

        //    void Swim() { }

        //}

        //class Penguin:Bird
        //{
        //    void Fly()
        //    {
        //        Console.WriteLine("Penguin cannot fly!");
        //    }

        //    void Swim()
        //    {
        //        Console.WriteLine("Penguin swims");
        //    }
        //}

        //class Eagle: Bird
        //{
        //    void Fly()
        //    {
        //        Console.WriteLine("Eagle flies");
        //    }

        //    void Swim()
        //    {
        //        Console.WriteLine("Eagle cannot swim!");
        //    }
        //}

        //پس فرزندان نمیتوانند جایگزین پدر خود شوند چون تمام ویژگی های ان را ندارند 






        //------------------------------------------------------------------------------------------------------------------------




        // Correct Approach 

        interface IFlyingBird
        {
            void Fly();
        }

        interface ISwimmingBird
        {
            void Swim();
        }

        class Eagle : IFlyingBird
        {
            public void Fly()
            {
                Console.WriteLine("Eagle Flies");
            }
        }

        class Penguin : ISwimmingBird
        {
            public void Swim()
            {
                Console.WriteLine("Penguin Swimss");
            }
        }
    }


}
