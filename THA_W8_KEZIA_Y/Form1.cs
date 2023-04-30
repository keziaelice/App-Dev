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
    public partial class Form1 : Form
    {
        public string connectionString = "server=localhost;uid=root;pwd=root;database=premier_league";
        public MySqlConnection sqlConnect;
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public class CustomColorTable : ProfessionalColorTable
        {
            public override Color MenuItemBorder
            {
                get { return Color.White; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(255, 55, 0, 60); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(255, 55, 0, 60); }
            }
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(255, 55, 0, 60); }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_ShowContent()
        {
            panel_Main.BackColor = Color.White;
            PictureBox pictureBox_PremierLeague = new PictureBox();
            pictureBox_PremierLeague.Image = Image.FromFile(@"assets\premierleague_text2.png");
            //pictureBox_PremierLeague.BackColor = Color.FromArgb(255, 55, 0, 60);
            pictureBox_PremierLeague.Size = new Size(200, 70);
            pictureBox_PremierLeague.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_PremierLeague.Location = new Point(307, 30);
            panel_Main.Controls.Add(pictureBox_PremierLeague);

            int teamCount = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    PictureBox pictureBox_TeamLogo = new PictureBox();
                    pictureBox_TeamLogo.Image = Image.FromFile($@"assets\{teamCount}.png");
                    pictureBox_TeamLogo.Size = new Size(65, 65);
                    pictureBox_TeamLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox_TeamLogo.Location = new Point(pictureBox_PremierLeague.Left - 268 + (j * 75), pictureBox_PremierLeague.Bottom + 35 + (i * 90));
                    panel_Main.Controls.Add(pictureBox_TeamLogo);
                    teamCount++;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(connectionString);
            this.menuStrip_Menu.RenderMode = ToolStripRenderMode.Professional;
            this.menuStrip_Menu.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
            panel_Header.BackColor = Color.FromArgb(255, 55, 0, 60);
            menuStrip_Menu.BackColor = Color.FromArgb(255, 55, 0, 60);
            menuStrip_Menu.ForeColor = Color.White;
            Form1_ShowContent();
        }

        private void pictureBox_Logo_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox_Logo_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            Form1_ShowContent();
        }

        private void pictureBox_Logo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void playerDataToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PlayerData form_PlayerData = new Form_PlayerData();
            form_PlayerData.Dock = DockStyle.Fill;
            form_PlayerData.TopLevel = false;
            form_PlayerData.ControlBox = false;
            form_PlayerData.FormBorderStyle = FormBorderStyle.None;
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(form_PlayerData);
            form_PlayerData.Show();
        }

        private void playerDataToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void showMatchDetailsToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MatchDetail form_MatchDetail = new Form_MatchDetail();
            form_MatchDetail.Dock = DockStyle.Fill;
            form_MatchDetail.TopLevel = false;
            form_MatchDetail.ControlBox = false;
            form_MatchDetail.FormBorderStyle = FormBorderStyle.None;
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(form_MatchDetail);
            form_MatchDetail.Show();
        }

        private void showMatchDetailsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
