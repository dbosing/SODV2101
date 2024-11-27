using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        // BindingList to hold player data
        private BindingList<BasketballPlayer> players = new BindingList<BasketballPlayer>();

        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            InitializeUI();
        }

        // Initializes the data source with a list of basketball players.
        private void InitializeData()
        {
            players = new BindingList<BasketballPlayer>
            {
                new BasketballPlayer {Name = "LeBron James", Team = "Los Angeles Lakers", PhotoPath = "Photos/lebron.jpg", PointsPerGame = 23.6, AssistsPerGame = 9.1, ReboundsPerGame = 8.1, StealsPerGame = 0.8 },
                new BasketballPlayer {Name = "Anthony Davis", Team = "Los Angeles Lakers", PhotoPath = "Photos/davis.jpg", PointsPerGame = 30.1, AssistsPerGame = 2.8, ReboundsPerGame = 11.1, StealsPerGame = 1.3},
                new BasketballPlayer {Name = "Stephen Curry", Team = "Golden State Warriors", PhotoPath = "Photos/curry.png", PointsPerGame = 22.4, AssistsPerGame = 6.5, ReboundsPerGame = 5.4, StealsPerGame = 1.6},
                new BasketballPlayer {Name = "Draymond Green", Team = "Golden State Warriors", PhotoPath = "Photos/draymond.jpg", PointsPerGame = 8.5, AssistsPerGame = 5.9, ReboundsPerGame = 6.1, StealsPerGame = 0.9},
                new BasketballPlayer {Name = "Jayson Tatum", Team = "Boston Celtics", PhotoPath = "Photos/tatum.jpg", PointsPerGame = 28.4, AssistsPerGame = 5.8, ReboundsPerGame = 8.2, StealsPerGame = 1.4},
                new BasketballPlayer {Name = "Jaylen Brown", Team = "Boston Celtics", PhotoPath = "Photos/brown.jpg", PointsPerGame = 25.0, AssistsPerGame = 4.4, ReboundsPerGame = 6.6, StealsPerGame = 1.1},
                new BasketballPlayer {Name = "Luka Doncic", Team = "Dallas Mavericks", PhotoPath = "Photos/doncic.jpg", PointsPerGame = 28.1, AssistsPerGame = 7.6, ReboundsPerGame = 7.6, StealsPerGame = 1.6},
                new BasketballPlayer {Name = "Kyrie Irving", Team = "Dallas Mavericks", PhotoPath = "Photos/kyrie.jpg", PointsPerGame = 24.6, AssistsPerGame = 5.4, ReboundsPerGame = 4.6, StealsPerGame = 1.1},
                new BasketballPlayer {Name = "Kevin Durant", Team = "Phoenix Suns", PhotoPath = "Photos/durant.jpg", PointsPerGame = 27.1, AssistsPerGame = 3.3, ReboundsPerGame = 6.5, StealsPerGame = 0.7},
                new BasketballPlayer {Name = "Devin Booker", Team = "Phoenix Suns", PhotoPath = "Photos/booker.jpg", PointsPerGame = 24.2, AssistsPerGame = 6.6, ReboundsPerGame = 3.6, StealsPerGame = 1.0}
            };
        }

        // Set up the user interface components and binds them to the data source
        private void InitializeUI()
        {
            this.Text = "Basketball Trading Cards";

            // Bind the player list to the ListBox
            playerList.DataSource = players;
            playerList.DisplayMember = "Name";

            // Event handlers for CRUD buttons
            btnAdd.Click += AddPlayer;
            btnUpdate.Click += UpdatePlayer;
            btnDelete.Click += DeletePlayer;

            // Display selected player's details
            playerList.SelectedIndexChanged += (sender, e) =>
            {
                if (playerList.SelectedItem is BasketballPlayer selectedPlayer)
                {
                    bindingSource.DataSource = selectedPlayer;
                    txtPlayerName.Text = selectedPlayer.Name;
                    txtTeam.Text = selectedPlayer.Team;
                    txtPhotoPath.Text = selectedPlayer.PhotoPath;
                    txtPointsPerGame.Text = selectedPlayer.PointsPerGame.ToString();
                    txtAssistsPerGame.Text = selectedPlayer.AssistsPerGame.ToString();
                    txtReboundsPerGame.Text = selectedPlayer.ReboundsPerGame.ToString();
                    txtStealsPerGame.Text = selectedPlayer.StealsPerGame.ToString();
                    pictureBox1.ImageLocation = selectedPlayer.PhotoPath;
                    UpdateCardBackgroundColor(selectedPlayer.Team);
                }
            };
            this.Controls.Add(playerList);

            bindingSource.DataSource = players.FirstOrDefault();
            playerName.DataBindings.Add("Text", bindingSource, "Name");
            teamName.DataBindings.Add("Text", bindingSource, "Team");
            playerStats.DataBindings.Add("Text", bindingSource, "StatsSummary");
            pictureBox1.DataBindings.Add("ImageLocation", bindingSource, "PhotoPath");
        }

        // Update the form's background color based on the player's team
        private void UpdateCardBackgroundColor(string team)
        {
            switch (team)
            {
                case "Los Angeles Lakers":
                    this.BackColor = Color.RebeccaPurple;
                    break;
                case "Golden State Warriors":
                    this.BackColor = Color.Gold;
                    break;
                case "Boston Celtics":
                    this.BackColor = Color.Green;
                    break;
                case "Dallas Mavericks":
                    this.BackColor = Color.Blue;
                    break;
                case "Phoenix Suns":
                    this.BackColor = Color.Orange;
                    break;
                default:
                    this.BackColor = SystemColors.Control;
                    break;
            }
        }

        private void AddPlayer(object sender, EventArgs e)
        {
            try
            {
                var newPlayer = new BasketballPlayer
                {
                    Name = txtPlayerName.Text,
                    Team = txtTeam.Text,
                    PhotoPath = pictureBox1.Text,
                    PointsPerGame = double.Parse(txtPointsPerGame.Text),
                    AssistsPerGame = double.Parse(txtAssistsPerGame.Text),
                    ReboundsPerGame = double.Parse(txtReboundsPerGame.Text),
                    StealsPerGame = double.Parse(txtStealsPerGame.Text)
                };
                players.Add(newPlayer);
                MessageBox.Show("Player added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding player: {ex.Message}");
            }
        }

        private void UpdatePlayer(object sender, EventArgs e)
        {
            try
            {
                if (playerList.SelectedItem is BasketballPlayer selectedPlayer)
                {
                    selectedPlayer.Name = txtPlayerName.Text;
                    selectedPlayer.Team = txtTeam.Text;
                    selectedPlayer.PhotoPath = txtPhotoPath.Text;
                    selectedPlayer.PointsPerGame = double.Parse(txtPointsPerGame.Text);
                    selectedPlayer.AssistsPerGame = double.Parse(txtAssistsPerGame.Text);
                    selectedPlayer.ReboundsPerGame = double.Parse(txtReboundsPerGame.Text);
                    selectedPlayer.StealsPerGame = double.Parse(txtStealsPerGame.Text);

                    // Refresh the UI
                    players.ResetBindings();
                    MessageBox.Show("Player updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating player: {ex.Message}");
            }
        }

        private void DeletePlayer(object sender, EventArgs e)
        {
            try
            {
                if (playerList.SelectedItem is BasketballPlayer selectedPlayer)
                {
                    players.Remove(selectedPlayer);
                    MessageBox.Show("Player deleted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting player: {ex.Message}");
            }
        }
    }
}
