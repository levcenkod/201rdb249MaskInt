using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201RDB249_1prakt
{
    public partial class Form1 : Form
    {
        bool PlayersTurn;
        bool PlayerStartFirst;
        public static bool wantToPlayAgain;
        bool isMaxTurn;
        AI Ai = new();
        Game game = new Game("22233",8,8);
        public Form1(bool PlayerStartsFirst)
        {
            wantToPlayAgain = false;
            PlayerStartFirst = PlayerStartsFirst;
            isMaxTurn = true;
            InitializeComponent();
            if (PlayerStartsFirst)
            {
                PlayAgain.Enabled = false;
                PlayersTurn = true;
                turnLabel.Text = "Tava karta";
                Take2.Enabled = true;
                Take3.Enabled = true;
            }
            else
            {
                PlayersTurn = false;
                turnLabel.Text = "Datora karta";
                Take2.Enabled = false;
                Take3.Enabled = false;
                MakeTurn(isMaxTurn, game);
            }
        }

        private void SkaitVirkne_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AiScore_Click(object sender, EventArgs e)
        {

        }

        private void MyScore_Click(object sender, EventArgs e)
        {

        }

        private void Take2_Click(object sender, EventArgs e)
        {
            char[] charArr = SkaitVirkne.Text.ToCharArray();
            bool found = false;

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals('2'))
                {
                    charArr[i] = '0';
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Nav tada skaitla virknee", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SkaitVirkne.Text = "";
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (!charArr[i].Equals('0'))
                    {
                        SkaitVirkne.Text += charArr[i];
                    }
                }

                if (PlayersTurn)
                {
                    MyScore.Text = (int.Parse(MyScore.Text) - 2).ToString();
                    if (isMaxTurn == true) game.setMaximScore(int.Parse(MyScore.Text));
                    if (isMaxTurn == false) game.setMinimScore(int.Parse(MyScore.Text));
                    game.setskaitVirkne(SkaitVirkne.Text);
                    turnLabel.Text = "Datora karta";
                    Take2.Enabled = false;
                    Take3.Enabled = false;
                    PlayersTurn = !PlayersTurn;
                    isMaxTurn = !isMaxTurn;
                    MakeTurn(isMaxTurn, game);
                }
                else
                {
                    AiScore.Text = (int.Parse(AiScore.Text) - 2).ToString();
                    if (isMaxTurn == true) game.setMaximScore(int.Parse(MyScore.Text));
                    if (isMaxTurn == false) game.setMinimScore(int.Parse(MyScore.Text));
                    game.setskaitVirkne(SkaitVirkne.Text);
                    turnLabel.Text = "Tava karta";
                    Take2.Enabled = true;
                    Take3.Enabled = true;
                    PlayersTurn = !PlayersTurn;
                    isMaxTurn = !isMaxTurn;
                }

            }
        }

        private void Take3_Click(object sender, EventArgs e)
        {
            char[] charArr = SkaitVirkne.Text.ToCharArray();
            bool found = false;

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals('3'))
                {
                    charArr[i] = '0';
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Nav tada skaitla virknee", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SkaitVirkne.Text = "";
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (!charArr[i].Equals('0'))
                    {
                        SkaitVirkne.Text += charArr[i];
                    }
                }

                if (PlayersTurn)
                {
                    MyScore.Text = (int.Parse(MyScore.Text) - 3).ToString();
                    if (isMaxTurn == true) game.setMaximScore(int.Parse(MyScore.Text));
                    if (isMaxTurn == false) game.setMinimScore(int.Parse(MyScore.Text));
                    game.setskaitVirkne(SkaitVirkne.Text);
                    turnLabel.Text = "Datora karta";
                    Take2.Enabled = false;
                    Take3.Enabled = false;
                    PlayersTurn = !PlayersTurn;
                    isMaxTurn = !isMaxTurn;
                    MakeTurn(isMaxTurn, game);
                    if (game.getskaitVirkne().Length == 1)
                    {
                        if (int.Parse(MyScore.Text) > int.Parse(AiScore.Text)) turnLabel.Text = "Spele ir beigusies - speletajs uzvareja";
                        if (int.Parse(MyScore.Text) < int.Parse(AiScore.Text)) turnLabel.Text = "Spele ir beigusies - dators uzvareja";
                        if (int.Parse(MyScore.Text) == int.Parse(AiScore.Text)) turnLabel.Text = "Spele ir beigusies - rezultats neizskirts";
                        PlayAgain.Enabled = true;
                        Take2.Enabled = false;
                        Take3.Enabled = false;
                    }
                } else
                {
                    AiScore.Text = (int.Parse(AiScore.Text) - 3).ToString();
                    if (isMaxTurn == true) game.setMaximScore(int.Parse(MyScore.Text));
                    if (isMaxTurn == false) game.setMinimScore(int.Parse(MyScore.Text));
                    game.setskaitVirkne(SkaitVirkne.Text);
                    turnLabel.Text = "Tava karta";
                    Take2.Enabled = true;
                    Take3.Enabled = true;
                    PlayersTurn = !PlayersTurn;
                    isMaxTurn = !isMaxTurn;
                }
                
            }
        }

        private void turnLable_Click(object sender, EventArgs e)
        {

        }

        private void MakeTurn(bool isMaxTurn, Game game)
        {
            Thread.Sleep(500);
            if (game.getskaitVirkne().Length == 1)
            {
                if (int.Parse(MyScore.Text) > int.Parse(AiScore.Text)) turnLabel.Text = "Spele ir beigusies - speletajs uzvareja";
                if (int.Parse(MyScore.Text) < int.Parse(AiScore.Text)) turnLabel.Text = "Spele ir beigusies - dators uzvareja";
                if (int.Parse(MyScore.Text) == int.Parse(AiScore.Text)) turnLabel.Text = "Spele ir beigusies - rezultats neizskirts";

            }
            else
            {
                int novertejumaResult = Ai.Minimax(isMaxTurn, game).First().Key;
                if (novertejumaResult == 2) Take2_Click(this, System.EventArgs.Empty);
                if (novertejumaResult == 3) Take3_Click(this, System.EventArgs.Empty);

                if (game.getskaitVirkne().Length == 1)
                {
                    if (int.Parse(MyScore.Text)  > int.Parse(AiScore.Text)) turnLabel.Text = "Spele ir beigusies - speletajs uzvareja";
                    if (int.Parse(MyScore.Text) < int.Parse(AiScore.Text)) turnLabel.Text = "Spele ir beigusies - dators uzvareja";
                    if (int.Parse(MyScore.Text) == int.Parse(AiScore.Text)) turnLabel.Text = "Spele ir beigusies - rezultats neizskirts";
                    
                    PlayAgain.Enabled = true;
                    Take2.Enabled = false;
                    Take3.Enabled = false;
                }
                else
                {
                    turnLabel.Text = "Tava karta";
                    Take2.Enabled = true;
                    Take3.Enabled = true;
                }

            }

        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
            wantToPlayAgain = true;
        }
    }
}
