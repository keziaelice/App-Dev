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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CA_W12_KEZIA_Y
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dt = new DataTable();
        DataTable dtTeam;
        DataTable dtTeam2;
        DataTable dtTeam3;
        DataTable dtNationality;
        DataTable dtManager = new DataTable();
        DataTable dtCurrentManager = new DataTable();
        string sqlQuery;
        string name;
        string id;
        string teamnum;
        string nationality;
        string pos;
        string height;
        string weight;
        string birthdate;
        string teamid;
        string teamID;
        string editID;
        string newManagerID;
        string currentManagerID;
        public Form1()
        {
            try
            {
                string connection = "server=localhost;uid=root;pwd=root;database=premier_league";
                sqlConnection = new MySqlConnection(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
            dataGridView_Player.DataSource = dt;
            dataGridView_Manager.DataSource = dtManager;
        }

        private void updatePlayer()
        {
            dt.Clear();
            try
            {
                sqlQuery = "select p.player_name `Name`, n.nation `Nationality`, p.playing_pos `Playing Position`, p.team_number `Number`, p.height `Height`, p.weight `Weight`, p.birthdate `Birthdate`, p.player_id `Player ID`\r\nfrom player p\r\nleft join nationality n on n.nationality_id = p.nationality_id where p.status = '1' order by p.player_id;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView_Player.Columns["Player ID"].Visible = false;
            dataGridView_Player.ClearSelection();
        }

        private void updateTeamPlayer(string teamID)
        {
            dt.Clear();
            try
            {
                sqlQuery = $"select p.player_name `Name`, n.nation `Nationality`, p.playing_pos `Playing Position`, p.team_number `Number`, p.height `Height`, p.weight `Weight`, p.birthdate `Birthdate`, p.player_id `Player ID`\r\nfrom player p\r\nleft join nationality n on n.nationality_id = p.nationality_id where team_id = '{teamID}' and p.status = '1' order by p.player_id;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView_Player.ClearSelection();
        }

        private void updateAvailableManagers()
        {
            dtManager.Clear();
            try
            {
                sqlQuery = "select m.manager_name `Name`, n.nation `Nationality`, m.birthdate `Birthdate`, m.manager_id `Manager ID`\r\nfrom manager m\r\nleft join nationality n on n.nationality_id = m.nationality_id\r\nwhere m.working = '0'\r\norder by m.manager_id;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtManager);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView_Manager.Columns["Manager ID"].Visible = false;
            dataGridView_Manager.ClearSelection();
        }

        private void showCurrentManager(string teamID)
        {
            label_ManagerName.Visible = true;
            label_ManagerTeamName.Visible = true;
            label_ManagerBirthdate.Visible = true;
            label_ManagerNationality.Visible = true;
            dtCurrentManager.Clear();
            try
            {
                sqlQuery = $"select m.manager_name, m.birthdate, n.nation, t.team_id, m.manager_id\r\nfrom team t\r\nleft join manager m on m.manager_id = t.manager_id\r\nleft join nationality n on n.nationality_id = m.nationality_id\r\nwhere t.team_id = '{teamID}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtCurrentManager);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            label_ManagerName.Text = dtCurrentManager.Rows[0][0].ToString();
            label_ManagerTeamName.Text = comboBox_TeamManager.Text;
            label_ManagerBirthdate.Text = Convert.ToDateTime(dtCurrentManager.Rows[0][1]).ToString("dd/MM/yyyy");
            label_ManagerNationality.Text = dtCurrentManager.Rows[0][2].ToString();
        }

        private void executeSQL(string command)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_ManagerName.Visible = false;
            label_ManagerTeamName.Visible = false;
            label_ManagerBirthdate.Visible = false;
            label_ManagerNationality.Visible = false;
            updatePlayer();
            updateAvailableManagers();

            dtNationality = new DataTable();
            sqlQuery = "SELECT nation as `Nationality`, nationality_id as `Nationality ID` FROM premier_league.nationality;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtNationality);
            comboBox_Nationality.DataSource = dtNationality;
            comboBox_Nationality.DisplayMember = "Nationality";
            comboBox_Nationality.ValueMember = "Nationality ID";
            comboBox_Nationality.SelectedItem = null;

            dtTeam = new DataTable();
            sqlQuery = "SELECT team_name as `Team Name`, team_id as `Team ID` FROM premier_league.team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam);
            comboBox_TeamName.DataSource = dtTeam;
            comboBox_TeamName.DisplayMember = "Team Name";
            comboBox_TeamName.ValueMember = "Team ID";
            comboBox_TeamName.SelectedItem = null;

            dtTeam2 = new DataTable();
            sqlQuery = "SELECT team_name as `Team Name`, team_id as `Team ID` FROM premier_league.team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam2);
            comboBox_TeamName_Update.DataSource = dtTeam2;
            comboBox_TeamName_Update.DisplayMember = "Team Name";
            comboBox_TeamName_Update.ValueMember = "Team ID";
            comboBox_TeamName_Update.SelectedItem = null;
            comboBox_TeamName_Update.SelectedIndexChanged += comboBox_TeamName_Update_SelectedIndexChanged;

            dtTeam3 = new DataTable();
            sqlQuery = "SELECT team_name as `Team Name`, team_id as `Team ID` FROM premier_league.team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam3);
            comboBox_TeamManager.DataSource = dtTeam3;
            comboBox_TeamManager.DisplayMember = "Team Name";
            comboBox_TeamManager.ValueMember = "Team ID";
            comboBox_TeamManager.SelectedItem = null;
            comboBox_TeamManager.SelectedIndexChanged += comboBox_TeamManager_SelectedIndexChanged;
        }

        private void button_AddPlayer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Name.Text) || string.IsNullOrEmpty(textBox_ID.Text) || string.IsNullOrEmpty(textBox_TeamNumber.Text) || string.IsNullOrEmpty(comboBox_Nationality.Text) || string.IsNullOrEmpty(textBox_Position.Text) || string.IsNullOrEmpty(textBox_Height.Text) || string.IsNullOrEmpty(textBox_Weight.Text) || string.IsNullOrEmpty(dateTimePicker_Birthdate.Value.ToString()) || string.IsNullOrEmpty(comboBox_TeamName.Text))
            {
                MessageBox.Show("Please complete all fields!");
            }
            else
            {
                name = textBox_Name.Text;
                id = textBox_ID.Text;
                teamnum = textBox_TeamNumber.Text;
                nationality = comboBox_Nationality.SelectedValue.ToString();
                pos = textBox_Position.Text;
                height = textBox_Height.Text;
                weight = textBox_Weight.Text;
                birthdate = dateTimePicker_Birthdate.Value.ToString("yyyy-MM-dd");
                teamid = comboBox_TeamName.SelectedValue.ToString();
                sqlQuery = $"insert into player values ('{id}', '{teamnum}', '{name}', '{nationality}', '{pos}', '{height}', '{weight}', '{birthdate}', '{teamid}', '1', '0');";
                executeSQL(sqlQuery);
                updatePlayer();
                comboBox_TeamName_Update.SelectedItem = null;
                textBox_Name.Text = "";
                textBox_ID.Text = "";
                textBox_TeamNumber.Text = "";
                comboBox_Nationality.SelectedItem = null;
                textBox_Position.Text = "";
                textBox_Height.Text = "";
                textBox_Weight.Text = "";
                dateTimePicker_Birthdate.Value = DateTime.Now;
                comboBox_TeamName.SelectedItem = null;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (comboBox_TeamName_Update.SelectedItem != null)
            {
                if (dataGridView_Player.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select the player you want to delete!");
                }
                else
                {
                    if (dataGridView_Player.Rows.Count > 11)
                    {
                        editID = dataGridView_Player.CurrentRow.Cells[7].Value.ToString();
                        sqlQuery = $"update player set status = '0' where player_id = '{editID}';";
                        executeSQL(sqlQuery);
                        updatePlayer();
                        comboBox_TeamName_Update.SelectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("The total number of players in the team must be greater than 11!");
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please select the team you want to update!");
            }
        }

        private void comboBox_TeamName_Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TeamName_Update.SelectedItem != null)
            {
                teamID = comboBox_TeamName_Update.SelectedValue.ToString();
                updateTeamPlayer(teamID);
            }
        }

        private void comboBox_TeamManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TeamManager.SelectedItem != null)
            {
                teamID = comboBox_TeamManager.SelectedValue.ToString();
                showCurrentManager(teamID);
            }
        }

        private void label_ManagerName_MouseHover(object sender, EventArgs e)
        {
            toolTip_Info.SetToolTip(label_ManagerName, $"{label_ManagerName.Text}");
        }

        private void button_EditManager_Click(object sender, EventArgs e)
        {
            if (comboBox_TeamManager.SelectedItem != null)
            {
                if (dataGridView_Manager.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select the new manager!");
                }
                else
                {
                    editID = comboBox_TeamManager.SelectedValue.ToString();
                    newManagerID = dataGridView_Manager.CurrentRow.Cells[3].Value.ToString();
                    currentManagerID = dtCurrentManager.Rows[0][4].ToString();
                    sqlQuery = $"update team set manager_id = '{newManagerID}' where team_id = '{editID}';";
                    executeSQL(sqlQuery);
                    sqlQuery = $"update manager set working = '0' where manager_id = '{currentManagerID}';";
                    executeSQL(sqlQuery);
                    sqlQuery = $"update manager set working = '1' where manager_id = '{newManagerID}';";
                    executeSQL(sqlQuery);
                    updateAvailableManagers();
                    showCurrentManager(editID);
                }
            }
            else
            {
                MessageBox.Show("Please select the team you want to update!");
            }
        }
    }
}
