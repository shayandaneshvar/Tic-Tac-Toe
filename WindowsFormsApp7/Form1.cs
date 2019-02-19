using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        int move = 0;
        
        char[,] board = new char[3, 3];
        Image x = Image.FromFile("x.jpg");
        Image o = Image.FromFile("o.jpg");
        Class1 Game = new Class1();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    board[i,j] = '0';
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zerozero_Click(object sender, EventArgs e)
        {
            if (zerozero.Image == o || zerozero.Image == x)
            {
                MessageBox.Show("Wrong Move!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            
            if (move % 2 == 0)
            {
                zerozero.Image = o;
            }
            else
            {
                zerozero.Image = x;
            }
            board[0, 0] = (char)(move % 2 + 1);
            gameOver(Game.haveWon(board, (char)(move % 2 + 1)));
            move++;
            checkEnd(move);
        }

        private void zeroone_Click(object sender, EventArgs e)
        {
            if(zeroone.Image == o|| zeroone.Image == x)
            {
                MessageBox.Show("Wrong Move!","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            if (move % 2 == 0)
            {
                zeroone.Image = o;
            }
            else
            {
                zeroone.Image = x;
            }
            board[0, 1] = (char)(move % 2 + 1);
            gameOver(Game.haveWon(board, (char)(move % 2 + 1)));
            move++;
            checkEnd(move);
        }

        private void zerotwo_Click(object sender, EventArgs e)
        {
            if (zerotwo.Image == o || zerotwo.Image == x)
            {
                MessageBox.Show("Wrong Move!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            if (move % 2 == 0)
            {
                zerotwo.Image = o;
            }
            else
            {
                zerotwo.Image = x;
            }
            board[0, 2] = (char)(move % 2 + 1);
            gameOver(Game.haveWon(board, (char)(move % 2 + 1)));
            move++;
            checkEnd(move);
        }

        private void onezero_Click(object sender, EventArgs e)
        {
            if (onezero.Image == o ||onezero.Image == x)
            {
                MessageBox.Show("Wrong Move!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            if (move % 2 == 0)
            {
                onezero.Image = o;
            }
            else
            {
                onezero.Image = x;
            }
            board[1, 0] = (char)(move % 2 + 1);
            gameOver(Game.haveWon(board, (char)(move % 2 + 1)));
            move++;
            checkEnd(move);
        }

        private void oneone_Click(object sender, EventArgs e)
        {
            if (oneone.Image == o || oneone.Image == x)
            {
                MessageBox.Show("Wrong Move!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            if (move % 2 == 0)
            {
                oneone.Image = o;
            }
            else
            {
                oneone.Image = x;
            }
            board[1, 1] = (char)(move % 2 + 1);
            gameOver(Game.haveWon(board, (char)(move % 2 + 1)));
            move++;
            checkEnd(move);
        }

        private void onetwo_Click(object sender, EventArgs e)
        {
            if (onetwo.Image == o || onetwo.Image == x)
            {
                MessageBox.Show("Wrong Move!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            if (move % 2 == 0)
            {
                onetwo.Image = o;
            }
            else
            {
                onetwo.Image = x;
            }
            board[1, 2] = (char)(move % 2 + 1);
            gameOver(Game.haveWon(board, (char)(move % 2 + 1)));
            move++;
            checkEnd(move);
        }

        private void twozero_Click(object sender, EventArgs e)
        {
            if (twozero.Image == o || twozero.Image == x)
            {
                MessageBox.Show("Wrong Move!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            if (move % 2 == 0)
            {
                twozero.Image = o;
            }
            else
            {
                twozero.Image = x;
            }
            board[2, 0] = (char)(move % 2 + 1);
            gameOver(Game.haveWon(board, (char)(move % 2 + 1)));
            move++;
            checkEnd(move);
        }

        private void twoone_Click(object sender, EventArgs e)
        {
            if (twoone.Image == o || twoone.Image == x)
            {
                MessageBox.Show("Wrong Move!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            if (move % 2 == 0)
            {
                twoone.Image = o;
            }
            else
            {
                twoone.Image = x;
            }
            board[2, 1] = (char)(move % 2 + 1);
            gameOver(Game.haveWon(board, (char)(move % 2 + 1)));
            move++;
            checkEnd(move);
        }

        private void twotwo_Click(object sender, EventArgs e)
        {
            if (twotwo.Image == o || twotwo.Image == x)
            {
                MessageBox.Show("Wrong Move!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            if (move % 2 == 0)
            {
                twotwo.Image = o;
            }
            else
            {
                twotwo.Image = x;
            }
            board[2, 2] = (char)(move % 2 + 1);
            gameOver(Game.haveWon(board, (char)(move % 2 + 1)));
            move++;
            checkEnd(move);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }
        void gameOver(bool result)
        {
            if (result == true)
            {
                MessageBox.Show("You Have Won!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if(MessageBox.Show("Do You Want to Play Again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }

            }
        }
        void checkEnd(int move)
        {
            if (move > 8)
            {
                MessageBox.Show("Draw!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (MessageBox.Show("Do You Want to Play Again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void SSD_Click(object sender, EventArgs e)
        {
            SSD.ForeColor = Color.Orange;
            MessageBox.Show("Created By S.Daneshvar");
            System.Threading.Thread.Sleep(750);
            System.Diagnostics.Process.Start("http://shayandaneshvar.blogfa.com/");
            SSD.ForeColor = Color.DarkGray;
        }
        
    }
}

