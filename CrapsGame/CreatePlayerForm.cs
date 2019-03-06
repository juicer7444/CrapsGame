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
    public partial class CreatePlayerForm : Form
    {
        public string Response { get; set; }
        public Player NewPlayer { get; set; }

        public CreatePlayerForm()
        {
            InitializeComponent();
        }

        // creates new player in database and allows for MainForm to grab that Player object
        private void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            DBController.CreatePlayer(createPlayerTextBox.Text.ToString());
            NewPlayer = DBController.getPlayerByName(createPlayerTextBox.Text.ToString());
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
