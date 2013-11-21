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

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (.txt)|*.txt";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(dialog.FileName);

                textBox.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {

        }


    }

    class Mensagem
    {
        
        //ATRIBUTOS
        private Note nota;
        private int oitava;
        private int BPM;
        private bool repetição;

        //SETS
        public void setNota(char letra)
        {
            nota = new Note(letra);
        }
        public void setOitava(int novaOitava)
        {
            oitava = novaOitava;
        }
        public void setBPM(int novoBPM)
        {
            BPM = novoBPM;
        }
        public void setRepetição(bool repete)
        {
            repetição = repete;
        }

        //GETS
        public Pitch getPitch()
        {
            Pitch pitch;
            pitch = nota.PitchInOctave(oitava);
            return (pitch);
        }
        public int getBPM()
        {
            return BPM;
        }
    }
}
