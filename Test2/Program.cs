namespace Test2
{
    using System;
    using System.Collections.Generic;
    using System;
    using System.Linq;
    class Test2
    {
        
        static public void Main(String[] args)
        {
           
            Console.WriteLine("Accept number:");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is: " + number);
            List<int> primes = new List<int>();
            for (int i = 0; i < number + 1; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
               
                static bool IsPrime(int number)
                {
                    if (number <= 1) return false;
                    if (number == 2) return true;
                    if (number % 2 == 0) return false;

                    var boundary = (int)Math.Floor(Math.Sqrt(number));

                    for (int i = 3; i <= boundary; i += 2)
                        if (number % i == 0)
                            return false;

                    return true;
                }
            }
            Console.WriteLine("Total ammount of primes: " + primes.Count);
            for (int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i] + ", ");
            }
        }
    }
}
      



