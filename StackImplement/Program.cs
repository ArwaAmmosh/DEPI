using System.ComponentModel;

namespace StackImplement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter -1 to exist loop");
            while (true)
            {
                Console.Write("Enter Number: ");
                int num=int.Parse(Console.ReadLine());
               
                if (num == -1)
                   break;
                else
                {
                   
                   StackImplement.Add(num);

                }
            }
            StackImplement.print();
        }
    }
}
