namespace LINQ_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = [1,2,3,6,5,7,8,9,10,5,50,2,3,12];
            var result= list.Condition(args => args %2 ==0);
            foreach(int item in result)
            {
                Console.WriteLine(item);
            }
            var result2 = list.FirstMatch(args => args % 2 == 0);
            Console.WriteLine(result2);
            var result3 =list.FirstOrDefaultMatch(args => args % 20 == 0);
            Console.WriteLine(result3);
            var result4 =list.SingleOrDefaultMatch(args => args % 20 == 0);
            Console.WriteLine(result3);
            var list2 = list.OrderBY((a,b)=>a>b);
            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }
            var result5=list.LastOrDefaultMatch(args=> args % 2 == 0);
            Console.WriteLine(result5);
            var list3 = list.Distinct();
            foreach (int item in list3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
