using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication4
{
    class Decoder
    {
        private const char CHAR_A = 'A';
        private const char CHAR_a = 'a';
        private const char CHAR_C = 'C';
        private const char CHAR_c = 'c';
        private const char CHAR_D = 'D';
        private const char CHAR_d = 'd';
        private const char CHAR_E = 'E';
        private const char CHAR_e = 'e';
        private const char CHAR_F = 'F';
        private const char CHAR_f = 'f';
        private const char CHAR_G = 'G';
        private const char CHAR_g = 'g';
        private const char CHAR_SPACE = ' ';
        private const char CHAR_EXCLAMATION = '!';
        private const char CHAR_COMMA = ',';
        private const char CHAR_POINT_COMMA = ';';
        private const char CHAR_POINT = '.';
        private const char CHAR_INTERROGATION = '?';
        private const char CHAR_O = 'O';
        private const char CHAR_o = 'o';
        private const char CHAR_I = 'I';
        private const char CHAR_i = 'i';
        private const char CHAR_U = 'U';
        private const char CHAR_u = 'u';



        private string text;

        public string getText()
        {
            return text;
        }

        public void setText(string text)
        {
            this.text = text;
        }

        private void decodeText(string text)
        {
            int i;
            for (i = 0; i < text.Length; i++)
            {
                decodeChar(text[i]);
            }
        }

        private void decodeChar(char charactereToBeDecoded)
        {
            if (Char.IsDigit(charactereToBeDecoded))
            {
                int number = Convert.ToInt32(new string(charactereToBeDecoded, 1));
                if (isPowerOfTwo(number))
                {

                }
                else
                {

                }
            }
            else
            {

                if (Char.IsLetter(charactereToBeDecoded))
                {

                }
            }
            
        }

        private bool isPowerOfTwo(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
