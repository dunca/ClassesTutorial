using System;

namespace ClassesTutorial
{
    class FizzBuzz
    {
        public static string GetFizzBuzz(int receivedNumber)
        {
            if (receivedNumber % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (receivedNumber % 5 == 0)
            {
                return "Buzz";
            }
            else if (receivedNumber % 3 == 0)
            {
                return "Fizz";
            }
            return receivedNumber.ToString();
        }
    }
}
