
using System.Diagnostics;

namespace LINQ_Day1
{
    public static class ListExtention
    {
        public static List<int> Condition(this List<int> numbers , Func<int,bool> func)
        {
            List<int> result = new List<int>();
            for(int i=0; i<numbers.Count; i++)
            {
                if (func.Invoke(numbers[i]))
                {
                    result.Add(numbers[i]);
                }
            }
            return result;
        }
    }
}
