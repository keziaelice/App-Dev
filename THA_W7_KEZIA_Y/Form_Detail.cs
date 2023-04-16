using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_KEZIA_Y
{
    public partial class Form_Detail : Form
    {
        public int movieIndex;
        public int scheduleIndex;
        public string time;
        public List<string> directory;
        public List<string> title;
        public List<string> year;
        public List<string> rate;
        public List<string> genre;
        public List<string> duration;
        public List<string> synopsis;

        public List<string> schedule = new List<string>()
        {
            "10:15", "12:45", "15:15", "17:45", "20:15"
        };

        Form_MainForm form_mainForm = Application.OpenForms["form_mainForm"] as Form_MainForm;

        public void openForm_Seats(int movieIndex, int scheduleIndex, string time)
        {
            this.movieIndex = movieIndex;
            this.scheduleIndex = scheduleIndex;
            this.time = time;
            Form_Seats form_Seats = new Form_Seats(movieIndex, scheduleIndex, time);
            form_Seats.Dock = DockStyle.Fill;
            form_Seats.TopLevel = false;
            form_Seats.ControlBox = false;
            form_Seats.FormBorderStyle = FormBorderStyle.None;
            form_mainForm.panel_Main.Controls.Clear();
            form_mainForm.panel_Main.Controls.Add(form_Seats);
            form_Seats.AutoScroll = true;
            form_Seats.Show();
        }

        public Form_Detail(int movieIndex, List<string> directory, List<string> title, List<string> year, List<string> rate, List<string> genre, List<string> duration, List<string> synopsis)
        {
            this.movieIndex = movieIndex;
            this.directory = directory;
            this.title = title;
            this.year = year;
            this.rate = rate;
            this.genre = genre;
            this.duration = duration;
            this.synopsis = synopsis;
            InitializeComponent();
        }

        private void Form_Detail_Load(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile($@"{directory[movieIndex]}");
            pictureBox.Size = new Size(167, 250);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Location = new Point(27, 102);
            this.Controls.Add(pictureBox);

            Label label_Title = new Label();
            label_Title.Text = title[movieIndex];
            label_Title.AutoSize = true;
            label_Title.Location = new Point(pictureBox.Right + 10, pictureBox.Top);
            label_Title.Font = new Font("Ebrima", 20, FontStyle.Bold);
            label_Title.ForeColor = Color.FromArgb(255, 0, 83, 80);
            this.Controls.Add(label_Title);

            Button btn_Rate = new Button();
            btn_Rate.Text = rate[movieIndex];
            btn_Rate.Enabled = false;
            btn_Rate.Location = new Point(label_Title.Right + 5, label_Title.Top + 8);
            btn_Rate.Size = new Size(51, 25);
            btn_Rate.BackColor = Color.Transparent;
            btn_Rate.ForeColor = Color.Black;
            this.Controls.Add(btn_Rate);

            Label label_GenreDuration = new Label();
            label_GenreDuration.Text = genre[movieIndex] + " • " + duration[movieIndex];
            label_GenreDuration.AutoSize = true;
            label_GenreDuration.Location = new Point(pictureBox.Right + 15, label_Title.Bottom);
            label_GenreDuration.Font = new Font("Ebrima", 10);
            this.Controls.Add(label_GenreDuration);

            Label label_SynopsisTitle = new Label();
            label_SynopsisTitle.Text = "Synopsis";
            label_SynopsisTitle.AutoSize = true;
            label_SynopsisTitle.Location = new Point(pictureBox.Right + 15, label_GenreDuration.Bottom + 15);
            label_SynopsisTitle.Font = new Font("Ebrima", 12, FontStyle.Bold);
            this.Controls.Add(label_SynopsisTitle);

            Label label_Synopsis = new Label();
            label_Synopsis.Text = synopsis[movieIndex];
            label_Synopsis.Size = new Size(625, 160);
            label_Synopsis.Location = new Point(pictureBox.Right + 15, label_SynopsisTitle.Bottom);
            label_Synopsis.Font = new Font("Ebrima", 11);
            this.Controls.Add(label_Synopsis);

            Label label_Buy = new Label();
            label_Buy.Text = "Buy Ticket";
            label_Buy.AutoSize = true;
            label_Buy.Location = new Point(pictureBox.Left, pictureBox.Bottom + 15);
            label_Buy.Font = new Font("Ebrima", 12, FontStyle.Bold);
            this.Controls.Add(label_Buy);

            if (form_mainForm.randomSchedule[movieIndex] == false)
            {
                Random rnd = new Random();
                int scheduleCount = rnd.Next(3, 6);
                form_mainForm.scheduleCountList[movieIndex] = scheduleCount;
                form_mainForm.randomSchedule[movieIndex] = true;
            }
            for (int i = 0; i < form_mainForm.scheduleCountList[movieIndex]; i++)
            {
                Button button_Schedule = new Button();
                button_Schedule.Text = schedule[i];
                button_Schedule.Location = new Point(label_Buy.Left + i * 100, label_Buy.Bottom + 5);
                button_Schedule.AutoSize = true;
                button_Schedule.Font = new Font("Ebrima", 11);
                button_Schedule.BackColor = Color.White;
                button_Schedule.ForeColor = Color.Black;
                button_Schedule.Tag = i;
                button_Schedule.Click += button_Schedule_Click;
                button_Schedule.MouseEnter += button_Schedule_MouseEnter;
                button_Schedule.MouseLeave += button_Schedule_MouseLeave;
                this.Controls.Add(button_Schedule);
            }
        }

        private void button_Schedule_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_Schedule_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            scheduleIndex = Convert.ToInt32(button.Tag.ToString());
            string time = button.Text;
            openForm_Seats(movieIndex, scheduleIndex, time);
        }

        private void button_Schedule_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
