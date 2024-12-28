
namespace StackImplement
{
    public static class StackImplement
    {
      public static  int[] arr =new int[2];
      public static int[] arr2 ;
      public static int[] arr3 ;
      public static int index=0;
      public static void Add(int num)
        {
            
            if (index < 2)
            {
                arr[index] = num;
                index++;
            }
            else if (index == 2)
            {
                arr2 = new int[index + 1];
                Array.Copy(arr, arr2, arr.Length);
                arr2[index] = num;
                index++;
            }
            else
            {
                arr3 = new int[arr2.Length];
                Array.Copy(arr2, arr3, arr2.Length);
                arr2=new int[index+1];
                Array.Copy(arr3, arr2, arr3.Length);
                arr2[index] = num;
                index++;

            }
        }
        
        public static void print() 
        {
            if (index == 2)
            {
                for (int i = index - 1; i >= 0; i--)
                {
                    Console.WriteLine($"Number:{arr[i]}");
                }
            }
            else
            {
                for (int i = index-1; i >= 0; i--)
                {
                    Console.WriteLine($"Number:{arr2[i]}");
                }
            }

        } 

    }
}
