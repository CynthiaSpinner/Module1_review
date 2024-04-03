namespace review1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of your circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of your circle is: " + AreaOfCircle(radius));

            Console.WriteLine("Hit Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter the base length of the triangle: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of a triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of a triangle is: " + AreaOfTriangle(baseLength, height));

            Console.WriteLine("Hit Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter the height of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of your rectangle is " + AreaOfRectangle(length, width));

            Console.WriteLine("Hit Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter the size of a side of your square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of your square is: " + AreaOfSquare(side);

        }

        public static double AreaOfCircle(double radius)
        {

            return Math.PI * radius * radius;
        }

        public static double AreaOfTriangle(double baseLength, double height)
        {

            return (baseLength * height) / 2;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public static double AreaOfSquare(double side)
        {
            return side * side;
        }
    }
    }
}
