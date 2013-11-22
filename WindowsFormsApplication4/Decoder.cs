using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Midi;

namespace WindowsFormsApplication4
{
    class Decoder
    {
        private const char LA_A = 'A';
        private const char LA_a = 'a';
        private const char SI_b = 'b';
        private const char SI_B = 'B';
        private const char DO_C = 'C';
        private const char DO_c = 'c';
        private const char RE_D = 'D';
        private const char RE_d = 'd';
        private const char MI_E = 'E';
        private const char MI_e = 'e';
        private const char FA_F = 'F';
        private const char FA_f = 'f';
        private const char SOL_G = 'G';
        private const char SOL_g = 'g';
        private const char SILENCE = ' ';
        private const char REPEAT = '!';
        private const char CHANGE_BPM_UP = ',';
        private const char CHANGE_BPM_DOWN = ';';
        private const char DURATION_UP_POINT = '.';
        private const char DURATION_UP_INTERROGATION = '?';
        private const char TONE_UP_O = 'O';
        private const char TONE_UP_o = 'o';
        private const char TONE_UP_I = 'I';
        private const char TONE_UP_i = 'i';
        private const char TONE_UP_U = 'U';
        private const char TONE_UP_u = 'u';



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
            
            switch (charactereToBeDecoded)
            {
                case LA_a:
                case LA_A:

                    break;

                case SI_b:
                case SI_B:

                    break;

                case DO_c:
                case DO_C:

                    break;

                case RE_d:
                case RE_D:

                    break;

                case MI_e:
                case MI_E:

                    break;

                case FA_f:
                case FA_F:

                    break;

                case SOL_g:
                case SOL_G:

                    break;

                case SILENCE:

                    break;

                case REPEAT:

                    break;

                case CHANGE_BPM_UP:

                    break;

                case CHANGE_BPM_DOWN:

                    break;

                case DURATION_UP_INTERROGATION:
                case DURATION_UP_POINT:

                    break;

                case TONE_UP_i:
                case TONE_UP_I:
                case TONE_UP_o:
                case TONE_UP_O:
                case TONE_UP_u:
                case TONE_UP_U:

                    break;

                default:

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

                    break;

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
