namespace _2_OCP
{
    internal class Program
    {
/// <summary>
///  این اصل میگه باید بتونیم فانکشنالیتی های جدید و نیاز های جدید رو اضافه کنیم به کدمون 
///  بدون اینکه کد های قبلیمون تاثیری ببینن
///  یعنی برای توسعه باز وبرای تغییر بسته باشه
///  این اصل به تمیزی و مقیاس پذیزی کدمون کمک میکنه
/// </summary>


        static void Main(string[] args)
        {


        }



        //Wrong Approach 

        //public class ShapeCalculator
        //{
        //    public double CalculateArea(object shape)
        //    {
        //        if (shape is Circle circle)
        //        {
        //            return Math.PI * circle.Radius * circle.Radius;
        //        }
        //        else if (shape is Rectangle rectangle)
        //        {
        //            return rectangle.Width * rectangle.Height;
        //        }
        //        throw new ArgumentException("Unsupported shape");
        //    }
        //}

        //public class Circle
        //{
        //    public double Radius { get; set; }
        //}

        //public class Rectangle
        //{
        //    public double Width { get; set; }
        //    public double Height { get; set; }
        //}

        //--------------------------------------------------------------------------------------------------------------

        //Correct Approach

        public interface IShape
        {
            double CalculateArea();
        }

        public class Circle : IShape
        {
            public double Radius { get; set; }

            public double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class Rectangle : IShape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public double CalculateArea()
            {
                return Width * Height;
            }
        }







    }
}
