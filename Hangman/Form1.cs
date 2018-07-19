using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public string theWord;
        public int wordLength;
        public int correctGuesses = 0;
        public bool gameStarted = false;
        public char letter;
        public List<char> gameLetters = new List<char>();
        public bool btnQPress = false;
        public bool btnWPress = false;
        public bool btnEPress = false;
        public bool btnRPress = false;
        public bool btnTPress = false;
        public bool btnYPress = false;
        public bool btnUPress = false;
        public bool btnIPress = false;
        public bool btnOPress = false;
        public bool btnPPress = false;
        public bool btnAPress = false;
        public bool btnSPress = false;
        public bool btnDPress = false;
        public bool btnFPress = false;
        public bool btnGPress = false;
        public bool btnHPress = false;
        public bool btnJPress = false;
        public bool btnKPress = false;
        public bool btnLPress = false;
        public bool btnZPress = false;
        public bool btnXPress = false;
        public bool btnCPress = false;
        public bool btnVPress = false;
        public bool btnBPress = false;
        public bool btnNPress = false;
        public bool btnMPress = false;

        public Form1()
        {
            InitializeComponent();
            Startup();
        }

        private void btnUseWord_Click(object sender, EventArgs e)
        {
            if (tbTheWord.Text.Length >= 3 && tbTheWord.Text.Length  < 11)
            {
                gameStarted = true;
                theWord = tbTheWord.Text.ToString().ToUpper();
                wordLength = tbTheWord.Text.Length;
                btnUseWord.Hide();
                tbTheWord.Hide();
                label1.Hide(); // Label next to Word enter textbox

                switch (wordLength)
                {
                    case 3:
                        lblLetter1.Show();
                        lblLetter2.Show();
                        lblLetter3.Show();
                        
                        break;
                    case 4:
                        lblLetter1.Show();
                        lblLetter2.Show();
                        lblLetter3.Show();
                        lblLetter4.Show();
                        
                        break;
                    case 5:
                        lblLetter1.Show();
                        lblLetter2.Show();
                        lblLetter3.Show();
                        lblLetter4.Show();
                        lblLetter5.Show();
                        
                        break;
                    case 6:
                        lblLetter1.Show();
                        lblLetter2.Show();
                        lblLetter3.Show();
                        lblLetter4.Show();
                        lblLetter4.Show();
                        lblLetter5.Show();
                        lblLetter6.Show();
                        
                        break;
                    case 7:
                        lblLetter1.Show();
                        lblLetter2.Show();
                        lblLetter3.Show();
                        lblLetter4.Show();
                        lblLetter5.Show();
                        lblLetter6.Show();
                        lblLetter7.Show();
                        
                        break;
                    case 8:
                        lblLetter1.Show();
                        lblLetter2.Show();
                        lblLetter3.Show();
                        lblLetter4.Show();
                        lblLetter5.Show();
                        lblLetter6.Show();
                        lblLetter7.Show();
                        lblLetter8.Show();
                        
                        break;
                    case 9:
                        lblLetter1.Show();
                        lblLetter2.Show();
                        lblLetter3.Show();
                        lblLetter4.Show();
                        lblLetter5.Show();
                        lblLetter6.Show();
                        lblLetter7.Show();
                        lblLetter8.Show();
                        lblLetter9.Show();
                        
                        break;
                    case 10:
                        lblLetter1.Show();
                        lblLetter2.Show();
                        lblLetter3.Show();
                        lblLetter4.Show();
                        lblLetter5.Show();
                        lblLetter6.Show();
                        lblLetter7.Show();
                        lblLetter8.Show();
                        lblLetter9.Show();
                        lblLetter10.Show();
                        
                        break;
                } // Check length of word and display relevant number of labels
                ConvertWordToList();
                

            }
            else
            {
                MessageBox.Show("Word must be between 3 and 10 letters!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void IncreaseFailProgress()
        {
            failBar.PerformStep();
            tbGuessedBox.Text += " " + letter.ToString() + ",";

            if (failBar.Value >= 100)
            {
                MessageBox.Show("Too many wrong guesses!", "Game Over!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gameStarted = false;
                theWord = null;
                wordLength = 0;
                correctGuesses = 0;
                gameLetters.Clear();
                Startup();
            }
        }

        public void Startup()
        {
            lblLetter1.Hide();
            lblLetter2.Hide();
            lblLetter3.Hide();
            lblLetter4.Hide();
            lblLetter5.Hide();
            lblLetter6.Hide();
            lblLetter7.Hide();
            lblLetter8.Hide();
            lblLetter9.Hide();
            lblLetter10.Hide();
            lblLetter1.Text = "?";
            lblLetter2.Text = "?";
            lblLetter3.Text = "?";
            lblLetter4.Text = "?";
            lblLetter5.Text = "?";
            lblLetter6.Text = "?";
            lblLetter7.Text = "?";
            lblLetter8.Text = "?";
            lblLetter9.Text = "?";
            lblLetter10.Text = "?";

            btnQPress = false;
            btnWPress = false;
            btnEPress = false;
            btnRPress = false;
            btnTPress = false;
             btnYPress = false;
             btnUPress = false;
             btnIPress = false;
             btnOPress = false;
             btnPPress = false;
             btnAPress = false;
             btnSPress = false;
             btnDPress = false;
             btnFPress = false;
             btnGPress = false;
             btnHPress = false;
             btnJPress = false;
             btnKPress = false;
             btnLPress = false;
             btnZPress = false;
             btnXPress = false;
             btnCPress = false;
             btnVPress = false;
             btnBPress = false;
             btnNPress = false;
             btnMPress = false;

            btnUseWord.Show();
            tbTheWord.Clear();
            tbTheWord.Show();
            label1.Show();
            tbGuessedBox.Clear();
            correctGuesses = 0;
            failBar.Value = 0;


        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            gameStarted = false;
            theWord = null;
            wordLength = 0;
            gameLetters.Clear();

            Startup();
        }

        public void ConvertWordToList()
        {
            foreach (var l in theWord)
            {
                gameLetters.Add(l);
            }
        }

        public void CheckLetter()
        {
            var correctGuess = false;
            var currentPosition = 1;
            foreach (var i in gameLetters)
            {
                if (letter == i)
                {
                    switch (currentPosition)
                    {
                        case 1:
                            lblLetter1.Text = i.ToString();
                            correctGuesses += 1;
                            break;
                        case 2:
                            lblLetter2.Text = i.ToString();
                            correctGuesses += 1;
                            break;
                        case 3:
                            lblLetter3.Text = i.ToString();
                            correctGuesses += 1;
                            break;
                        case 4:
                            lblLetter4.Text = i.ToString();
                            correctGuesses += 1;
                            break;
                        case 5:
                            lblLetter5.Text = i.ToString();
                            correctGuesses += 1;
                            break;
                        case 6:
                            lblLetter6.Text = i.ToString();
                            correctGuesses += 1;
                            break;
                        case 7:
                            lblLetter7.Text = i.ToString();
                            correctGuesses += 1;
                            break;
                        case 8:
                            lblLetter8.Text = i.ToString();
                            correctGuesses += 1;
                            break;
                        case 9:
                            lblLetter9.Text = i.ToString();
                            correctGuesses += 1;
                            break;
                        case 10:
                            lblLetter10.Text = i.ToString();
                            correctGuesses += 1;
                            break;
                    }
                    correctGuess = true;
                    
                }
                currentPosition++;
            }
            if (correctGuess == false)
            {
                IncreaseFailProgress();
            }

            if (correctGuesses == wordLength && gameStarted == true)
            {
                MessageBox.Show("Congratulations!", "WINNER!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gameStarted = false;
                theWord = null;
                wordLength = 0;
                gameLetters.Clear();

                Startup();
            }
            
            


        }

        //
        //DEBUG
        private void failBar_Click(object sender, EventArgs e)
        {
            try { 
                switch (wordLength)
                {
                    case 3:
                        lblLetter1.Text = gameLetters[0].ToString();
                        lblLetter2.Text = gameLetters[1].ToString();
                        lblLetter3.Text = gameLetters[2].ToString();
                        break;
                    case 4:
                        lblLetter1.Text = gameLetters[0].ToString();
                        lblLetter2.Text = gameLetters[1].ToString();
                        lblLetter3.Text = gameLetters[2].ToString();
                        lblLetter4.Text = gameLetters[3].ToString();
                        break;
                    case 5:
                        lblLetter1.Text = gameLetters[0].ToString();
                        lblLetter2.Text = gameLetters[1].ToString();
                        lblLetter3.Text = gameLetters[2].ToString();
                        lblLetter4.Text = gameLetters[3].ToString();
                        lblLetter5.Text = gameLetters[4].ToString();
                        break;
                    case 6:
                        lblLetter1.Text = gameLetters[0].ToString();
                        lblLetter2.Text = gameLetters[1].ToString();
                        lblLetter3.Text = gameLetters[2].ToString();
                        lblLetter4.Text = gameLetters[3].ToString();
                        lblLetter5.Text = gameLetters[4].ToString();
                        lblLetter6.Text = gameLetters[5].ToString();
                        break;
                    case 7:
                        lblLetter1.Text = gameLetters[0].ToString();
                        lblLetter2.Text = gameLetters[1].ToString();
                        lblLetter3.Text = gameLetters[2].ToString();
                        lblLetter4.Text = gameLetters[3].ToString();
                        lblLetter5.Text = gameLetters[4].ToString();
                        lblLetter6.Text = gameLetters[5].ToString();
                        lblLetter7.Text = gameLetters[6].ToString();
                        break;
                    case 8:
                        lblLetter1.Text = gameLetters[0].ToString();
                        lblLetter2.Text = gameLetters[1].ToString();
                        lblLetter3.Text = gameLetters[2].ToString();
                        lblLetter4.Text = gameLetters[3].ToString();
                        lblLetter5.Text = gameLetters[4].ToString();
                        lblLetter6.Text = gameLetters[5].ToString();
                        lblLetter7.Text = gameLetters[6].ToString();
                        lblLetter8.Text = gameLetters[7].ToString();
                        break;
                    case 9:
                        lblLetter1.Text = gameLetters[0].ToString();
                        lblLetter2.Text = gameLetters[1].ToString();
                        lblLetter3.Text = gameLetters[2].ToString();
                        lblLetter4.Text = gameLetters[3].ToString();
                        lblLetter5.Text = gameLetters[4].ToString();
                        lblLetter6.Text = gameLetters[5].ToString();
                        lblLetter7.Text = gameLetters[6].ToString();
                        lblLetter8.Text = gameLetters[7].ToString();
                        lblLetter9.Text = gameLetters[8].ToString();
                        break;
                    case 10:
                        lblLetter1.Text = gameLetters[0].ToString();
                        lblLetter2.Text = gameLetters[1].ToString();
                        lblLetter3.Text = gameLetters[2].ToString();
                        lblLetter4.Text = gameLetters[3].ToString();
                        lblLetter5.Text = gameLetters[4].ToString();
                        lblLetter6.Text = gameLetters[5].ToString();
                        lblLetter7.Text = gameLetters[6].ToString();
                        lblLetter8.Text = gameLetters[7].ToString();
                        lblLetter9.Text = gameLetters[8].ToString();
                        lblLetter10.Text = gameLetters[9].ToString();
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                MessageBox.Show("HOW ON EARTH DID WE GET HERE!?", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //
        //

        // Methods to control Letter click
        private void btnQ_Click(object sender, EventArgs e)
        {
            if( gameStarted == true && btnQPress == false)
            {
                letter = 'Q';
                CheckLetter();
                btnQPress = true;
            }
            
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnWPress == false)
            {
                letter = 'W';
                CheckLetter();
                btnWPress = true;
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnEPress == false)
            {
                letter = 'E';
                CheckLetter();
                btnEPress = true;
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnRPress == false)
            {
                letter = 'R';
                CheckLetter();
                btnRPress = true;
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnTPress == false)
            {
                letter = 'T';
                CheckLetter();
                btnTPress = true;
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnYPress == false)
            {
                letter = 'Y';
                CheckLetter();
                btnYPress = true;
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnUPress == false)
            {
                letter = 'U';
                CheckLetter();
                btnUPress = true;
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnIPress == false)
            {
                letter = 'I';
                CheckLetter();
                btnIPress = true;
            }
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnOPress == false)
            {
                letter = 'O';
                CheckLetter();
                btnOPress = true;
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnPPress == false)
            {
                letter = 'P';
                CheckLetter();
                btnPPress = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnAPress == false)
            {
                letter = 'A';
                CheckLetter();
                btnAPress = true;
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnSPress == false)
            {
                letter = 'S';
                CheckLetter();
                btnSPress = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnDPress == false)
            {
                letter = 'D';
                CheckLetter();
                btnDPress = true;
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnFPress == false)
            {
                letter = 'F';
                CheckLetter();
                btnFPress = true;
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnGPress == false)
            {
                letter = 'G';
                CheckLetter();
                btnGPress = true;
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnHPress == false)
            {
                letter = 'H';
                CheckLetter();
                btnHPress = true;
            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnJPress == false)
            {
                letter = 'J';
                CheckLetter();
                btnJPress = true;
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnKPress == false)
            {
                letter = 'K';
                CheckLetter();
                btnKPress = true;
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnLPress == false)
            {
                letter = 'L';
                CheckLetter();
                btnLPress = true;
            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnZPress == false)
            {
                letter = 'Z';
                CheckLetter();
                btnZPress = true;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnXPress == false)
            {
                letter = 'X';
                CheckLetter();
                btnXPress = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnCPress == false)
            {
                letter = 'C';
                CheckLetter();
                btnCPress = true;
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnVPress == false)
            {
                letter = 'V';
                CheckLetter();
                btnVPress = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnBPress == false)
            {
                letter = 'B';
                CheckLetter();
                btnBPress = true;
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnNPress == false)
            {
                letter = 'N';
                CheckLetter();
                btnNPress = true;
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && btnMPress == false)
            {
                letter = 'M';
                CheckLetter();
                btnMPress = true;
            }
        }
    }
}
