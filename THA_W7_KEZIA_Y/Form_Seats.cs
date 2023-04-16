using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_KEZIA_Y
{
    public partial class Form_Seats : Form
    {
        public int movieIndex;
        public int scheduleIndex;
        public string time;
        public List<string> unavailableSeats = new List<string>();
        Form_MainForm form_mainForm = Application.OpenForms["form_mainForm"] as Form_MainForm;
        public List<Button> buttonList = new List<Button>();
        public List<string> chosenSeats = new List<string>();
        public Label label_ChosenSeats;

        public Form_Seats(int movieIndex, int scheduleIndex, string time)
        {
            this.movieIndex = movieIndex;
            this.scheduleIndex = scheduleIndex;
            this.time = time;
            InitializeComponent();
        }

        private void Form_Seats_Load(object sender, EventArgs e)
        {
            Label label_Time = new Label();
            label_Time.Text = $"Time: {time}";
            label_Time.AutoSize = true;
            label_Time.Font = new Font("Ebrima", 11);
            label_Time.Location = new Point(15, 95);
            this.Controls.Add(label_Time);

            Button button_Avail = new Button();
            button_Avail.Size = new Size(30, 30);
            button_Avail.BackColor = Color.Green;
            button_Avail.Enabled = false;
            button_Avail.Location = new Point(15, label_Time.Bottom + 10);
            this.Controls.Add(button_Avail);
            Label label_Avail = new Label();
            label_Avail.AutoSize = true;
            label_Avail.Text = "Available";
            label_Avail.Font = new Font("Ebrima", 11);
            label_Avail.Location = new Point(button_Avail.Right + 5, label_Time.Bottom + 13);
            this.Controls.Add(label_Avail);

            Button button_Reserved = new Button();
            button_Reserved.Size = new Size(30, 30);
            button_Reserved.BackColor = Color.Firebrick;
            button_Reserved.Enabled = false;
            button_Reserved.Location = new Point(label_Avail.Right + 20, label_Time.Bottom + 10);
            this.Controls.Add(button_Reserved);
            Label label_Unavail = new Label();
            label_Unavail.AutoSize = true;
            label_Unavail.Text = "Reserved";
            label_Unavail.Font = new Font("Ebrima", 11);
            label_Unavail.Location = new Point(button_Reserved.Right + 5, label_Time.Bottom + 13);
            this.Controls.Add(label_Unavail);

            Button button_YourChoice = new Button();
            button_YourChoice.Size = new Size(30, 30);
            button_YourChoice.BackColor = Color.Gold;
            button_YourChoice.Enabled = false;
            button_YourChoice.Location = new Point(label_Unavail.Right + 20, label_Time.Bottom + 10);
            this.Controls.Add(button_YourChoice);
            Label label_YourChoice = new Label();
            label_YourChoice.AutoSize = true;
            label_YourChoice.Text = "Your Choice";
            label_YourChoice.Font = new Font("Ebrima", 11);
            label_YourChoice.Location = new Point(button_YourChoice.Right + 5, label_Time.Bottom + 13);
            this.Controls.Add(label_YourChoice);

            Label label_Title = new Label();
            label_Title.Text = form_mainForm.title[movieIndex];
            label_Title.Size = new Size(839, 30);
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            label_Title.Location = new Point(0, label_YourChoice.Bottom + 15);
            label_Title.Font = new Font("Ebrima", 16, FontStyle.Bold);
            this.Controls.Add(label_Title);

            int buttonTag = 0;
            List<string> abc = new List<string>(){"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(40, 40);
                    button.Location = new Point(j * 40 + 218, i * 40 + label_Title.Bottom + 10);
                    button.BackColor = Color.Green;
                    button.ForeColor = Color.White;
                    button.Tag = buttonTag;
                    button.Text = abc[i] + (j+1);
                    button.Click += button_Click;
                    buttonTag++;
                    buttonList.Add(button);
                    this.Controls.Add(button);
                }
            }

            Label label_Screen = new Label();
            label_Screen.Text = "-- SCREEN AREA --";
            label_Screen.Size = new Size(400, 30);
            label_Screen.TextAlign = ContentAlignment.MiddleCenter;
            label_Screen.Location = new Point(218, label_Title.Bottom + 410);
            label_Screen.Font = new Font("Ebrima", 11, FontStyle.Bold);
            this.Controls.Add(label_Screen);

            label_ChosenSeats = new Label();
            label_ChosenSeats.Text = "Chosen seats: ";
            label_ChosenSeats.Size = new Size(800, 60);
            label_ChosenSeats.Location = new Point(15, label_Screen.Bottom + 10);
            label_ChosenSeats.Font = new Font("Ebrima", 11);
            this.Controls.Add(label_ChosenSeats);

            Button button_Reset = new Button();
            button_Reset.Size = new Size(85, 35);
            button_Reset.Text = "Reset";
            button_Reset.Font = new Font("Ebrima", 11);
            button_Reset.BackColor = Color.LightGray;
            button_Reset.Location = new Point(15, label_ChosenSeats.Bottom + 10);
            button_Reset.Click += button_Reset_Click;
            button_Reset.MouseEnter += button_Reset_MouseEnter;
            button_Reset.MouseLeave += button_Reset_MouseLeave;
            this.Controls.Add(button_Reset);

            Button button_Reserve = new Button();
            button_Reserve.Size = new Size(85, 35);
            button_Reserve.Text = "Reserve";
            button_Reserve.Font = new Font("Ebrima", 11);
            button_Reserve.BackColor = Color.FromArgb(255, 0, 83, 80);
            button_Reserve.ForeColor = Color.White;
            button_Reserve.Location = new Point(label_Title.Right - 100, label_ChosenSeats.Bottom + 10);
            button_Reserve.Click += button_Reserve_Click;
            button_Reserve.MouseEnter += button_Reserve_MouseEnter;
            button_Reserve.MouseLeave += button_Reserve_MouseLeave;
            this.Controls.Add(button_Reserve);

            Panel panel_Footer = new Panel();
            panel_Footer.Dock = DockStyle.Bottom;
            panel_Footer.Height = 20;
            this.Controls.Add(panel_Footer);

            string[] parts = form_mainForm.randomSeats[scheduleIndex, movieIndex].Split(',');
            if (parts[0] == "false")
            {
                form_mainForm.randomSeats[scheduleIndex, movieIndex] = "true,";
                Random rnd = new Random();
                int occupancyPercentage = rnd.Next(0, 71);
                for (int i = 0; i < occupancyPercentage; i++)
                {
                    int position = rnd.Next(0, 100);
                    form_mainForm.randomSeats[scheduleIndex, movieIndex] += $"{position},";
                }
            }

            string[] parts2 = form_mainForm.randomSeats[scheduleIndex, movieIndex].Split(',');
            unavailableSeats.Clear();
            for (int i = 1; i < parts2.Length; i++)
            {
                unavailableSeats.Add(parts2[i]);
            }
            foreach (string position in unavailableSeats)
            {
                foreach (Button button in buttonList)
                {
                    if (button.Tag.ToString() == position)
                    {
                        button.BackColor = Color.Firebrick;
                        button.ForeColor = Color.White;
                        button.Enabled = false;
                        break;
                    }
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.Gold;
                chosenSeats.Add(button.Text);
            }
            else if (button.BackColor == Color.Gold)
            {
                button.BackColor = Color.Green;
                chosenSeats.Remove(button.Text);
            }
            if (chosenSeats.Count > 0)
            {
                label_ChosenSeats.Text = "Chosen seats:";
                foreach (string position in chosenSeats)
                {
                    label_ChosenSeats.Text += " " + position;
                    if (chosenSeats.IndexOf(position) != chosenSeats.Count - 1)
                    {
                        label_ChosenSeats.Text += ",";
                    }
                }
            }
            else if (chosenSeats.Count == 0)
            {
                label_ChosenSeats.Text = "Chosen seats: ";
            }
        }

        private void button_Reset_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset the seats’ availability?", "Reset Availability", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                form_mainForm.randomSeats[scheduleIndex, movieIndex] = "true,";
                label_ChosenSeats.Text = "Chosen seats: ";
                foreach (Button seat in buttonList)
                {
                    if (seat.BackColor == Color.Firebrick || seat.BackColor == Color.Gold)
                    {
                        seat.BackColor = Color.Green;
                        seat.ForeColor = Color.White;
                        seat.Enabled = true;
                    }
                }
            }
        }

        private void button_Reset_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void button_Reserve_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_Reserve_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (chosenSeats.Count == 0)
            {
                MessageBox.Show("You haven't chosen any seats!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (chosenSeats.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to reserve these seat(s)?", "Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (string position in chosenSeats)
                    {
                        foreach (Button seat in buttonList)
                        {
                            if (seat.Text == position)
                            {
                                seat.BackColor = Color.Firebrick;
                                seat.ForeColor = Color.White;
                                seat.Enabled = false;
                                form_mainForm.randomSeats[scheduleIndex, movieIndex] += $"{seat.Tag},";
                            }
                        }
                    }
                    chosenSeats.Clear();
                    label_ChosenSeats.Text = "Chosen seats: ";
                    MessageBox.Show("Reservation confirmed!");
                }
            }
        }

        private void button_Reserve_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
