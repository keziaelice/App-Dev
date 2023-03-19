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
    public partial class SecondWindowForm : Form
    {
        public SecondWindowForm()
        {
            InitializeComponent();
        }
        public string getlabel_ShowContent()
        {
            return label_ShowContent.Text;
        }
        public void setlabel_ShowContent(string newContent)
        {
            label_ShowContent.Text = newContent;
        }
        private void checkBox_Agreement_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Agreement.Checked && checkBox_TrueChoice.Checked)
            {
                button_Magic.Enabled = true;
            }
            else
            {
                button_Magic.Enabled = false;
            }
        }

        private void checkBox_TrueChoice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TrueChoice.Checked && checkBox_Agreement.Checked)
            {
                button_Magic.Enabled = true;
            }
            else
            {
                button_Magic.Enabled = false;
            }
        }

        private void button_Magic_Click(object sender, EventArgs e)
        {
            if (radioButton_GreyBg.Checked == false && radioButton_BlackBg.Checked == false && radioButton_YellowBg.Checked == false && radioButton_GreenBg.Checked == false && radioButton_BlueBg.Checked == false && radioButton_BlackText.Checked == false && radioButton_PinkText.Checked == false && radioButton_PurpleText.Checked == false)
            {
                MessageBox.Show("Choose color from the radio buttons", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MainWindowForm mainWindowForm = Application.OpenForms["mainWindowForm"] as MainWindowForm;
            if (radioButton_GreyBg.Checked)
            {
                mainWindowForm.BackColor = Color.DarkGray;
            }
            if (radioButton_BlackBg.Checked)
            {
                mainWindowForm.BackColor = Color.Black;
            }
            if (radioButton_YellowBg.Checked)
            {
                mainWindowForm.BackColor = Color.LightYellow;
            }
            if (radioButton_GreenBg.Checked)
            {
                mainWindowForm.BackColor = Color.LightGreen;
            }
            if (radioButton_BlueBg.Checked)
            {
                mainWindowForm.BackColor = Color.LightSkyBlue;
            }
            if (radioButton_BlackText.Checked)
            {
                mainWindowForm.ForeColor = Color.Black;
                mainWindowForm.setbutton_Submit_TxtColor(Color.Black);
            }
            if (radioButton_PinkText.Checked)
            {
                mainWindowForm.ForeColor = Color.DeepPink;
                mainWindowForm.setbutton_Submit_TxtColor(Color.DeepPink);
            }
            if (radioButton_PurpleText.Checked)
            {
                mainWindowForm.ForeColor = Color.MediumPurple;
                mainWindowForm.setbutton_Submit_TxtColor(Color.MediumPurple);
            }
        }
    }
}
