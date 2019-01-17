using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesProject.ExercisesRemake
{
    class CaesarCipher
    {
        public static void Run()
        {
            var text = "My secret text for Caesar";
            Console.WriteLine($"text: {text}");

            Console.WriteLine();

            var cipher = Cipher(text, 12);
            Console.WriteLine($"cipher: {cipher}");
            Console.WriteLine($"decipher: {Decipher(cipher, 12)}");

            Console.ReadKey();
        }

        private static string Cipher( string text, int shift )
        {
            var result = string.Empty;

            var firstCharCode = 'A';
            var offset = ('z' - 'A') + 1;

            foreach ( var c in text )
            {
                var newChar = ' ';

                if ( c != ' ' )
                {
                    var oldIdxInAlphabet = c - firstCharCode;

                    var idxShifted = oldIdxInAlphabet + shift;
                    while (idxShifted < 0) idxShifted = offset + idxShifted;

                    var newIdxInAlphabet = idxShifted % offset;

                    newChar = (char)(firstCharCode + newIdxInAlphabet);
                }

                result += newChar;
            }

            return result;
        }

        private static string Decipher( string text, int shift )
        {
            return Cipher(text, shift * -1);
        }
    }
}
