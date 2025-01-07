namespace ExtentionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your Name :");
            string text = Console.ReadLine();
            Console.WriteLine(text.AddHelloWorld());
        }
    }
}
