using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace THA_W8_KEZIA_Y
{
    public partial class Form_MatchDetail : Form
    {
        Form1 form1 = Application.OpenForms["form1"] as Form1;
        public DataTable dtTeam;
        public DataTable dtMatch;
        public DataTable dtHomeTeamPlayers;
        public DataTable dtAwayTeamPlayers;
        public DataTable dtMatchDetails;
        public string homeTeam;
        public string awayTeam;
        public string homeTeamID;
        public string awayTeamID;
        public Form_MatchDetail()
        {
            InitializeComponent();
        }

        private void Form_MatchDetail_Load(object sender, EventArgs e)
        {
            panel_LineHT.BackColor = Color.FromArgb(255, 55, 0, 60);
            panel_LineAT.BackColor = Color.FromArgb(255, 55, 0, 60);
            panel_LineMD.BackColor = Color.FromArgb(255, 55, 0, 60);

            label_ChooseTeam.ForeColor = Color.FromArgb(255, 55, 0, 60);
            label_ChooseMatch.ForeColor = Color.FromArgb(255, 55, 0, 60);
            comboBox_Team.ForeColor = Color.FromArgb(255, 55, 0, 60);
            comboBox_Match.ForeColor = Color.FromArgb(255, 55, 0, 60);
            button_ShowDetails.BackColor = Color.FromArgb(125, 55, 0, 60);
            button_ShowDetails.ForeColor = Color.White;
            button_ShowDetails.Enabled = false;

            dtTeam = new DataTable();
            form1.sqlQuery = "SELECT team_name as `Team Name`, team_id as `ID` FROM premier_league.team t;";
            form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
            form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
            form1.sqlAdapter.Fill(dtTeam);
            comboBox_Team.DataSource = dtTeam;
            comboBox_Team.DisplayMember = "Team Name";
            comboBox_Team.ValueMember = "ID";
            comboBox_Team.SelectedItem = null;
        }

        private void comboBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_HomeTeam.Text = "Home Team: ";
            label_AwayTeam.Text = "Away Team: ";
            if (comboBox_Team.SelectedItem != null)
            {
                string teamID = comboBox_Team.SelectedValue.ToString();
                dtMatch = new DataTable();
                form1.sqlQuery = $"SELECT m.match_id as `Match ID`, t.team_name as `Team Home`, t2.team_name as `Team Away`, m.match_date as `Match Date`, t.team_id as `Home Team ID`, t2.team_id as `Away Team ID`\r\nFROM premier_league.team t\r\nCROSS JOIN premier_league.team t2 ON t.team_id = '{teamID}' OR t2.team_id = '{teamID}'\r\nINNER JOIN premier_league.match m ON t.team_id = m.team_home AND t2.team_id = m.team_away;";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtMatch);
                comboBox_Match.DataSource = dtMatch;
                comboBox_Match.DisplayMember = "Match Date";
                comboBox_Match.ValueMember = "Match ID";
                comboBox_Match.SelectedItem = null;
            }
            button_ShowDetails.BackColor = Color.FromArgb(125, 55, 0, 60);
            button_ShowDetails.ForeColor = Color.White;
            button_ShowDetails.Enabled = false;
        }

        private void comboBox_Match_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_HomeTeam.Text = "Home Team: ";
            label_AwayTeam.Text = "Away Team: ";
            if (comboBox_Match.SelectedItem != null)
            {
                for (int i = 0; i < dtMatch.Rows.Count; i++)
                {
                    if (dtMatch.Rows[i][0].ToString() == comboBox_Match.SelectedValue.ToString())
                    {
                        homeTeam = dtMatch.Rows[i][1].ToString();
                        awayTeam = dtMatch.Rows[i][2].ToString();
                        break;
                    }
                }
                label_HomeTeam.Text += homeTeam;
                label_AwayTeam.Text += awayTeam;
                button_ShowDetails.BackColor = Color.FromArgb(255, 55, 0, 60);
                button_ShowDetails.ForeColor = Color.White;
                button_ShowDetails.Enabled = true;
            }
        }

        private void button_ShowDetails_Click(object sender, EventArgs e)
        {
            if (comboBox_Team.SelectedItem != null && comboBox_Match.SelectedItem != null)
            {
                string matchID = comboBox_Match.SelectedValue.ToString();
                for (int i = 0; i < dtMatch.Rows.Count; i++)
                {
                    if (dtMatch.Rows[i][1].ToString() == homeTeam)
                    {
                        homeTeamID = dtMatch.Rows[i][4].ToString();
                        awayTeamID = dtMatch.Rows[i][5].ToString();
                        break;
                    }
                }
                dtHomeTeamPlayers = new DataTable();
                form1.sqlQuery = $"SELECT p.player_name as `Name`, \r\n\tCASE \r\n        WHEN p.playing_pos = 'G' THEN \"Goalkeeper\"\r\n        WHEN p.playing_pos = 'D' THEN \"Defender\"\r\n        WHEN p.playing_pos = 'M' THEN \"Midfielder\"\r\n        WHEN p.playing_pos = 'F' THEN \"Forward\"\r\n    END as `Position`\r\nFROM premier_league.player p\r\nWHERE p.team_id = '{homeTeamID}';";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtHomeTeamPlayers);
                dataGridView_HomeTeamPlayers.DataSource = dtHomeTeamPlayers;
                dataGridView_HomeTeamPlayers.ClearSelection();
                dataGridView_HomeTeamPlayers.EnableHeadersVisualStyles = false;
                dataGridView_HomeTeamPlayers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 55, 0, 60);
                dataGridView_HomeTeamPlayers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dtAwayTeamPlayers = new DataTable();
                form1.sqlQuery = $"SELECT p.player_name as `Name`, \r\n\tCASE \r\n        WHEN p.playing_pos = 'G' THEN \"Goalkeeper\"\r\n        WHEN p.playing_pos = 'D' THEN \"Defender\"\r\n        WHEN p.playing_pos = 'M' THEN \"Midfielder\"\r\n        WHEN p.playing_pos = 'F' THEN \"Forward\"\r\n    END as `Position`\r\nFROM premier_league.player p\r\nWHERE p.team_id = '{awayTeamID}';";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtAwayTeamPlayers);
                dataGridView_AwayTeamPlayers.DataSource = dtAwayTeamPlayers;
                dataGridView_AwayTeamPlayers.ClearSelection();
                dataGridView_AwayTeamPlayers.EnableHeadersVisualStyles = false;
                dataGridView_AwayTeamPlayers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 55, 0, 60);
                dataGridView_AwayTeamPlayers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dtMatchDetails = new DataTable();
                form1.sqlQuery = $"SELECT d.`minute` as `Minute`, t.team_name as `Team Name`, p.player_name as `Player Name`, \r\n\tCASE \r\n        WHEN d.`type` = 'CY' THEN \"Yellow Card\"\r\n        WHEN d.`type` = 'CR' THEN \"Red Card\"\r\n        WHEN d.`type` = 'GO' THEN \"Goal Scored\"\r\n        WHEN d.`type` = 'GP' THEN \"Goal Penalty\"\r\n        WHEN d.`type` = 'GW' THEN \"Own Goal\"\r\n        WHEN d.`type` = 'PM' THEN \"Penalty Missed\"\r\n    END as `Type`\r\nFROM premier_league.dmatch d\r\nLEFT JOIN premier_league.player p ON p.player_id = d.player_id\r\nLEFT JOIN premier_league.team t ON t.team_id = d.team_id\r\nWHERE d.match_id = '{matchID}';";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtMatchDetails);
                dataGridView_MatchDetails.DataSource = dtMatchDetails;
                dataGridView_MatchDetails.ClearSelection();
                dataGridView_MatchDetails.EnableHeadersVisualStyles = false;
                dataGridView_MatchDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 55, 0, 60);
                dataGridView_MatchDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
        }
    }
}
