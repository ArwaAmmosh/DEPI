
namespace Delegate
{
    public class print
    {
        public static void Print(Func<string,string> place) 
        {
            Console.WriteLine($"Write To {place.Invoke(string.Empty)} : Good Job!");
        }
    }
}
