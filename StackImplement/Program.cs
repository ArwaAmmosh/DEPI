using System.ComponentModel;

namespace StackImplement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter -1 to exist loop");
            StackImplement<int> stackImplement = new StackImplement<int>();
            while (true)
            {
                Console.Write("Enter Number: ");
                int num=int.Parse(Console.ReadLine());
               
                if (num == -1)
                   break;
                else
                {
                   
                   stackImplement._Push(num);

                }
            }
            stackImplement.print();
            stackImplement._pop();
            stackImplement._peek();
            stackImplement._pop();
            stackImplement._peek();

        }
    }
}
