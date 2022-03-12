using System;

namespace Method

{

    class Program

    {

        static void Main()

        {

            int sum = 0;

            for (int i = 1; i < 100; i++)

            {

                if (numbers(i, 5, 3))

                {

                    sum += i;

                }

            }

            Console.WriteLine(sum);

        }

        static bool numbers(int number, int number1, int number2)
    {

            if (number % 3 == 0 && number % 5 == 0)

            {

                return true;

            }
            else

            return false;

        }

    }
}