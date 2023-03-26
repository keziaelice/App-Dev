using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W4_KEZIA_Y
{
    public partial class Form1 : Form
    {
        public class Team
        {
            public string teamName {  get; set; }
            public string teamCountry { get; set; }
            public string teamCity { get; set; }

            public List<Player> Players = new List<Player>();
            public Team()
            {

            }
            public Team(string teamName, string teamCountry, string teamCity)
            {
                this.teamName = teamName;
                this.teamCountry = teamCountry;
                this.teamCity = teamCity;
            }

            public List<Player> getPlayers()
            {
                return Players;
            }
            public void setPlayers(List<Player> Players)
            {
                this.Players = Players;
            }

            public void addPlayer(string playerName, string playerNum, string playerPos)
            {
                Player player = new Player(playerName, playerNum, playerPos);
                Players.Add(player);
            }
        }
        public class Player : Team
        {
            public string playerName { get; set; }
            public string playerNum { get; set; }
            public string playerPos { get; set; }
            public Player()
            {

            }
            public Player(string playerName, string playerNum, string playerPos)
            {
                this.playerName = playerName;
                this.playerNum = playerNum;
                this.playerPos = playerPos;
            }
        }
        public void updateComboBox_ChooseCountry()
        {
            comboBox_ChooseCountry.Items.Clear();
            comboBox_ChooseCountry.Text = "";
            foreach (Team team in Teams)
            {
                if (comboBox_ChooseCountry.Items.Contains(team.teamCountry) == false)
                {
                    comboBox_ChooseCountry.Items.Add(team.teamCountry);
                }
            }
        }
        public void updateComboBox_ChooseTeam()
        {
            comboBox_ChooseTeam.Items.Clear();
            comboBox_ChooseTeam.Text = "";
            foreach (Team team in Teams)
            {
                if (comboBox_ChooseCountry.SelectedItem.ToString() == team.teamCountry)
                {
                    comboBox_ChooseTeam.Items.Add(team.teamName);
                }
            }
        }
        public void updateListBox_SoccerTeamList()
        {
            listBox_SoccerTeamList.Items.Clear();
            foreach (Team team in Teams)
            {
                if (comboBox_ChooseTeam.SelectedItem.ToString() == team.teamName)
                {
                    foreach (Player player in team.Players)
                    {
                        listBox_SoccerTeamList.Items.Add($"({player.playerNum}) {player.playerName}, {player.playerPos}");
                    }
                }
            }
            listBox_SoccerTeamList.Sorted = true;
        }
        public Form1()
        {
            InitializeComponent();
        }
        List<Team> Teams = new List<Team>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Team team1 = new Team("Liverpool", "England", "Liverpool");
            Teams.Add(team1);
            team1.addPlayer("Alisson Becker", "01", "GK");
            team1.addPlayer("Joe Gomez", "02", "DF");
            team1.addPlayer("Ibrahima Konate", "05", "DF");
            team1.addPlayer("Kostas Tsimikas", "21", "DF");
            team1.addPlayer("Calvin Ramsay", "22", "DF");
            team1.addPlayer("Joel Matip", "32", "DF");
            team1.addPlayer("Fabinho", "03", "MF");
            team1.addPlayer("Curtis Jones", "17", "MF");
            team1.addPlayer("Arthur Melo", "29", "MF");
            team1.addPlayer("Roberto Firmino", "09", "FW");
            team1.addPlayer("Mohamed Salah", "11", "FW");

            Team team2 = new Team("Manchester City", "England", "Manchester");
            Teams.Add(team2);
            team2.addPlayer("Ederson", "31", "GK");
            team2.addPlayer("Kyle Walker", "02", "DF");
            team2.addPlayer("Ruben Dias", "03", "DF");
            team2.addPlayer("John Stones", "05", "DF");
            team2.addPlayer("Nathan Ake", "06", "DF");
            team2.addPlayer("Sergio Gomez", "21", "DF");
            team2.addPlayer("Kalvin Phillips", "04", "MF");
            team2.addPlayer("Jack Grealish", "10", "MF");
            team2.addPlayer("Rodrigo", "16", "MF");
            team2.addPlayer("Erling Haaland", "09", "FW");
            team2.addPlayer("Julian Alvarez", "19", "FW");

            Team team3 = new Team("Barcelona", "Spain", "Barcelona");
            Teams.Add(team3);
            team3.addPlayer("Inaki Pena", "13", "GK");
            team3.addPlayer("Ronald Araujo", "04", "DF");
            team3.addPlayer("Andreas Christensen", "15", "DF");
            team3.addPlayer("Marcos Alonso", "17", "DF");
            team3.addPlayer("Jordi Alba", "18", "DF");
            team3.addPlayer("Jules Kounde", "23", "DF");
            team3.addPlayer("Gavi", "06", "MF");
            team3.addPlayer("Pedri", "08", "MF");
            team3.addPlayer("Sergi Roberto", "20", "MF");
            team3.addPlayer("Ansu Fati", "10", "FW");
            team3.addPlayer("Ferran Torres", "11", "FW");

            updateComboBox_ChooseCountry();
        }
        private void comboBox_ChooseCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateComboBox_ChooseTeam();
        }

        private void comboBox_ChooseTeam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateListBox_SoccerTeamList();
        }

        private void button_AddTeam_Click(object sender, EventArgs e)
        {
            if (textBox_TeamName.Text != "" && textBox_TeamCountry.Text != "" && textBox_TeamCity.Text != "")
            {
                bool teamAlreadyExists = false;
                foreach (Team team in Teams)
                {
                    if (team.teamName == textBox_TeamName.Text)
                    {
                        teamAlreadyExists = true;
                        break;
                    }
                }
                if (teamAlreadyExists == true)
                {
                    MessageBox.Show($"{textBox_TeamName.Text} already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Team team = new Team(textBox_TeamName.Text, textBox_TeamCountry.Text, textBox_TeamCity.Text);
                    Teams.Add(team);
                    updateComboBox_ChooseCountry();
                }
                textBox_TeamName.Clear();
                textBox_TeamCountry.Clear();
                textBox_TeamCity.Clear();
            }
            else
            {
                MessageBox.Show("All fields need to be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_AddPlayers_Click(object sender, EventArgs e)
        {
            if (comboBox_ChooseTeam.Text != "")
            {
                if (textBox_PlayerName.Text != "" && textBox_PlayerNumber.Text != "" && comboBox_PlayerPosition.Text != "")
                {
                    bool nameAlreadyExists = false;
                    bool numberAlreadyExists = false;
                    foreach (Team team in Teams)
                    {
                        if (team.teamName == comboBox_ChooseTeam.Text)
                        {
                            foreach (Player player in team.Players)
                            {
                                if (player.playerName == textBox_PlayerName.Text)
                                {
                                    nameAlreadyExists = true;
                                    break;
                                }
                                if (player.playerNum == textBox_PlayerNumber.Text)
                                {
                                    numberAlreadyExists = true;
                                    break;
                                }
                            }
                            if (nameAlreadyExists == true)
                            {
                                MessageBox.Show("A player with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox_PlayerName.Clear();
                                textBox_PlayerNumber.Clear();
                                comboBox_PlayerPosition.SelectedItem = null;
                            }
                            if (numberAlreadyExists == true)
                            {
                                MessageBox.Show("A player with the same number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox_PlayerNumber.Clear();
                                textBox_PlayerNumber.Focus();
                            }
                            if (nameAlreadyExists == false && numberAlreadyExists == false)
                            {
                                team.addPlayer(textBox_PlayerName.Text, textBox_PlayerNumber.Text, comboBox_PlayerPosition.Text);
                                updateListBox_SoccerTeamList();
                                textBox_PlayerName.Clear();
                                textBox_PlayerNumber.Clear();
                                comboBox_PlayerPosition.SelectedItem = null;
                            }
                        }
                    } 
                } 
                else
                {
                    MessageBox.Show("All fields need to be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please choose the team first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listBox_SoccerTeamList.SelectedItem != null)
            {
                foreach (Team team in Teams)
                {
                    if (team.teamName == comboBox_ChooseTeam.Text)
                    {
                        if (team.Players.Count > 11)
                        {
                            foreach (Player player in team.Players)
                            {
                                if ($"({player.playerNum}) {player.playerName}, {player.playerPos}" == listBox_SoccerTeamList.SelectedItem.ToString())
                                {
                                    team.Players.Remove(player);
                                    updateListBox_SoccerTeamList();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Unable to remove players because {comboBox_ChooseTeam.Text} has less than or equal to 11 player(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please choose the player you want to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_ChooseCountry_MouseHover(object sender, EventArgs e)
        {
            toolTip_Info.SetToolTip(comboBox_ChooseCountry, $"{comboBox_ChooseCountry.Text}");
        }

        private void comboBox_ChooseTeam_MouseHover(object sender, EventArgs e)
        {
            toolTip_Info.SetToolTip(comboBox_ChooseTeam, $"{comboBox_ChooseTeam.Text}");
        }
    }
}
