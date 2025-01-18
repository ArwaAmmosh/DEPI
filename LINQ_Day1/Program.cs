namespace LINQ_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = [1,2,3,6,5,7,8,9,10,12];
            var result= list.Condition(args => args %2 ==0);
            foreach(int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
