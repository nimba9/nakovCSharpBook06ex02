using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovCSharpBook06ex02
{
    class NotDivisBy3and7Printing
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive number you want to check counting from 1 -> ");
            string userInp = Console.ReadLine();

            CheckInput(userInp);

        }

        private static void CheckInput(string userInp)
        {
            uint num = 0;
            bool checkValue = uint.TryParse(userInp, out num);

            if (checkValue)
                for (int i = 1; i <= num; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        Console.Write(i);

                        if (i < num)
                        {
                            Console.Write(", ");
                        }

                    }

                }

            else
            { Console.WriteLine("Please enter a positive integer"); };
        }
    }

}
