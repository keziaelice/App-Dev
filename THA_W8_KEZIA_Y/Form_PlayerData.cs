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
    public partial class Form_PlayerData : Form
    {
        Form1 form1 = Application.OpenForms["form1"] as Form1;
        public DataTable dtTeam;
        public DataTable dtPlayer;
        public DataTable dtPersonalDetail;
        public DataTable dtPlayerStats;
        public Form_PlayerData()
        {
            InitializeComponent();
        }

        private void Form_PlayerData_Load(object sender, EventArgs e)
        {
            panel_Display.Visible = false;

            label_ChooseTeam.ForeColor = Color.FromArgb(255, 55, 0, 60);
            label_ChoosePlayer.ForeColor = Color.FromArgb(255, 55, 0, 60);
            comboBox_Team.ForeColor = Color.FromArgb(255, 55, 0, 60);
            comboBox_Player.ForeColor = Color.FromArgb(255, 55, 0, 60);
            button_Search.BackColor = Color.FromArgb(125, 55, 0, 60);
            button_Search.ForeColor = Color.White;
            button_Search.Enabled = false;

            dtTeam = new DataTable();
            form1.sqlQuery = "SELECT team_name as `Team Name`, team_id as `ID` FROM premier_league.team t;";
            form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
            form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
            form1.sqlAdapter.Fill(dtTeam);
            comboBox_Team.DataSource = dtTeam;
            comboBox_Team.DisplayMember = "Team Name";
            comboBox_Team.ValueMember = "ID";
            comboBox_Team.SelectedItem = null;

            panel_Line.BackColor = Color.FromArgb(255, 55, 0, 60);
        }

        private void comboBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Team.SelectedItem != null)
            {
                string teamID = comboBox_Team.SelectedValue.ToString();
                dtPlayer = new DataTable();
                form1.sqlQuery = $"SELECT p.player_name as `Name`, p.player_id as `ID` FROM premier_league.player p, premier_league.team t WHERE p.team_id = t.team_id AND p.team_id = '{teamID}';";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtPlayer);
                comboBox_Player.DataSource = dtPlayer;
                comboBox_Player.DisplayMember = "Name";
                comboBox_Player.ValueMember = "ID";
                comboBox_Player.SelectedItem = null;
                //dgv_Players.DataSource = dtPlayer; 
            }
            button_Search.BackColor = Color.FromArgb(125, 55, 0, 60);
            button_Search.ForeColor = Color.White;
            button_Search.Enabled = false;
        }

        private void comboBox_Player_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Player.SelectedItem != null)
            {
                button_Search.BackColor = Color.FromArgb(255, 55, 0, 60);
                button_Search.ForeColor = Color.White;
                button_Search.Enabled = true;

            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            panel_Display.Visible = true; ;
            if (comboBox_Team.SelectedItem != null && comboBox_Player.SelectedItem != null)
            {
                string playerID = comboBox_Player.SelectedValue.ToString();
                dtPersonalDetail = new DataTable();
                form1.sqlQuery = $"SELECT p.team_number as `Team Number`, p.player_name as `Name`, \r\n\tCASE \r\n        WHEN p.playing_pos = 'G' THEN \"Goalkeeper\"\r\n        WHEN p.playing_pos = 'D' THEN \"Defender\"\r\n        WHEN p.playing_pos = 'M' THEN \"Midfielder\"\r\n        WHEN p.playing_pos = 'F' THEN \"Forward\"\r\n    END as `Position`, \r\n    t.team_name as `Team Name`, n.nation as `Nationality`\r\nFROM premier_league.player p\r\nINNER JOIN premier_league.team t ON p.team_id = t.team_id AND p.player_id = '{playerID}'\r\nLEFT JOIN premier_league.nationality n ON n.nationality_id = p.nationality_id;";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtPersonalDetail);

                label_SquadNum.Text = dtPersonalDetail.Rows[0][0].ToString();
                label_Name.Text = dtPersonalDetail.Rows[0][1].ToString();
                label_Position.Text = dtPersonalDetail.Rows[0][2].ToString();
                label_Team.Text = dtPersonalDetail.Rows[0][3].ToString();
                label_Nationality.Text = dtPersonalDetail.Rows[0][4].ToString();

                dtPlayerStats = new DataTable();
                form1.sqlQuery = $"SELECT IFNULL(d.type, 'CY') as `Type`, IFNULL(count(d.type), 0) as `Count`\r\nFROM premier_league.player p\r\nLEFT JOIN premier_league.dmatch d ON p.player_id = d.player_id AND p.player_id = '{playerID}' AND d.type = 'CY'\r\nGROUP BY 1; ";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtPlayerStats);
                form1.sqlQuery = $"SELECT IFNULL(d.type, 'CR') as `Type`, IFNULL(count(d.type), 0) as `Count`\r\nFROM premier_league.player p\r\nLEFT JOIN premier_league.dmatch d ON p.player_id = d.player_id AND p.player_id = '{playerID}' AND d.type = 'CR'\r\nGROUP BY 1; ";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtPlayerStats);
                form1.sqlQuery = $"SELECT IFNULL(d.type, 'GO') as `Type`, IFNULL(count(d.type), 0) as `Count`\r\nFROM premier_league.player p\r\nLEFT JOIN premier_league.dmatch d ON p.player_id = d.player_id AND p.player_id = '{playerID}' AND d.type = 'GO'\r\nGROUP BY 1; ";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtPlayerStats);
                form1.sqlQuery = $"SELECT IFNULL(d.type, 'PM') as `Type`, IFNULL(count(d.type), 0) as `Count`\r\nFROM premier_league.player p\r\nLEFT JOIN premier_league.dmatch d ON p.player_id = d.player_id AND p.player_id = '{playerID}' AND d.type = 'PM'\r\nGROUP BY 1; ";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtPlayerStats);

                label_YellowCards.Text = dtPlayerStats.Rows[0][1].ToString();
                label_RedCards.Text = dtPlayerStats.Rows[1][1].ToString();
                label_GoalScored.Text = dtPlayerStats.Rows[2][1].ToString();
                label_PenaltyMissed.Text = dtPlayerStats.Rows[3][1].ToString();
            }
        }

        private void comboBox_Team_MouseHover(object sender, EventArgs e)
        {
            toolTip_Info.SetToolTip(comboBox_Team, $"{comboBox_Team.Text}");
        }

        private void comboBox_Player_MouseHover(object sender, EventArgs e)
        {
            toolTip_Info.SetToolTip(comboBox_Player, $"{comboBox_Player.Text}");
        }
    }
}
