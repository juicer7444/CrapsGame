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
    public partial class StartForm : Form
    {
        private List<Player> players;
        public StartForm()
        {
            players = new List<Player>();
            InitializeComponent();
            players = DBController.getPlayers();
            // binds players dataset to combobox
            updateBinding();

        }

        // updates combobox
        private void updateBinding()
        {
            BindingSource bindingsource1 = new BindingSource
            {
                DataSource = players
            };
            playerListComboBox.DataSource = bindingsource1;
            playerListComboBox.DisplayMember = "PlayerName";
            playerListComboBox.ValueMember = "PlayerName";
        }

        // TODO: May take out the this.Hide() function and replace with different solution
        // passes the selected player into MainForm to play the game and then hides the StartForm
        private void mainPlayButton_Click(object sender, EventArgs e)
        {
            Player selectedPlayer = (Player)playerListComboBox.SelectedItem;
            MainForm mfrm = new MainForm(selectedPlayer.PlayerId);
            mfrm.Show();
            this.Hide();            
        }

        // opens the CreatePlayerForm and adds new player to the combobox
        private void mainCreatePlayerButton_Click(object sender, EventArgs e)
        {
            CreatePlayerForm frm = new CreatePlayerForm();
            frm.ShowDialog();
            if(frm.Response == "ok")
            {
                players.Add(frm.NewPlayer);
                updateBinding();

            }
        }
    }
}
