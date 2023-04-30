namespace THA_W8_KEZIA_Y
{
    partial class Form_PlayerData
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
            this.label_ChooseTeam = new System.Windows.Forms.Label();
            this.comboBox_Team = new System.Windows.Forms.ComboBox();
            this.comboBox_Player = new System.Windows.Forms.ComboBox();
            this.label_ChoosePlayer = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.panel_Display = new System.Windows.Forms.Panel();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.label_SquadNum = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Position = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Team = new System.Windows.Forms.Label();
            this.label_Nationality = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Line = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label_YellowCards = new System.Windows.Forms.Label();
            this.label_RedCards = new System.Windows.Forms.Label();
            this.label_PenaltyMissed = new System.Windows.Forms.Label();
            this.label_GoalScored = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_Display.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ChooseTeam
            // 
            this.label_ChooseTeam.AutoSize = true;
            this.label_ChooseTeam.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChooseTeam.Location = new System.Drawing.Point(38, 35);
            this.label_ChooseTeam.Name = "label_ChooseTeam";
            this.label_ChooseTeam.Size = new System.Drawing.Size(143, 28);
            this.label_ChooseTeam.TabIndex = 0;
            this.label_ChooseTeam.Text = "Choose Team:";
            // 
            // comboBox_Team
            // 
            this.comboBox_Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Team.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Team.FormattingEnabled = true;
            this.comboBox_Team.Location = new System.Drawing.Point(197, 32);
            this.comboBox_Team.Name = "comboBox_Team";
            this.comboBox_Team.Size = new System.Drawing.Size(200, 36);
            this.comboBox_Team.TabIndex = 1;
            this.comboBox_Team.SelectedIndexChanged += new System.EventHandler(this.comboBox_Team_SelectedIndexChanged);
            this.comboBox_Team.MouseHover += new System.EventHandler(this.comboBox_Team_MouseHover);
            // 
            // comboBox_Player
            // 
            this.comboBox_Player.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Player.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Player.FormattingEnabled = true;
            this.comboBox_Player.Location = new System.Drawing.Point(612, 32);
            this.comboBox_Player.Name = "comboBox_Player";
            this.comboBox_Player.Size = new System.Drawing.Size(200, 36);
            this.comboBox_Player.TabIndex = 3;
            this.comboBox_Player.SelectedIndexChanged += new System.EventHandler(this.comboBox_Player_SelectedIndexChanged);
            this.comboBox_Player.MouseHover += new System.EventHandler(this.comboBox_Player_MouseHover);
            // 
            // label_ChoosePlayer
            // 
            this.label_ChoosePlayer.AutoSize = true;
            this.label_ChoosePlayer.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChoosePlayer.Location = new System.Drawing.Point(436, 36);
            this.label_ChoosePlayer.Name = "label_ChoosePlayer";
            this.label_ChoosePlayer.Size = new System.Drawing.Size(150, 28);
            this.label_ChoosePlayer.TabIndex = 2;
            this.label_ChoosePlayer.Text = "Choose Player:";
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(850, 28);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(100, 50);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // panel_Display
            // 
            this.panel_Display.AutoScroll = true;
            this.panel_Display.Controls.Add(this.panel2);
            this.panel_Display.Controls.Add(this.panel1);
            this.panel_Display.Controls.Add(this.label_Nationality);
            this.panel_Display.Controls.Add(this.label2);
            this.panel_Display.Controls.Add(this.label_Team);
            this.panel_Display.Controls.Add(this.label1);
            this.panel_Display.Controls.Add(this.label_Position);
            this.panel_Display.Controls.Add(this.label_Name);
            this.panel_Display.Controls.Add(this.label_SquadNum);
            this.panel_Display.Location = new System.Drawing.Point(31, 98);
            this.panel_Display.Name = "panel_Display";
            this.panel_Display.Size = new System.Drawing.Size(1158, 376);
            this.panel_Display.TabIndex = 5;
            // 
            // label_SquadNum
            // 
            this.label_SquadNum.AutoSize = true;
            this.label_SquadNum.Font = new System.Drawing.Font("72 Monospace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SquadNum.Location = new System.Drawing.Point(14, 14);
            this.label_SquadNum.Name = "label_SquadNum";
            this.label_SquadNum.Size = new System.Drawing.Size(282, 41);
            this.label_SquadNum.TabIndex = 0;
            this.label_SquadNum.Text = "Squad Number";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Ebrima", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(11, 55);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(290, 60);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Player Name";
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Position.Location = new System.Drawing.Point(15, 115);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(170, 32);
            this.label_Position.TabIndex = 2;
            this.label_Position.Text = "Player Position";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(696, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label_Team
            // 
            this.label_Team.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Team.Location = new System.Drawing.Point(697, 44);
            this.label_Team.Name = "label_Team";
            this.label_Team.Size = new System.Drawing.Size(438, 40);
            this.label_Team.TabIndex = 4;
            this.label_Team.Text = "Team Name";
            this.label_Team.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_Nationality
            // 
            this.label_Nationality.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nationality.Location = new System.Drawing.Point(697, 115);
            this.label_Nationality.Name = "label_Nationality";
            this.label_Nationality.Size = new System.Drawing.Size(438, 40);
            this.label_Nationality.TabIndex = 6;
            this.label_Nationality.Text = "Nationality";
            this.label_Nationality.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(696, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nationality";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_PenaltyMissed);
            this.panel1.Controls.Add(this.label_GoalScored);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label_RedCards);
            this.panel1.Controls.Add(this.label_YellowCards);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel_Line);
            this.panel1.Location = new System.Drawing.Point(21, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 190);
            this.panel1.TabIndex = 7;
            // 
            // panel_Line
            // 
            this.panel_Line.Location = new System.Drawing.Point(0, 0);
            this.panel_Line.Name = "panel_Line";
            this.panel_Line.Size = new System.Drawing.Size(1178, 7);
            this.panel_Line.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yellow cards";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(21, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 7);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Red cards";
            // 
            // label_YellowCards
            // 
            this.label_YellowCards.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_YellowCards.Location = new System.Drawing.Point(351, 82);
            this.label_YellowCards.Name = "label_YellowCards";
            this.label_YellowCards.Size = new System.Drawing.Size(145, 32);
            this.label_YellowCards.TabIndex = 10;
            this.label_YellowCards.Text = "0";
            this.label_YellowCards.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_RedCards
            // 
            this.label_RedCards.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RedCards.Location = new System.Drawing.Point(351, 124);
            this.label_RedCards.Name = "label_RedCards";
            this.label_RedCards.Size = new System.Drawing.Size(145, 32);
            this.label_RedCards.TabIndex = 11;
            this.label_RedCards.Text = "0";
            this.label_RedCards.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_PenaltyMissed
            // 
            this.label_PenaltyMissed.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PenaltyMissed.Location = new System.Drawing.Point(942, 124);
            this.label_PenaltyMissed.Name = "label_PenaltyMissed";
            this.label_PenaltyMissed.Size = new System.Drawing.Size(145, 32);
            this.label_PenaltyMissed.TabIndex = 15;
            this.label_PenaltyMissed.Text = "0";
            this.label_PenaltyMissed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_GoalScored
            // 
            this.label_GoalScored.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GoalScored.Location = new System.Drawing.Point(942, 82);
            this.label_GoalScored.Name = "label_GoalScored";
            this.label_GoalScored.Size = new System.Drawing.Size(145, 32);
            this.label_GoalScored.TabIndex = 14;
            this.label_GoalScored.Text = "0";
            this.label_GoalScored.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(607, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 32);
            this.label10.TabIndex = 13;
            this.label10.Text = "Penalty missed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(607, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 32);
            this.label11.TabIndex = 12;
            this.label11.Text = "Goal scored";
            // 
            // Form_PlayerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 514);
            this.Controls.Add(this.panel_Display);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.comboBox_Player);
            this.Controls.Add(this.label_ChoosePlayer);
            this.Controls.Add(this.comboBox_Team);
            this.Controls.Add(this.label_ChooseTeam);
            this.Name = "Form_PlayerData";
            this.Text = "Form_PlayerData";
            this.Load += new System.EventHandler(this.Form_PlayerData_Load);
            this.panel_Display.ResumeLayout(false);
            this.panel_Display.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ChooseTeam;
        private System.Windows.Forms.ComboBox comboBox_Team;
        private System.Windows.Forms.ComboBox comboBox_Player;
        private System.Windows.Forms.Label label_ChoosePlayer;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Panel panel_Display;
        private System.Windows.Forms.ToolTip toolTip_Info;
        private System.Windows.Forms.Label label_SquadNum;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Team;
        private System.Windows.Forms.Label label_Nationality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Line;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_PenaltyMissed;
        private System.Windows.Forms.Label label_GoalScored;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_RedCards;
        private System.Windows.Forms.Label label_YellowCards;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}