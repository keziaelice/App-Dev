using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace THA_W7_KEZIA_Y
{
    public partial class Form_MainForm : Form
    {
        public int movieIndex;
        public List<string> directory = new List<string>();
        public List<string> title = new List<string>();
        public List<string> year = new List<string>();
        public List<string> rate = new List<string>();
        public List<string> genre = new List<string>();
        public List<string> duration = new List<string>();
        public List<string> synopsis = new List<string>();
        public List<bool> randomSchedule = new List<bool>();
        public List<int> scheduleCountList = new List<int>();
        public string[,] randomSeats;
        public Panel panel_Main;

        public void showMovieList()
        {
            int item = 0;
            int row = 0;
            for (int i = 0; i < title.Count; i++)
            {
                if (item % 4 == 0)
                {
                    item = 0;
                    row++;
                }
                PictureBox pb_Poster = new PictureBox();
                pb_Poster.Tag = i;
                pb_Poster.Image = Image.FromFile($@"{directory[i]}");
                pb_Poster.Size = new Size(167, 250);
                pb_Poster.SizeMode = PictureBoxSizeMode.Zoom;
                pb_Poster.Location = new Point(item * 205 + 27, (row - 1) * 345 + 102);
                pb_Poster.Click += pb_Poster_Click;
                pb_Poster.MouseEnter += movie_MouseEnter;
                pb_Poster.MouseLeave += movie_MouseLeave;
                panel_Main.Controls.Add(pb_Poster);

                Label label_Title = new Label();
                label_Title.Tag = i;
                label_Title.Text = title[i];
                label_Title.Font = new Font("Ebrima", 12, FontStyle.Bold);
                label_Title.Size = new Size(pb_Poster.Size.Width - 20, 50);
                label_Title.Location = new Point(pb_Poster.Left + 10, pb_Poster.Bottom + 5);
                label_Title.TextAlign = ContentAlignment.TopCenter;
                label_Title.Click += label_Title_Click;
                label_Title.MouseEnter += movie_MouseEnter;
                label_Title.MouseLeave += movie_MouseLeave;
                panel_Main.Controls.Add(label_Title);

                Button button_Rate = new Button();
                button_Rate.Enabled = false;
                button_Rate.Text = rate[i];
                button_Rate.BackColor = Color.Transparent;
                button_Rate.ForeColor = Color.Black;
                button_Rate.Size = new Size(51, 25);
                button_Rate.Location = new Point(pb_Poster.Left + 58, label_Title.Bottom);
                panel_Main.Controls.Add(button_Rate);

                item++;
            }
        }
        public void openForm_Detail(int movieIndex)
        {
            
            this.movieIndex = movieIndex;
            Form_Detail form_Detail = new Form_Detail(movieIndex, directory, title, year, rate, genre, duration, synopsis);
            form_Detail.Dock = DockStyle.Fill;
            form_Detail.TopLevel = false;
            form_Detail.ControlBox = false;
            form_Detail.FormBorderStyle = FormBorderStyle.None;
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(form_Detail);
            form_Detail.Show();
        }
        public Form_MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel panel_Header = new Panel();
            panel_Header.BackColor = Color.FromArgb(255, 0, 83, 80);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Height = 80;
            this.Controls.Add(panel_Header);

            PictureBox pb_Home = new PictureBox();
            pb_Home.Image = Image.FromFile(@"assets\home.png");
            pb_Home.Size = new Size(30, 80);
            pb_Home.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Home.Location = new Point(23, 0);
            pb_Home.MouseEnter += pb_Home_MouseEnter;
            pb_Home.Click += pb_Home_Click;
            pb_Home.MouseLeave += pb_Home_MouseLeave;
            panel_Header.Controls.Add(pb_Home);

            PictureBox pb_Logo = new PictureBox();
            pb_Logo.Image = Image.FromFile(@"assets\logo.png");
            pb_Logo.Size = new Size(175, 80);
            pb_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Logo.Location = new Point(60, 0);
            panel_Header.Controls.Add(pb_Logo);

            panel_Main = new Panel();
            panel_Main.AutoScroll = true;
            panel_Main.SetAutoScrollMargin(0, 80);
            panel_Main.BackColor = Color.White;
            panel_Main.Dock = DockStyle.Fill;
            this.Controls.Add(panel_Main);

            using (StreamReader streamReader = new StreamReader(@"assets\movie list.txt"))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 7)
                    {
                        directory.Add(parts[0]);
                        title.Add(parts[1]);
                        year.Add(parts[2]);
                        rate.Add(parts[3]);
                        genre.Add(parts[4]);
                        duration.Add(parts[5]);
                        synopsis.Add(parts[6]);
                    }
                }
            }

            randomSeats = new string[5, title.Count];
            for (int i = 0; i < title.Count; i++)
            {
                randomSchedule.Add(false);
                scheduleCountList.Add(0);
                for (int j = 0; j < 5; j++)
                {
                    randomSeats[j, i] = "false,";
                }
            }


            showMovieList();
        }

        private void pb_Home_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pb_Home_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            showMovieList();
        }

        private void pb_Home_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void movie_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pb_Poster_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            movieIndex = Convert.ToInt32(pb.Tag.ToString());
            openForm_Detail(movieIndex);
        }

        private void label_Title_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            movieIndex = Convert.ToInt32(label.Tag.ToString());
            openForm_Detail(movieIndex);
        }

        private void movie_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
