using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace THA_W6_KEZIA_Y
{
    public partial class Form1 : Form
    {
        public int input;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            if (textBox_Input.Text != "")
            {
                input = Convert.ToInt32(textBox_Input.Text);
                if (input <= 3)
                {
                    MessageBox.Show("Input must be greater than 3!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Input.Focus();
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.size = input;
                    form2.ShowDialog();
                } 
            }
        }
    }
}
