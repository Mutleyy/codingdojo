using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanMMU
{
    class Program
    {
        static void Main(string[] args)
        {
            var hangman = new Hangman("blablabla");
            var result = hangman.Guess('b');

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
