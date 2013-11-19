using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Midi;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    class Mensagem
    {
        //ATRIBUTOS
        Note nota;
        int oitava;
        int BPM;
        bool repetição;
        Mensagem próxima;

        //SETS
        void setNota(char letra)
        {
            nota = new Note(letra);
        }
        void setOitava(int novaOitava)
        {
            oitava = novaOitava;
        }
        void setBPM(int novoBPM)
        {
            BPM = novoBPM;
        }
        void setRepetição(bool repete)
        {
            repetição = repete;
        }

        //GETS
        Pitch getPitch()
        {
            Pitch pitch;
            pitch = nota.PitchInOctave(oitava);
            return (pitch);
        }
        int getBPM()
        {
            return BPM;
        }
    }
}
