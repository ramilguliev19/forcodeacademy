using System;

namespace Method

{

    class Program

    {

        static void  Main()

        {

            int sum = 0;

            for (int i = 1; i < 100; i++)

            {

                if (divides(i, 5, 3))

                {

                    sum += i;

                }

            }

            Console.WriteLine(sum);

        }

        static bool divides(int number, int number1, int number2)
    {

            if (number % 3 == 0 && number % 5 == 0)

            {

                return true;

            }
            

            return false;

        }

    }
}