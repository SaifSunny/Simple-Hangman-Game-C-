using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan_windows
{
    public partial class Form1 : Form
    {
        private Bitmap[] showImage = { HangMan_windows.Properties.Resources._0, HangMan_windows.Properties.Resources._1,
        HangMan_windows.Properties.Resources._2,HangMan_windows.Properties.Resources._3,
        HangMan_windows.Properties.Resources._4,HangMan_windows.Properties.Resources._5,
        HangMan_windows.Properties.Resources._6 };

        private string[] animal = { "SHEEP", "ELEPHANT", "MOUSE", "RABBIT", "TURTLE", "DEER", "KANGAROO", "HORSE", "HIPPOPOTAMUS", 
            "GIRAFEE", "SQUIRREL", "DOG", "CHIMPANZEE", "LION", "PANDA", "KITTEN", "HAMSTER", "COW", "PIG", "GOAT", "CHICKEN", 
            "MONKEY", "FOX", "RACCOON", "FROG","CAT","RAT"};
        private int wrongGuess = 0;
        private string word="";
        private string copyword = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Loadword()
        {
            wrongGuess = 0;
            pictureBox1.Image = showImage[wrongGuess];
            Random r = new Random();
            int ind = r.Next(animal.Length);
            word = animal[ind];
            copyword = "";
            for (int i = 0; i < word.Length; i++)
            { 
                copyword += "_"; 
            }
            displayword();
        }

        private void displayword()
        {
            word_display.Text += " ";
            for (int i = 0; i < word.Length; i++)
            {
                word_display.Text += copyword.Substring(i, 1);
                word_display.Text += " ";
            }
        }
        private void On_click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                b.Enabled = false;
                if (word.Contains(b.Text))
                {
                    char[] temp = copyword.ToCharArray();
                    char[] actualWord = word.ToCharArray();
                    char playerGuess = char.Parse(b.Text);
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (playerGuess == actualWord[i])
                        {
                            temp[i] = playerGuess;
                        }
                    }
                    copyword = new string(temp);
                    word_display.Text = "";
                    displayword();
                }
                else
                {
                    wrongGuess++;
                }
                if (wrongGuess < 7)
                {
                    pictureBox1.Image = showImage[wrongGuess];
                }
                else
                {
                    MessageBox.Show(" Game Over ");
                    MessageBox.Show(" The word was " + word);
                }
                if (copyword.Equals(word))
                {
                    MessageBox.Show(" Congratulation ! You Won ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loadword();
        }

        private void button_newgame_Click(object sender, EventArgs e)
        {
            try
            {
                word_display.Text = "";
                Loadword();
                Button b = (Button)sender;
                buttonA.Enabled = true;
                buttonB.Enabled = true;
                buttonC.Enabled = true;
                buttonD.Enabled = true;
                buttonE.Enabled = true;
                buttonF.Enabled = true;
                buttonG.Enabled = true;
                buttonH.Enabled = true;
                buttonI.Enabled = true;
                buttonJ.Enabled = true;
                buttonK.Enabled = true;
                buttonL.Enabled = true;
                buttonM.Enabled = true;
                buttonN.Enabled = true;
                buttonO.Enabled = true;
                buttonP.Enabled = true;
                buttonQ.Enabled = true;
                buttonR.Enabled = true;
                buttonS.Enabled = true;
                buttonT.Enabled = true;
                buttonU.Enabled = true;
                buttonV.Enabled = true;
                buttonW.Enabled = true;
                buttonX.Enabled = true;
                buttonY.Enabled = true;
                buttonZ.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
