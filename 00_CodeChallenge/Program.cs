using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = "Supercalifragilisticexpialidocious".ToCharArray();
            int characterCount = characters.Length;
            int eyeCount = 0;
            int elleCount = 0;

            Console.WriteLine($"there are {characterCount} letters in this word");
            foreach (char c in characters)
            {
                if (c == 'i')
                {
                    Console.WriteLine("this is an I");
                    eyeCount++;
                }
                else if (c == 'l')
                {
                    Console.WriteLine("this is an L");
                    elleCount++;
                }
                else
                {
                    Console.WriteLine("this is not an L or an I");
                }
                //Console.WriteLine($"character: {c}");
            }

            Console.WriteLine($"There are {eyeCount} 'I's and {elleCount} 'L's");

            Console.ReadKey();
           
        }
    }
}
