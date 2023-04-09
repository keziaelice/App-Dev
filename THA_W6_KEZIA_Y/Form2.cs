using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace THA_W6_KEZIA_Y
{
    public partial class Form2 : Form
    {
        public int size = 0;
        bool wordFound = false;
        bool currentRowFull = true;
        bool win = true;
        int currentRow = 0;
        Button[,] buttons;
        List<string> wordList = new List<string>();
        Random rnd = new Random();
        string word;
        string guess;
        List<int> indexList = new List<int>();
        List<Button> keyboard = new List<Button>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(@"Wordle Word List.txt");
            string text = streamReader.ReadToEnd();
            streamReader.Close();
            string[] words = text.Split(',');
            foreach (string word in words)
            {
                wordList.Add(word);
            }
            word = wordList[rnd.Next(wordList.Count)].ToUpper();
            //MessageBox.Show(word);
            buttons = new Button[5, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(j * 65 + 20, i * 65 + 20);
                    button.Size = new Size(60, 60);
                    button.Tag = j.ToString() + "," + i.ToString();
                    button.BackColor = Color.White;
                    buttons[j,i] = button;
                    Controls.Add(button);
                }
            }
        }

        private void keyboard_Click(object sender, EventArgs e)
        {
            if (currentRow < size)
            {
                Button button = sender as Button;
                keyboard.Add(button);
                for (int i = 0; i < 5; i++)
                {
                    if (buttons[i, currentRow].Text == "")
                    {
                        buttons[i, currentRow].Text = button.Text;
                        buttons[i, currentRow].Font = new Font("Courier New", 20, FontStyle.Bold);
                        break;
                    }
                } 
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (currentRow < size)
            {
                for (int i = 4; i >= 0; i--)
                {
                    if (buttons[i, currentRow].Text != "")
                    {
                        buttons[i, currentRow].Text = "";
                        break;
                    }
                } 
            }
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            if (currentRow < size)
            {
                win = true;
                indexList.Clear();
                guess = "";
                wordFound = false;
                currentRowFull = true;
                for (int i = 0; i < 5; i++)
                {
                    if (buttons[i, currentRow].Text == "")
                    {
                        currentRowFull = false;
                        break;
                    }
                }
                if (currentRowFull == false)
                {
                    MessageBox.Show("Too short");
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        guess += buttons[i, currentRow].Text;
                    }
                    foreach (string word in wordList)
                    {
                        if (word.ToUpper() == guess)
                        {
                            wordFound = true;
                            break;
                        }
                    }
                    if (wordFound == false)
                    {
                        MessageBox.Show("Word not found");
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (word[i] == guess[i])
                            {
                                buttons[i, currentRow].BackColor = Color.LimeGreen;
                                buttons[i, currentRow].ForeColor = Color.White;
                                indexList.Add(i);
                                foreach (Button button in keyboard)
                                {
                                    if (button.Text == guess[i].ToString())
                                    {
                                        button.BackColor = Color.LimeGreen;
                                        button.ForeColor = Color.White;
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (indexList.Contains(j) == false)
                                {
                                    if (guess[i] == word[j] && buttons[i, currentRow].BackColor == Color.White)
                                    {
                                        buttons[i, currentRow].BackColor = Color.Gold;
                                        buttons[i, currentRow].ForeColor = Color.White;
                                        indexList.Add(j);
                                        foreach (Button button in keyboard)
                                        {
                                            if (button.Text == guess[i].ToString() && button.BackColor != Color.LimeGreen)
                                            {
                                                button.BackColor = Color.Gold;
                                                button.ForeColor = Color.White;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            if (word.Contains(guess[i]) == false)
                            {
                                buttons[i, currentRow].BackColor = Color.DarkGray;
                                buttons[i, currentRow].ForeColor = Color.White;
                                foreach (Button button in keyboard)
                                {
                                    if (button.Text == guess[i].ToString())
                                    {
                                        button.BackColor = Color.DarkGray;
                                        button.ForeColor = Color.White;
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            if (buttons[i, currentRow].BackColor == Color.White)
                            {
                                buttons[i, currentRow].BackColor = Color.DarkGray;
                                buttons[i, currentRow].ForeColor = Color.White;
                            }
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            if (buttons[i, currentRow].BackColor != Color.LimeGreen)
                            {
                                win = false;
                                break;
                            }
                        }
                        currentRow++;
                        if (win == true)
                        {
                            MessageBox.Show("You Won!");
                            currentRow = size + 1;
                        }
                        else if (win == false && currentRow >= size)
                        {
                            MessageBox.Show($"You Lost! The answer was: {word}");
                        }
                    }
                } 
            }
        }
    }
}
