using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsGame
{
    public partial class MainForm : Form
    {
        // creating class variables
        private Player currentPlayer;
        private List<Round> rounds;
        private int currentPoint = 0;

        public MainForm(string playerId)
        {
            // setting up selected player and populating round history
            InitializeComponent();
            currentPlayer = DBController.getPlayer(playerId);
            playerNameLabel.Text = currentPlayer.PlayerName;
            rounds = new List<Round>();
            rounds = DBController.GetRounds(currentPlayer.PlayerId);
            updateBinding();
        }


        // updates the listbox with up to date rounds
        private void updateBinding()
        {
            // binds the rounds list to the history list box for easier updating of information
            BindingSource bindingSource1 = new BindingSource
            {
                DataSource = rounds
            };
            historyListBox.DataSource = bindingSource1;
            historyListBox.DisplayMember = "FullRound";
            historyListBox.ValueMember = "FullRound";
        }

        // does the logic of Craps on click
        private void rollButton_Click(object sender, EventArgs e)
        { 
            Random rnd = new Random();
            Round round = new Round();

            // grab random number between 1-6
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int total = dice1 + dice2;
            round.RoundTotal = total;
            round.PlayerID = currentPlayer.PlayerId;
            round.RoundPoint = 0;

            // displays dice rolls to user
            this.totalSumLabel.Text = total.ToString();
            this.die1Label.Text = dice1.ToString();
            this.die2Label.Text = dice2.ToString();

            // checks if point has been set
            if (currentPoint == 0)
            {             
                switch (total)
                {
                    // Lose Cases
                    case 2:
                        round = doWhenLose(round);
                        break;
                    case 3:
                        round = doWhenLose(round);
                        break;
                    case 12:
                        round = doWhenLose(round);
                        break;

                    // Win Cases
                    case 7:
                        round = doWhenWin(round);
                        break;
                    case 11:
                        round = doWhenWin(round);
                        break;

                    // Set Point Cases
                    case 4:
                        round = doWhenPoint(round);
                        break;
                    case 5:
                        round = doWhenPoint(round);
                        break;
                    case 6:
                        round = doWhenPoint(round);
                        break;
                    case 8:
                        round = doWhenPoint(round);
                        break;
                    case 9:
                        round = doWhenPoint(round);
                        break;
                    case 10:
                        round = doWhenPoint(round);
                        break;
                }
            }
            // if point is set
            else
            {
                // since point is set, we set the current point to the round
                round.RoundPoint = currentPoint;
                if (total == 7)
                {
                    round = doWhenLose(round);
               
                } else if(total == currentPoint)
                {
                    // resets point
                    MessageBox.Show("point reset!");
                    this.pointLabel.Text = "point not set";
                    addRoundToListBox(round);
                    currentPoint = 0;
                }
                else
                {
                    addRoundToListBox(round);
                }
            }
        }

        private Round doWhenPoint(Round round)
        {
            round.RoundPoint = round.RoundTotal;
            this.pointLabel.Text = round.RoundTotal.ToString();
            currentPoint = round.RoundTotal;
            addRoundToListBox(round);
            return round;
        }

        private Round doWhenLose(Round round)
        {
            round.RoundResult = "lose";
            MessageBox.Show("you lose!");
            currentPoint = 0;
            this.pointLabel.Text = "point not set";
            addRoundToListBox(round);
            return round;
        }

        private Round doWhenWin(Round round)
        {
            round.RoundResult = "win";
            MessageBox.Show("you win!");
            currentPoint = 0;
            this.pointLabel.Text = "point not set";
            addRoundToListBox(round);
            return round;
        }

        private void addRoundToListBox(Round round)
        {
            rounds.Add(round);
            DBController.AddRound(round);
            updateBinding();
        }

        // pulls create player form up and will update current MainForm with the newly created player
        private void createPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePlayerForm frm = new CreatePlayerForm();
            frm.ShowDialog();
            if(frm.Response == "ok")
            {
                currentPlayer = frm.NewPlayer;
                playerNameLabel.Text = currentPlayer.PlayerName;
                rounds.Clear();
                updateBinding();
            }

        }

        // exits out of the entire application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // TODO: make this function redirect to StartForm instead of exiting out of the entire application
        // deletes the player and exits entirely from the application
        private void deletePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBController.DeletePlayer(currentPlayer.PlayerId);
            Application.Exit();
        }

        // pulls up EditPlayerForm and updates the current MainForm when changes are made
        private void editPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPlayerForm frm = new EditPlayerForm(currentPlayer);
            frm.ShowDialog();
            if(frm.Response == "ok")
            {
                playerNameLabel.Text = frm.CurrentPlayer.PlayerName;
            }
        }

        // clears player history in the database as well as in the MainForm
        private void clearPlayerHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBController.ClearRound(currentPlayer.PlayerId);
            rounds.Clear();
            updateBinding();
        }
        /*
        This overide allows the entire application to shut down on pressing the exit button
        rather than only closing out the window and having the application still running
        */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }

        
    }
}
