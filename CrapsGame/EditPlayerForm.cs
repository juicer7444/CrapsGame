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
    public partial class EditPlayerForm : Form
    {
        public Player CurrentPlayer { get; set; }
        public string Response { get; set; }
        public EditPlayerForm(Player player)
        {
            CurrentPlayer = player;
            InitializeComponent();
            // populates current name into textbox
            editPlayerTextBox.Text = CurrentPlayer.PlayerName;
        }

        // updates database with the name change and allows MainForm to access the new updated information
        private void submitButton_Click(object sender, EventArgs e)
        {
            DBController.EditPlayer(CurrentPlayer.PlayerId, editPlayerTextBox.Text.ToString());
            CurrentPlayer.PlayerName = editPlayerTextBox.Text.ToString();
            Response = "ok";
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Response = "cancel";
            this.Close();
        }
    }
}
