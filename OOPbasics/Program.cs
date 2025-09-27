namespace OOPbasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Circle C1 = new Circle(5);

            Circle C2 = new Circle(6);

            C1.GetArea();
            C2.GetArea();
        }
    }
}
