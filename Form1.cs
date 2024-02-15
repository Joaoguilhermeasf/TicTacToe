using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool bola = true;
        int play = 0;
        public Form1()
        {
            InitializeComponent();


        }



        private void check()
        {
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button1.Text == "X" && button6.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button1.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                MessageBox.Show("Jogador 2 venceu!");
                button10.Enabled = true;
                button10.Text = "Jogar novamente?";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
            else
            {
                if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button1.Text == "O" && button6.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button1.Text == "O" && button5.Text == "O" && button7.Text == "O"))
                {
                    MessageBox.Show("Jogador 1 venceu!");
                    button10.Enabled = true;
                    button10.Text = "Jogar novamente?";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                else {
                    if (play == 9)
                    {
                        MessageBox.Show("Empate!");
                        button10.Enabled = true;
                        button10.Text = "Jogar novamente?";
                    }
                }
            }
           
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (bola)
            {
                button.Text = "O";
                bola = false;
                button.BackColor = Color.FromArgb(0, 208, 236);
                play++;
            }
            else
            {
                button.Text = "X";
                bola = true;
                button.BackColor = Color.FromArgb(226, 149, 118);
                play++;
            }
            button.Enabled = false;
            check();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void jogarnov(object sender, EventArgs e)
        {
            play = 0;
            bola = true;
            button10.Enabled = false;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button1.BackColor = Color.FromArgb(253, 253, 253);
            button2.BackColor = Color.FromArgb(253, 253, 253);
            button3.BackColor = Color.FromArgb(253, 253, 253);
            button4.BackColor = Color.FromArgb(253, 253, 253);
            button5.BackColor = Color.FromArgb(253, 253, 253);
            button6.BackColor = Color.FromArgb(253, 253, 253);
            button7.BackColor = Color.FromArgb(253, 253, 253);
            button8.BackColor = Color.FromArgb(253, 253, 253);
            button9.BackColor = Color.FromArgb(253, 253, 253);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void end(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}