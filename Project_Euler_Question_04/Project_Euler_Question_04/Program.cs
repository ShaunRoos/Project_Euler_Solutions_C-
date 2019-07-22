using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Question_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> palindrome = new List<int>();
            int value;
            char[] revpalindrome;

            for(int i = 999; i > 99; i--)
            {
                for(int j = 999; j > 99; j--)
                {
                    value = i * j;
                    revpalindrome = value.ToString().ToCharArray();
                    Array.Reverse(revpalindrome);

                    if(value == int.Parse(new string(revpalindrome)))
                    {
                        palindrome.Add(value);
                    }
                        
                }
            }
            Console.WriteLine("The largest palindromic number is: " + palindrome.Max());
            Console.ReadLine();
        }
    }
}
