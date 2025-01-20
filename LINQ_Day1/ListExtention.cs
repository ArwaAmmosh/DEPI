
using System.Data;
using System.Diagnostics;

namespace LINQ_Day1
{
    public static class ListExtention
    {
        #region Where
        public static List<T> Condition<T>(this List<T> numbers , Func<T,bool> func)
        {
            List<T> result = new List<T>();
            for(int i=0; i<numbers.Count; i++)
            {
                if (func.Invoke(numbers[i]))
                {
                    result.Add(numbers[i]);
                }
            }
            return result;
        }
        #endregion
        #region first
        public static T FirstMatch<T>(this List<T> numbers, Func<T, bool> func)
        {
           
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (func.Invoke(numbers[i]))
                    {
                        return numbers[i];
                    }
                }
            throw new InvalidOperationException("No Matching element found in the list");
        }
        #endregion
        #region first or default
        public static T? FirstOrDefaultMatch<T>(this List<T> numbers, Func<T, bool> func) 
        { 

            for (int i = 0; i < numbers.Count; i++)
            {
                if (func.Invoke(numbers[i]))
                {
                    return numbers[i];
                }
            }
            return default;
        }
        #endregion
        #region single or default
        public static T? SingleOrDefaultMatch<T>(this List<T> numbers, Func<T, bool> func)
        {
            var result = default(T);
            bool found = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (func.Invoke(numbers[i]))
                {
                    if (found)
                        throw new InvalidOperationException("sequence contain more than one element");
                    found = true;
                    result = numbers[i];
                }
            }
            return result;
        }

        #endregion
        #region order by 
        public static List<T> OrderBY<T>(this List<T> numbers,Func<T,T,bool>fun)
        {

            for (int i = 0; i < numbers.Count-1; i++)
            {
                for(int j = i+1; j< numbers.Count; j++)
                {
                    if (fun.Invoke(numbers[i], numbers[j]))
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                        
                    }
                }
                
            }
         return numbers;
        }

        #endregion
        #region distinct
        public static List<T> Distinct<T>(this List<T> numbers)
        {
            HashSet<T> set = new HashSet<T>();
            List<T> list = new List<T>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (set.Add(numbers[i]))
                {
                    list.Add(numbers[i]);
                }
            }
            return list;
        }
        #endregion
        #region Last or default
        public static T? LastOrDefaultMatch<T>(this List<T> numbers, Func<T, bool> func)
        {

            for (int i = numbers.Count-1; i > -1; i--)
            {
                if (func.Invoke(numbers[i]))
                {
                    return numbers[i];
                }
            }
            return default;
        }
        #endregion
    }
}
