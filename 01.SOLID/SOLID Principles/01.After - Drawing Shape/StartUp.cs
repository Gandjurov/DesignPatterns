namespace SingleResponsibilityShapesAfter
{
    using SingleResponsibilityShapesAfter.Contracts;
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());

            IShape rectangleArea = new Rectangle(width, height);
            Console.WriteLine(rectangleArea.Area);
        }
    }
}
