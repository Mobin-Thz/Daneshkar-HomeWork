
namespace solid_isp
{
    using System;

    // این اصل میگوید تا حد امکان از اینترفیس ها با ویژگی های تفکیک شده استفاده کنیم

    // ISP : Interface Segregation Principle

    // without using ISP



    //public interface IAnimal
    //{
    //    void Walk();
    //    void Fly();
    //    void Swim();
    //}

    //public class Dog : IAnimal
    //{
    //    public void Walk()
    //    {
    //        Console.WriteLine("The dog is walking in the park.");
    //    }

    //    public void Fly()
    //    {
    //        Console.WriteLine("The dog cannot fly!");
    //    }

    //    public void Swim()
    //    {
    //        Console.WriteLine("The dog is swimming in the pond.");
    //    }
    //}

    //public class Eagle : IAnimal
    //{
    //    public void Walk()
    //    {
    //        Console.WriteLine("The eagle is walking on its perch.");
    //    }

    //    public void Fly()
    //    {
    //        Console.WriteLine("The eagle is soaring in the sky.");
    //    }

    //    public void Swim()
    //    {
    //        Console.WriteLine("The eagle cannot swim!");
    //    }
    //}

    //public class Dolphin : IAnimal
    //{
    //    public void Walk()
    //    {
    //        Console.WriteLine("Dolphins cannot walk on land.");
    //    }

    //    public void Fly()
    //    {
    //        Console.WriteLine("Dolphins cannot fly.");
    //    }

    //    public void Swim()
    //    {
    //        Console.WriteLine("The dolphin is swimming gracefully in the ocean.");
    //    }
    //}

    //public class Platypus : IAnimal
    //{
    //    public void Walk()
    //    {
    //        Console.WriteLine("The platypus is waddling along the river bank.");
    //    }

    //    public void Fly()
    //    {
    //        Console.WriteLine("The platypus cannot fly.");
    //    }

    //    public void Swim()
    //    {
    //        Console.WriteLine("The platypus is swimming in the river.");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IAnimal dog = new Dog();
    //        dog.Walk();
    //        dog.Fly();
    //        dog.Swim();

    //        Console.WriteLine();

    //        IAnimal eagle = new Eagle();
    //        eagle.Walk();
    //        eagle.Fly();
    //        eagle.Swim();

    //        Console.WriteLine(); 

    //        IAnimal dolphin = new Dolphin();
    //        dolphin.Walk();
    //        dolphin.Fly();
    //        dolphin.Swim();

    //        Console.WriteLine(); 

    //        IAnimal platypus = new Platypus();
    //        platypus.Walk();
    //        platypus.Fly();
    //        platypus.Swim();

    //    }
    //}



    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    // with using ISP
    public interface IWalker
    {
        void Walk();
    }

    public interface IFlyer
    {
        void Fly();
    }

    public interface ISwimmer
    {
        void Swim();
    }

    public class Dog : IWalker
    {
        public void Walk()
        {
            Console.WriteLine("The dog is walking in the park.");
        }
    }






    public class Eagle : IWalker, IFlyer
    {
        public void Walk()
        {
            Console.WriteLine("The eagle is walking along its perch.");
        }

        public void Fly()
        {
            Console.WriteLine("The eagle is flying high in the sky.");
        }
    }

    public class Dolphin : ISwimmer
    {
        public void Swim()
        {
            Console.WriteLine("The dolphin is swimming gracefully in the ocean.");
        }
    }

    public class Platypus : IWalker, ISwimmer
    {
        public void Walk()
        {
            Console.WriteLine("The platypus is waddling on the river bank.");
        }

        public void Swim()
        {
            Console.WriteLine("The platypus is swimming in the river.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IWalker dog = new Dog();
            dog.Walk();

            Eagle eagle = new Eagle();
            eagle.Walk();
            eagle.Fly();

            ISwimmer dolphin = new Dolphin();
            dolphin.Swim();

            Platypus platypus = new Platypus();
            platypus.Walk();
            platypus.Swim();

        }
    }






}

