using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication4
{
    class Decoder
    {
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

        }
    }
}
