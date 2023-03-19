using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_KEZIA_Y
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }
        public Color getbutton_Submit_TxtColor()
        {
            return button_Submit.ForeColor;
        }
        public void setbutton_Submit_TxtColor(Color button_Submit_TxtColor)
        {
            button_Submit.ForeColor = button_Submit_TxtColor;
        }
        private void button_NextForm_Click(object sender, EventArgs e)
        {
            SecondWindowForm secondWindowForm = new SecondWindowForm();
            secondWindowForm.Show();
            if (Application.OpenForms["secondWindowForm"] != null && checkBox_TrueContent.Checked)
            {
                button_Submit.Enabled = true;
            }
            else
            {
                button_Submit.Enabled = false;
            }
        }

        private void checkBox_TrueContent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TrueContent.Checked && Application.OpenForms["secondWindowForm"] != null) //secondWindowOpen == true //Application.OpenForms.OfType<SecondWindowForm>().Any()
            {
                button_Submit.Enabled = true;
            }
            else
            {
                button_Submit.Enabled = false;
            }
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" || textBox_FavArtist.Text == "")
            {
                MessageBox.Show("Enter correct input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SecondWindowForm secondWindowForm = Application.OpenForms["secondWindowForm"] as SecondWindowForm;
                secondWindowForm.setlabel_ShowContent($"Hi, my name is {textBox_Name.Text} and my favorite artist is {textBox_FavArtist.Text}");
            }
        }
    }
}
