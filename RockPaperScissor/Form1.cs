using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        string playerChoice;
        string playerName = "Player";
        int totalRound = 5;
        int timePerRound = 6;
        string[] cChoice = {"rock", "paper", "scissors" };
        Random r = new Random();
        int randomNum;
        string computerChoice;
        int playerWins = 0;
        int computerWins = 0;
        DataTable dt = new DataTable();


        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            playerChoice = "none";
            timer1.Stop();
            playerscoreshow_textBox.Text = "0";
            computerscore_textBox.Text = "0";       
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(playerName, typeof(string));
            dt.Columns.Add("Computer", typeof(string));
            dt.Columns.Add("Winner", typeof(string));
            dataGridView.DataSource = dt;
            
        }


        private void addRow( DataTable table, string p, string c, string w)
        {
            table.Rows.Add(p, c, w);
        }


        private void check()
        {
            if (playerChoice == "rock" && computerChoice == "paper")
            {
                MessageBox.Show("Computer Wins", "Results", MessageBoxButtons.OK);
                computerWins++;
                totalRound--;
                addRow(dt, "Rock", "Paper", "Computer");
                computerscore_textBox.Text = computerWins.ToString();
                timer1.Enabled = true;
            }

            else if (playerChoice == "paper" && computerChoice == "scissors")
            {
                MessageBox.Show("Computer Wins", "Results", MessageBoxButtons.OK);
                computerWins++;
                totalRound--;
                addRow(dt, "Paper", "Scissors", "Computer");
                computerscore_textBox.Text = computerWins.ToString();
                timer1.Enabled = true;
            }

            else if (playerChoice == "scissors" && computerChoice == "rock")
            {
                MessageBox.Show("Computer Wins", "Results", MessageBoxButtons.OK);
                computerWins++;
                totalRound--;
                addRow(dt, "Scissors", "Rock", "Computer");
                computerscore_textBox.Text = computerWins.ToString();
                timer1.Enabled = true;
            }

            else if (playerChoice == "paper" && computerChoice == "rock")
            {
                MessageBox.Show(playerName + " wins", "Results", MessageBoxButtons.OK);
                playerWins++;
                totalRound--;
                addRow(dt, "Paper", "Rock", playerName);
                playerscoreshow_textBox.Text = playerWins.ToString();
                timer1.Enabled = true;
            }

            else if (playerChoice == "scissors" && computerChoice == "paper")
            {
                MessageBox.Show(playerName + " wins", "Results", MessageBoxButtons.OK);
                playerWins++;
                totalRound--;
                addRow(dt, "Scissors", "Paper", playerName);
                playerscoreshow_textBox.Text = playerWins.ToString();
                timer1.Enabled = true;
            }

            else if (playerChoice == "rock" && computerChoice == "scissors")
            {
                MessageBox.Show(playerName + " wins", "Results", MessageBoxButtons.OK);
                playerWins++;
                totalRound--;
                addRow(dt, "Rock", "Scissors", playerName);
                playerscoreshow_textBox.Text = playerWins.ToString();
                timer1.Enabled = true;
            }


            else if (playerChoice == "rock" && computerChoice == "rock")
            {
                MessageBox.Show("Tie", "Results", MessageBoxButtons.OK);
                totalRound--;
                addRow(dt, "Rock", "Rock", "Tie");
                timer1.Enabled = true;
            }

            else if (playerChoice == "paper" && computerChoice == "paper")
            {
                MessageBox.Show("Tie", "Results", MessageBoxButtons.OK);
                totalRound--;
                addRow(dt, "Paper", "Paper", "Tie");
                timer1.Enabled = true;
            }

            else if (playerChoice == "scissors" && computerChoice == "scissors")
            {
                MessageBox.Show("Tie", "Results", MessageBoxButtons.OK);
                totalRound--;
                addRow(dt, "Scissors", "Scissors", "Tie");
                timer1.Enabled = true;
            }

            else
            {
                MessageBox.Show("Choose your Option", "Results", MessageBoxButtons.OK);
                timer1.Enabled = true;
            }
        }


        private void decision()
        {
            if (computerWins < playerWins)
            { 
                MessageBox.Show(playerName + " Wins, COMPUTER LOSER!! \n" + playerName + " Score:" + playerscoreshow_textBox.Text.ToString() + "\n" + "Computer Score:" + computerscore_textBox.Text.ToString(), "Results", MessageBoxButtons.OK);
            }
            else if (computerWins > playerWins)
            {
                MessageBox.Show("Computer Wins, YOU LOSER!!\n" + playerName + " Score:" + playerscoreshow_textBox.Text.ToString() + "\n" + "Computer Score:" + computerscore_textBox.Text.ToString(), "Results", MessageBoxButtons.OK);
            }
            else if (computerWins == playerWins)
            {
                MessageBox.Show("Tie\n" + playerName + " Score:" + playerscoreshow_textBox.Text.ToString() + "\n" + "Computer Score:" + computerscore_textBox.Text.ToString(), "Results", MessageBoxButtons.OK);            }
            
        }

        private void ComputerChoice()
        {
            randomNum = r.Next(0, 2);
            computerChoice = cChoice[randomNum];

            switch (computerChoice)
            {
                case "rock":
                    computer_pictureBox.Image = Properties.Resources.rock;
                    break;

                case "paper":
                    computer_pictureBox.Image = Properties.Resources.paper;
                    break;

                case "scissors":
                    computer_pictureBox.Image = Properties.Resources.scissors;
                    break;

                default:
                    break;
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            timePerRound--;
            label1.Text = Convert.ToString(timePerRound);
            
            if (timePerRound == 1)
            {
                timer1.Enabled = false;
                timePerRound = 6;
                ComputerChoice();

                if (totalRound > 1)
                {
                    check();
                }
                else
                {
                    check();
                    timer1.Stop();
                    decision();
                }

            }

        }

        private void rock_button_Click(object sender, EventArgs e)
        {
            playerChoice = "rock";
            player_pictureBox.Image = Properties.Resources.rock;
        }

        private void paper_button_Click(object sender, EventArgs e)
        {
            playerChoice = "paper";
            player_pictureBox.Image = Properties.Resources.paper;
        }

        private void scissors_button_Click(object sender, EventArgs e)
        {
            playerChoice = "scissors";
            player_pictureBox.Image = Properties.Resources.scissors;
        }

        
        private void inputpalyername_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                playerName = inputplayername_textBox.Text.ToString();
                MessageBox.Show("Player Name: " + playerName, "Player Name Setup ", MessageBoxButtons.OK);
                playername_textBox.Text = playerName;
                playernamescore_textBox.Text = playerName;
                dt.Columns["Player"].ColumnName = playerName;
                inputplayername_textBox.Enabled = false;

            }
        }


        private void timerstart_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timerstart_button.Enabled = false; 
        }



        private void reset_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to restart the game?", "Restart Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                playerName = "Player";
                playername_textBox.Text = playerName;
                playernamescore_textBox.Text = playerName;
                dt.Columns[0].ColumnName = playerName;
                totalRound = 5;
                timePerRound = 6;
                inputplayername_textBox.Enabled = true;
                inputplayername_textBox.Text = null;
                label1.Text = null;
                timer1.Stop();
                playerWins = 0;
                computerWins = 0;
                playerscoreshow_textBox.Text = "0";
                computerscore_textBox.Text = "0";
                dt.Rows.Clear();
                player_pictureBox.Image = Properties.Resources.qq;
                computer_pictureBox.Image = Properties.Resources.qq;
                timerstart_button.Enabled = true;
                
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            helpScreen help = new helpScreen();
            help.Show();
        }

        private void enablegridlines_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enablegridlines_checkBox.Checked)
            {

                dt.Rows.Add();
                dt.Rows.Add();
                dt.Rows.Add();
                dt.Rows.Add();
                dt.Rows.Add();
                dt.Rows.Add();
                dt.Rows.Add();
                dt.Rows.Add();
                dt.Rows.Add();
                dt.Rows.Add();
                dt.Rows.Add();
                
            }

            else
            {
                dataGridView.Rows[1].Visible = false;
                dataGridView.Rows[2].Visible = false;
                dataGridView.Rows[3].Visible = false;
                dataGridView.Rows[4].Visible = false;
                dataGridView.Rows[5].Visible = false;
                dataGridView.Rows[6].Visible = false;
                dataGridView.Rows[7].Visible = false;
                dataGridView.Rows[8].Visible = false;
                dataGridView.Rows[9].Visible = false;
                dataGridView.Rows[10].Visible = false;
            }
        }
    }
}