namespace THA_W4_KEZIA_Y
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_SoccerTeamList = new System.Windows.Forms.Label();
            this.label_ChooseCountry = new System.Windows.Forms.Label();
            this.comboBox_ChooseCountry = new System.Windows.Forms.ComboBox();
            this.label_ChooseTeam = new System.Windows.Forms.Label();
            this.comboBox_ChooseTeam = new System.Windows.Forms.ComboBox();
            this.label_TeamCity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_TeamName = new System.Windows.Forms.Label();
            this.label_AddingTeam = new System.Windows.Forms.Label();
            this.textBox_TeamName = new System.Windows.Forms.TextBox();
            this.textBox_TeamCountry = new System.Windows.Forms.TextBox();
            this.textBox_TeamCity = new System.Windows.Forms.TextBox();
            this.button_AddTeam = new System.Windows.Forms.Button();
            this.button_AddPlayers = new System.Windows.Forms.Button();
            this.textBox_PlayerNumber = new System.Windows.Forms.TextBox();
            this.textBox_PlayerName = new System.Windows.Forms.TextBox();
            this.label_AddingPlayers = new System.Windows.Forms.Label();
            this.label_PlayerPosition = new System.Windows.Forms.Label();
            this.label_PlayerNumber = new System.Windows.Forms.Label();
            this.label_PlayerName = new System.Windows.Forms.Label();
            this.comboBox_PlayerPosition = new System.Windows.Forms.ComboBox();
            this.listBox_SoccerTeamList = new System.Windows.Forms.ListBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label_SoccerTeamList
            // 
            this.label_SoccerTeamList.AutoSize = true;
            this.label_SoccerTeamList.Location = new System.Drawing.Point(12, 39);
            this.label_SoccerTeamList.Name = "label_SoccerTeamList";
            this.label_SoccerTeamList.Size = new System.Drawing.Size(132, 20);
            this.label_SoccerTeamList.TabIndex = 0;
            this.label_SoccerTeamList.Text = "Soccer Team List";
            // 
            // label_ChooseCountry
            // 
            this.label_ChooseCountry.AutoSize = true;
            this.label_ChooseCountry.Location = new System.Drawing.Point(12, 79);
            this.label_ChooseCountry.Name = "label_ChooseCountry";
            this.label_ChooseCountry.Size = new System.Drawing.Size(131, 20);
            this.label_ChooseCountry.TabIndex = 1;
            this.label_ChooseCountry.Text = "Choose Country: ";
            // 
            // comboBox_ChooseCountry
            // 
            this.comboBox_ChooseCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ChooseCountry.FormattingEnabled = true;
            this.comboBox_ChooseCountry.Location = new System.Drawing.Point(158, 79);
            this.comboBox_ChooseCountry.Name = "comboBox_ChooseCountry";
            this.comboBox_ChooseCountry.Size = new System.Drawing.Size(165, 28);
            this.comboBox_ChooseCountry.TabIndex = 2;
            this.comboBox_ChooseCountry.SelectionChangeCommitted += new System.EventHandler(this.comboBox_ChooseCountry_SelectionChangeCommitted);
            this.comboBox_ChooseCountry.MouseHover += new System.EventHandler(this.comboBox_ChooseCountry_MouseHover);
            // 
            // label_ChooseTeam
            // 
            this.label_ChooseTeam.AutoSize = true;
            this.label_ChooseTeam.Location = new System.Drawing.Point(12, 123);
            this.label_ChooseTeam.Name = "label_ChooseTeam";
            this.label_ChooseTeam.Size = new System.Drawing.Size(116, 20);
            this.label_ChooseTeam.TabIndex = 3;
            this.label_ChooseTeam.Text = "Choose Team: ";
            // 
            // comboBox_ChooseTeam
            // 
            this.comboBox_ChooseTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ChooseTeam.FormattingEnabled = true;
            this.comboBox_ChooseTeam.Location = new System.Drawing.Point(158, 123);
            this.comboBox_ChooseTeam.Name = "comboBox_ChooseTeam";
            this.comboBox_ChooseTeam.Size = new System.Drawing.Size(165, 28);
            this.comboBox_ChooseTeam.TabIndex = 4;
            this.comboBox_ChooseTeam.SelectionChangeCommitted += new System.EventHandler(this.comboBox_ChooseTeam_SelectionChangeCommitted);
            this.comboBox_ChooseTeam.MouseHover += new System.EventHandler(this.comboBox_ChooseTeam_MouseHover);
            // 
            // label_TeamCity
            // 
            this.label_TeamCity.AutoSize = true;
            this.label_TeamCity.Location = new System.Drawing.Point(367, 147);
            this.label_TeamCity.Name = "label_TeamCity";
            this.label_TeamCity.Size = new System.Drawing.Size(87, 20);
            this.label_TeamCity.TabIndex = 8;
            this.label_TeamCity.Text = "Team City: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Team Country: ";
            // 
            // label_TeamName
            // 
            this.label_TeamName.AutoSize = true;
            this.label_TeamName.Location = new System.Drawing.Point(367, 66);
            this.label_TeamName.Name = "label_TeamName";
            this.label_TeamName.Size = new System.Drawing.Size(99, 20);
            this.label_TeamName.TabIndex = 5;
            this.label_TeamName.Text = "Team Name:";
            // 
            // label_AddingTeam
            // 
            this.label_AddingTeam.AutoSize = true;
            this.label_AddingTeam.Location = new System.Drawing.Point(509, 34);
            this.label_AddingTeam.Name = "label_AddingTeam";
            this.label_AddingTeam.Size = new System.Drawing.Size(103, 20);
            this.label_AddingTeam.TabIndex = 10;
            this.label_AddingTeam.Text = "Adding Team";
            // 
            // textBox_TeamName
            // 
            this.textBox_TeamName.Location = new System.Drawing.Point(512, 63);
            this.textBox_TeamName.Name = "textBox_TeamName";
            this.textBox_TeamName.Size = new System.Drawing.Size(165, 26);
            this.textBox_TeamName.TabIndex = 11;
            // 
            // textBox_TeamCountry
            // 
            this.textBox_TeamCountry.Location = new System.Drawing.Point(513, 103);
            this.textBox_TeamCountry.Name = "textBox_TeamCountry";
            this.textBox_TeamCountry.Size = new System.Drawing.Size(165, 26);
            this.textBox_TeamCountry.TabIndex = 12;
            // 
            // textBox_TeamCity
            // 
            this.textBox_TeamCity.Location = new System.Drawing.Point(513, 144);
            this.textBox_TeamCity.Name = "textBox_TeamCity";
            this.textBox_TeamCity.Size = new System.Drawing.Size(165, 26);
            this.textBox_TeamCity.TabIndex = 13;
            // 
            // button_AddTeam
            // 
            this.button_AddTeam.Location = new System.Drawing.Point(513, 194);
            this.button_AddTeam.Name = "button_AddTeam";
            this.button_AddTeam.Size = new System.Drawing.Size(70, 30);
            this.button_AddTeam.TabIndex = 14;
            this.button_AddTeam.Text = "Add";
            this.button_AddTeam.UseVisualStyleBackColor = true;
            this.button_AddTeam.Click += new System.EventHandler(this.button_AddTeam_Click);
            // 
            // button_AddPlayers
            // 
            this.button_AddPlayers.Location = new System.Drawing.Point(860, 194);
            this.button_AddPlayers.Name = "button_AddPlayers";
            this.button_AddPlayers.Size = new System.Drawing.Size(70, 30);
            this.button_AddPlayers.TabIndex = 22;
            this.button_AddPlayers.Text = "Add";
            this.button_AddPlayers.UseVisualStyleBackColor = true;
            this.button_AddPlayers.Click += new System.EventHandler(this.button_AddPlayers_Click);
            // 
            // textBox_PlayerNumber
            // 
            this.textBox_PlayerNumber.Location = new System.Drawing.Point(860, 103);
            this.textBox_PlayerNumber.Name = "textBox_PlayerNumber";
            this.textBox_PlayerNumber.Size = new System.Drawing.Size(165, 26);
            this.textBox_PlayerNumber.TabIndex = 20;
            // 
            // textBox_PlayerName
            // 
            this.textBox_PlayerName.Location = new System.Drawing.Point(859, 63);
            this.textBox_PlayerName.Name = "textBox_PlayerName";
            this.textBox_PlayerName.Size = new System.Drawing.Size(165, 26);
            this.textBox_PlayerName.TabIndex = 19;
            // 
            // label_AddingPlayers
            // 
            this.label_AddingPlayers.AutoSize = true;
            this.label_AddingPlayers.Location = new System.Drawing.Point(856, 34);
            this.label_AddingPlayers.Name = "label_AddingPlayers";
            this.label_AddingPlayers.Size = new System.Drawing.Size(114, 20);
            this.label_AddingPlayers.TabIndex = 18;
            this.label_AddingPlayers.Text = "Adding Players";
            // 
            // label_PlayerPosition
            // 
            this.label_PlayerPosition.AutoSize = true;
            this.label_PlayerPosition.Location = new System.Drawing.Point(714, 147);
            this.label_PlayerPosition.Name = "label_PlayerPosition";
            this.label_PlayerPosition.Size = new System.Drawing.Size(120, 20);
            this.label_PlayerPosition.TabIndex = 17;
            this.label_PlayerPosition.Text = "Player Position: ";
            // 
            // label_PlayerNumber
            // 
            this.label_PlayerNumber.AutoSize = true;
            this.label_PlayerNumber.Location = new System.Drawing.Point(714, 106);
            this.label_PlayerNumber.Name = "label_PlayerNumber";
            this.label_PlayerNumber.Size = new System.Drawing.Size(116, 20);
            this.label_PlayerNumber.TabIndex = 16;
            this.label_PlayerNumber.Text = "Player Number:";
            // 
            // label_PlayerName
            // 
            this.label_PlayerName.AutoSize = true;
            this.label_PlayerName.Location = new System.Drawing.Point(714, 66);
            this.label_PlayerName.Name = "label_PlayerName";
            this.label_PlayerName.Size = new System.Drawing.Size(102, 20);
            this.label_PlayerName.TabIndex = 15;
            this.label_PlayerName.Text = "Player Name:";
            // 
            // comboBox_PlayerPosition
            // 
            this.comboBox_PlayerPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PlayerPosition.FormattingEnabled = true;
            this.comboBox_PlayerPosition.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.comboBox_PlayerPosition.Location = new System.Drawing.Point(859, 144);
            this.comboBox_PlayerPosition.Name = "comboBox_PlayerPosition";
            this.comboBox_PlayerPosition.Size = new System.Drawing.Size(165, 28);
            this.comboBox_PlayerPosition.TabIndex = 23;
            // 
            // listBox_SoccerTeamList
            // 
            this.listBox_SoccerTeamList.FormattingEnabled = true;
            this.listBox_SoccerTeamList.ItemHeight = 20;
            this.listBox_SoccerTeamList.Location = new System.Drawing.Point(16, 181);
            this.listBox_SoccerTeamList.Name = "listBox_SoccerTeamList";
            this.listBox_SoccerTeamList.Size = new System.Drawing.Size(307, 164);
            this.listBox_SoccerTeamList.TabIndex = 25;
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(16, 362);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(90, 30);
            this.button_Remove.TabIndex = 26;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.listBox_SoccerTeamList);
            this.Controls.Add(this.comboBox_PlayerPosition);
            this.Controls.Add(this.button_AddPlayers);
            this.Controls.Add(this.textBox_PlayerNumber);
            this.Controls.Add(this.textBox_PlayerName);
            this.Controls.Add(this.label_AddingPlayers);
            this.Controls.Add(this.label_PlayerPosition);
            this.Controls.Add(this.label_PlayerNumber);
            this.Controls.Add(this.label_PlayerName);
            this.Controls.Add(this.button_AddTeam);
            this.Controls.Add(this.textBox_TeamCity);
            this.Controls.Add(this.textBox_TeamCountry);
            this.Controls.Add(this.textBox_TeamName);
            this.Controls.Add(this.label_AddingTeam);
            this.Controls.Add(this.label_TeamCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_TeamName);
            this.Controls.Add(this.comboBox_ChooseTeam);
            this.Controls.Add(this.label_ChooseTeam);
            this.Controls.Add(this.comboBox_ChooseCountry);
            this.Controls.Add(this.label_ChooseCountry);
            this.Controls.Add(this.label_SoccerTeamList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SoccerTeamList;
        private System.Windows.Forms.Label label_ChooseCountry;
        private System.Windows.Forms.ComboBox comboBox_ChooseCountry;
        private System.Windows.Forms.Label label_ChooseTeam;
        private System.Windows.Forms.ComboBox comboBox_ChooseTeam;
        private System.Windows.Forms.Label label_TeamCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_TeamName;
        private System.Windows.Forms.Label label_AddingTeam;
        private System.Windows.Forms.TextBox textBox_TeamName;
        private System.Windows.Forms.TextBox textBox_TeamCountry;
        private System.Windows.Forms.TextBox textBox_TeamCity;
        private System.Windows.Forms.Button button_AddTeam;
        private System.Windows.Forms.Button button_AddPlayers;
        private System.Windows.Forms.TextBox textBox_PlayerNumber;
        private System.Windows.Forms.TextBox textBox_PlayerName;
        private System.Windows.Forms.Label label_AddingPlayers;
        private System.Windows.Forms.Label label_PlayerPosition;
        private System.Windows.Forms.Label label_PlayerNumber;
        private System.Windows.Forms.Label label_PlayerName;
        private System.Windows.Forms.ComboBox comboBox_PlayerPosition;
        private System.Windows.Forms.ListBox listBox_SoccerTeamList;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.ToolTip toolTip_Info;
    }
}

