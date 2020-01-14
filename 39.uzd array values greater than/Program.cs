using System;

namespace _39.uzd_array_values_greater_than
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 68, 7, 12, 56, 33, 1, 90, 4 };

            var x = 0;
            foreach (var number in numbers)
            {
                if (number > 15)
                {
                    x++;
                }
            }

            int[] numbersBig = new int[x];

            var j = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 15)
                {
                    numbersBig[j] = numbers[i];
                    j++;
                }
            }

            foreach (var item in numbersBig)
            {
                Console.WriteLine(item);
            }
        }
    }
}
// Ir dots int tipa masīvs ar sākotnējām vērtībām 4, 68, 7, 12, 56, 33, 1, 90, 4. 
// Ir jāatrod visas vērtības, kuras lielākas par 15 un jāievieto jaunā int tipa masīvā, kura saturs ir jāizvada uz ekrāna.