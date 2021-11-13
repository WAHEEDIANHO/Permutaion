using System;
using System.Collections.Generic;

namespace Permutation
{
    class Permutation
    {
        //Factorial
        static public int Factorial(int n)
        {
            if (n == 1) return 1;
            else return n * Factorial(n - 1);
        }

        //Count word repeated more than once
        static public List<int> Counter(string test_string)
        {
            List<int> repeated = new List<int>();
            char[] split_test_string = test_string.ToCharArray();
            
            Dictionary<string, int> word_count = new Dictionary<string, int>();

            foreach (var item in split_test_string)
            {
                if (word_count.ContainsKey(item.ToString()))
                    word_count[item.ToString()] += 1;
                else word_count.Add(item.ToString(), 1);
            }

            foreach (var item in word_count.Values)
            {
                if (item > 1) repeated.Add(item);
                else continue;
            }

            return repeated;
        }


        static void Main(string[] args)
        {
            string text = "babatunde";


            List <int> repeated = Counter(text);

            //setting the factorial of the repeated letter
            repeated.ForEach(x => Factorial(x));

            //Calculating the total repeated factorial
            int total_repeated_fact = 1;
            foreach (var item in repeated)
            {
                total_repeated_fact *= Factorial(item);
            }

            Console.WriteLine(total_repeated_fact);

            //permutation
            int permutation = Factorial(text.Length) / total_repeated_fact;
            Console.WriteLine(permutation);
        }
    }
}
