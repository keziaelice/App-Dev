namespace THA_W8_KEZIA_Y
{
    partial class Form_MatchDetail
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
            this.label_HomeTeam = new System.Windows.Forms.Label();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Display = new System.Windows.Forms.Panel();
            this.button_ShowDetails = new System.Windows.Forms.Button();
            this.comboBox_Match = new System.Windows.Forms.ComboBox();
            this.label_ChooseMatch = new System.Windows.Forms.Label();
            this.comboBox_Team = new System.Windows.Forms.ComboBox();
            this.label_ChooseTeam = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_LineHT = new System.Windows.Forms.Panel();
            this.panel_LineAT = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_AwayTeam = new System.Windows.Forms.Label();
            this.dataGridView_HomeTeamPlayers = new System.Windows.Forms.DataGridView();
            this.dataGridView_AwayTeamPlayers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_MatchDetails = new System.Windows.Forms.DataGridView();
            this.panel_LineMD = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Display.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HomeTeamPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AwayTeamPlayers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatchDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label_HomeTeam
            // 
            this.label_HomeTeam.AutoSize = true;
            this.label_HomeTeam.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HomeTeam.Location = new System.Drawing.Point(14, 21);
            this.label_HomeTeam.Name = "label_HomeTeam";
            this.label_HomeTeam.Size = new System.Drawing.Size(165, 32);
            this.label_HomeTeam.TabIndex = 8;
            this.label_HomeTeam.Text = "Home Team: ";
            // 
            // panel_Display
            // 
            this.panel_Display.AutoScroll = true;
            this.panel_Display.Controls.Add(this.panel1);
            this.panel_Display.Controls.Add(this.panel3);
            this.panel_Display.Controls.Add(this.panel2);
            this.panel_Display.Location = new System.Drawing.Point(32, 104);
            this.panel_Display.Name = "panel_Display";
            this.panel_Display.Size = new System.Drawing.Size(1180, 376);
            this.panel_Display.TabIndex = 11;
            // 
            // button_ShowDetails
            // 
            this.button_ShowDetails.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShowDetails.Location = new System.Drawing.Point(851, 34);
            this.button_ShowDetails.Name = "button_ShowDetails";
            this.button_ShowDetails.Size = new System.Drawing.Size(155, 50);
            this.button_ShowDetails.TabIndex = 10;
            this.button_ShowDetails.Text = "Show Details";
            this.button_ShowDetails.UseVisualStyleBackColor = true;
            this.button_ShowDetails.Click += new System.EventHandler(this.button_ShowDetails_Click);
            // 
            // comboBox_Match
            // 
            this.comboBox_Match.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Match.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Match.FormattingEnabled = true;
            this.comboBox_Match.Location = new System.Drawing.Point(613, 38);
            this.comboBox_Match.Name = "comboBox_Match";
            this.comboBox_Match.Size = new System.Drawing.Size(200, 36);
            this.comboBox_Match.TabIndex = 9;
            this.comboBox_Match.SelectedIndexChanged += new System.EventHandler(this.comboBox_Match_SelectedIndexChanged);
            // 
            // label_ChooseMatch
            // 
            this.label_ChooseMatch.AutoSize = true;
            this.label_ChooseMatch.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChooseMatch.Location = new System.Drawing.Point(437, 42);
            this.label_ChooseMatch.Name = "label_ChooseMatch";
            this.label_ChooseMatch.Size = new System.Drawing.Size(151, 28);
            this.label_ChooseMatch.TabIndex = 8;
            this.label_ChooseMatch.Text = "Choose Match:";
            // 
            // comboBox_Team
            // 
            this.comboBox_Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Team.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Team.FormattingEnabled = true;
            this.comboBox_Team.Location = new System.Drawing.Point(198, 38);
            this.comboBox_Team.Name = "comboBox_Team";
            this.comboBox_Team.Size = new System.Drawing.Size(200, 36);
            this.comboBox_Team.TabIndex = 7;
            this.comboBox_Team.SelectedIndexChanged += new System.EventHandler(this.comboBox_Team_SelectedIndexChanged);
            // 
            // label_ChooseTeam
            // 
            this.label_ChooseTeam.AutoSize = true;
            this.label_ChooseTeam.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChooseTeam.Location = new System.Drawing.Point(39, 41);
            this.label_ChooseTeam.Name = "label_ChooseTeam";
            this.label_ChooseTeam.Size = new System.Drawing.Size(143, 28);
            this.label_ChooseTeam.TabIndex = 6;
            this.label_ChooseTeam.Text = "Choose Team:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView_HomeTeamPlayers);
            this.panel2.Controls.Add(this.panel_LineHT);
            this.panel2.Controls.Add(this.label_HomeTeam);
            this.panel2.Location = new System.Drawing.Point(14, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 240);
            this.panel2.TabIndex = 8;
            // 
            // panel_LineHT
            // 
            this.panel_LineHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LineHT.Location = new System.Drawing.Point(0, 0);
            this.panel_LineHT.Name = "panel_LineHT";
            this.panel_LineHT.Size = new System.Drawing.Size(548, 7);
            this.panel_LineHT.TabIndex = 9;
            // 
            // panel_LineAT
            // 
            this.panel_LineAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LineAT.Location = new System.Drawing.Point(0, 0);
            this.panel_LineAT.Name = "panel_LineAT";
            this.panel_LineAT.Size = new System.Drawing.Size(548, 7);
            this.panel_LineAT.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView_AwayTeamPlayers);
            this.panel3.Controls.Add(this.label_AwayTeam);
            this.panel3.Controls.Add(this.panel_LineAT);
            this.panel3.Location = new System.Drawing.Point(601, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 240);
            this.panel3.TabIndex = 9;
            // 
            // label_AwayTeam
            // 
            this.label_AwayTeam.AutoSize = true;
            this.label_AwayTeam.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AwayTeam.Location = new System.Drawing.Point(14, 21);
            this.label_AwayTeam.Name = "label_AwayTeam";
            this.label_AwayTeam.Size = new System.Drawing.Size(159, 32);
            this.label_AwayTeam.TabIndex = 10;
            this.label_AwayTeam.Text = "Away Team: ";
            // 
            // dataGridView_HomeTeamPlayers
            // 
            this.dataGridView_HomeTeamPlayers.AllowUserToAddRows = false;
            this.dataGridView_HomeTeamPlayers.AllowUserToDeleteRows = false;
            this.dataGridView_HomeTeamPlayers.AllowUserToResizeRows = false;
            this.dataGridView_HomeTeamPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HomeTeamPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_HomeTeamPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HomeTeamPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_HomeTeamPlayers.Location = new System.Drawing.Point(20, 60);
            this.dataGridView_HomeTeamPlayers.Name = "dataGridView_HomeTeamPlayers";
            this.dataGridView_HomeTeamPlayers.RowHeadersVisible = false;
            this.dataGridView_HomeTeamPlayers.RowHeadersWidth = 62;
            this.dataGridView_HomeTeamPlayers.RowTemplate.Height = 28;
            this.dataGridView_HomeTeamPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_HomeTeamPlayers.Size = new System.Drawing.Size(508, 159);
            this.dataGridView_HomeTeamPlayers.TabIndex = 10;
            // 
            // dataGridView_AwayTeamPlayers
            // 
            this.dataGridView_AwayTeamPlayers.AllowUserToAddRows = false;
            this.dataGridView_AwayTeamPlayers.AllowUserToDeleteRows = false;
            this.dataGridView_AwayTeamPlayers.AllowUserToResizeRows = false;
            this.dataGridView_AwayTeamPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AwayTeamPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_AwayTeamPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AwayTeamPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_AwayTeamPlayers.Location = new System.Drawing.Point(20, 60);
            this.dataGridView_AwayTeamPlayers.Name = "dataGridView_AwayTeamPlayers";
            this.dataGridView_AwayTeamPlayers.RowHeadersVisible = false;
            this.dataGridView_AwayTeamPlayers.RowHeadersWidth = 62;
            this.dataGridView_AwayTeamPlayers.RowTemplate.Height = 28;
            this.dataGridView_AwayTeamPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AwayTeamPlayers.Size = new System.Drawing.Size(508, 159);
            this.dataGridView_AwayTeamPlayers.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView_MatchDetails);
            this.panel1.Controls.Add(this.panel_LineMD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 330);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView_MatchDetails
            // 
            this.dataGridView_MatchDetails.AllowUserToAddRows = false;
            this.dataGridView_MatchDetails.AllowUserToDeleteRows = false;
            this.dataGridView_MatchDetails.AllowUserToResizeRows = false;
            this.dataGridView_MatchDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_MatchDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_MatchDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MatchDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_MatchDetails.Location = new System.Drawing.Point(20, 60);
            this.dataGridView_MatchDetails.Name = "dataGridView_MatchDetails";
            this.dataGridView_MatchDetails.RowHeadersVisible = false;
            this.dataGridView_MatchDetails.RowHeadersWidth = 62;
            this.dataGridView_MatchDetails.RowTemplate.Height = 28;
            this.dataGridView_MatchDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_MatchDetails.Size = new System.Drawing.Size(1094, 250);
            this.dataGridView_MatchDetails.TabIndex = 10;
            // 
            // panel_LineMD
            // 
            this.panel_LineMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LineMD.Location = new System.Drawing.Point(0, 0);
            this.panel_LineMD.Name = "panel_LineMD";
            this.panel_LineMD.Size = new System.Drawing.Size(1134, 7);
            this.panel_LineMD.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Match Details: ";
            // 
            // Form_MatchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 514);
            this.Controls.Add(this.panel_Display);
            this.Controls.Add(this.button_ShowDetails);
            this.Controls.Add(this.comboBox_Match);
            this.Controls.Add(this.label_ChooseMatch);
            this.Controls.Add(this.comboBox_Team);
            this.Controls.Add(this.label_ChooseTeam);
            this.Name = "Form_MatchDetail";
            this.Text = "Form_MatchDetail";
            this.Load += new System.EventHandler(this.Form_MatchDetail_Load);
            this.panel_Display.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HomeTeamPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AwayTeamPlayers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatchDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_HomeTeam;
        private System.Windows.Forms.ToolTip toolTip_Info;
        private System.Windows.Forms.Panel panel_Display;
        private System.Windows.Forms.Button button_ShowDetails;
        private System.Windows.Forms.ComboBox comboBox_Match;
        private System.Windows.Forms.Label label_ChooseMatch;
        private System.Windows.Forms.ComboBox comboBox_Team;
        private System.Windows.Forms.Label label_ChooseTeam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_LineHT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_LineAT;
        private System.Windows.Forms.Label label_AwayTeam;
        private System.Windows.Forms.DataGridView dataGridView_HomeTeamPlayers;
        private System.Windows.Forms.DataGridView dataGridView_AwayTeamPlayers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_MatchDetails;
        private System.Windows.Forms.Panel panel_LineMD;
        private System.Windows.Forms.Label label1;
    }
}