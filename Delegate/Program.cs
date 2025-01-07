namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Place To Write Over :");
            string? place = Console.ReadLine();
            print.Print(a => place);
        }
    }
}
