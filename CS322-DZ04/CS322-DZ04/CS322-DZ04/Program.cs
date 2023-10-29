// See https://aka.ms/new-console-template for more information

namespace Domaci4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum is:" + Math.sumOfOdds(3));
            Math.task2();

            Console.Write("Enter a number between 1 - 999.999.999: ");
            int task3Input = Convert.ToInt32(Console.ReadLine());
            while (task3Input < 1 || task3Input >999999999){
                Console.WriteLine("Bad input!!!!");
                Console.Write("Enter a number between 1 - 999.999.999: ");
                task3Input = Convert.ToInt32(Console.ReadLine());
            }
           Console.WriteLine("Is the number {0} strictly incremental: [{1}]",task3Input,Math.task3(task3Input));

        }

        internal class Math
        {

            public static int sumOfOdds(int n)
            {
                int sum = 0;
                for (int i = 1; i <= n; sum += i, i += 2) ;
                return sum;
            }

            public static void task2()
            {
                for (int i = 16; i >= 1; Console.WriteLine(i * 2), i--) ;
            }

            public static bool task3(int number){
                string strValue = Convert.ToString(number);
                for (int i = 0;i < strValue.Length-1; i++)
                {
                    if (Convert.ToInt32(strValue[i]) >= Convert.ToInt32(strValue[i + 1]))
                    {
                        return false;
                    }
                }
                return true;
            }

        }

    }
}
