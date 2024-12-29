
namespace StackImplement
{
    public  class StackImplement<T>
    {
      public  T[] arr;
      public  void _Push(T num)
        {
            
            if (arr is null)
            {
                arr=new T[1];
                arr[0] = num;
            }
            else
            {
               T[] arr2 = new T[arr.Length+1];
               Array.Copy(arr, arr2, arr.Length);
                arr2[arr.Length] = num;
                arr = arr2;

            }
        }
        public void _pop()
        {
            if (arr is null)
            {
                Console.WriteLine("The Stack is Empty");
            }
            else 
            {
                Console.WriteLine(arr[arr.Length - 1]);
                T[] arr2 = new T[arr.Length - 1];
                Array.Copy(arr, arr2, arr2.Length);
                arr = arr2;
            }
        }
        public void _peek()
        {
            if (arr is null)
            {
                Console.WriteLine("The Stack is Empty");
            }
            else
            {
                Console.WriteLine(arr[arr.Length - 1]);
            }
        }
        public  void print() 
        {
            
                for (int i = arr.Length-1; i >= 0; i--)
                {
                    Console.WriteLine(arr[i]);
                }
            
        } 

    }
}
