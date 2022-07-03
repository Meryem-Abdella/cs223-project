
abstract class shape
{
   public abstract double getarea();


    public abstract double getperimeter();
    

}
class circle : shape
{
    double radius;
    const double pi = 3.14;
    double area,perimeter;

   public circle(double radius)
    {
        this.radius = radius;
    }

    public override double getarea()
    {
        //throw new NotImplementedException()
        area = pi * radius * radius;
        return area;
        

    }

    public override double getperimeter()
    {
        //throw new NotImplementedException();
        perimeter = 2 * pi * radius;
        return perimeter;
        
    }
}
class square : shape
{
    double length,area,perimeter;

   public square(double length)
    {
        this.length= length;
    }
    public override double getarea()
    {
        area = this.length * this.length;
        return area;
        
    }

    public override double getperimeter()
    {
        perimeter = length * 4;
        return perimeter;
    }
}
class triangle : shape
{
    double height, width, side2, side3, area, perimeter;

    public triangle(double height, double width, double side2, double side3)
    {
        this.height = height;
        this.width = width;
        this.side2 = side2;
        this.side3 = side3;
    }
    public override double getarea()
    {
        area = 0.5 * height * width;
        return area;
    }

    public override double getperimeter()
    {

        perimeter = width + side2 + side3;
        return perimeter;
    }
    class program
    {
        public static void Main(string[] args)
        {
            char ansr = 'Y';
            while (ansr == 'Y' || ansr == 'y')
            {
                Console.WriteLine("1.Area and parameter of Circle");
                Console.WriteLine("2.Area and parameter of Square");
                Console.WriteLine("3.Area and parameter of Trianlge");
                Console.WriteLine("Enter Your choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the radius of Circle");
                        double radius = double.Parse(Console.ReadLine());
                        circle c = new circle(radius);
                        Console.WriteLine("The Area is :" + c.getarea());
                        Console.WriteLine("The Perimeter is :" + c.getperimeter());

                        break;
                    case 2:
                        Console.WriteLine("Enter the lenght of Square");
                        double length = double.Parse(Console.ReadLine());
                        square s = new square(length);
                        Console.WriteLine("The Area is :" + s.getarea());
                        Console.WriteLine("The Perimeter is :" + s.getperimeter());
                        break;
                    case 3:
                        Console.WriteLine("Enter the Height of Triangle");
                        double height = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Width of Square");
                        double width = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the side2 of Triangle");
                        double side2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the side3 of Triangle");
                        double side3 = double.Parse(Console.ReadLine());
                        triangle t = new triangle(height, width, side2, side3);
                        break;
                    default:
                        Console.WriteLine("Error Re-Enter");
                        break;
                }
                Console.WriteLine("Do you want to continue (Y)");
                ansr = Console.ReadLine()[0];
            }




        }
    }
}
