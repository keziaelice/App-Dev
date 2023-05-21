namespace CA_W12_KEZIA_Y
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
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_AddPlayer = new System.Windows.Forms.Button();
            this.textBox_TeamNumber = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_Nationality = new System.Windows.Forms.Label();
            this.label_TeamNumber = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.dataGridView_Player = new System.Windows.Forms.DataGridView();
            this.comboBox_Nationality = new System.Windows.Forms.ComboBox();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.textBox_Position = new System.Windows.Forms.TextBox();
            this.label_Height = new System.Windows.Forms.Label();
            this.label_Position = new System.Windows.Forms.Label();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.label_Weight = new System.Windows.Forms.Label();
            this.dateTimePicker_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.label_Birthdate = new System.Windows.Forms.Label();
            this.label_TeamName = new System.Windows.Forms.Label();
            this.comboBox_TeamName = new System.Windows.Forms.ComboBox();
            this.label_PlayerDGV = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_TeamName2 = new System.Windows.Forms.Label();
            this.comboBox_TeamName_Update = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_TeamManager = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Manager = new System.Windows.Forms.DataGridView();
            this.panel_Manager = new System.Windows.Forms.Panel();
            this.label_ManagerNationality = new System.Windows.Forms.Label();
            this.label_ManagerBirthdate = new System.Windows.Forms.Label();
            this.label_ManagerTeamName = new System.Windows.Forms.Label();
            this.label_ManagerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_EditManager = new System.Windows.Forms.Button();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Player)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manager)).BeginInit();
            this.panel_Manager.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(1018, 446);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 33);
            this.button_Delete.TabIndex = 28;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_AddPlayer
            // 
            this.button_AddPlayer.Location = new System.Drawing.Point(150, 391);
            this.button_AddPlayer.Name = "button_AddPlayer";
            this.button_AddPlayer.Size = new System.Drawing.Size(133, 33);
            this.button_AddPlayer.TabIndex = 25;
            this.button_AddPlayer.Text = "Add Player";
            this.button_AddPlayer.UseVisualStyleBackColor = true;
            this.button_AddPlayer.Click += new System.EventHandler(this.button_AddPlayer_Click);
            // 
            // textBox_TeamNumber
            // 
            this.textBox_TeamNumber.Location = new System.Drawing.Point(150, 99);
            this.textBox_TeamNumber.Name = "textBox_TeamNumber";
            this.textBox_TeamNumber.Size = new System.Drawing.Size(200, 26);
            this.textBox_TeamNumber.TabIndex = 23;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(150, 62);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(200, 26);
            this.textBox_ID.TabIndex = 22;
            // 
            // label_Nationality
            // 
            this.label_Nationality.AutoSize = true;
            this.label_Nationality.Location = new System.Drawing.Point(23, 139);
            this.label_Nationality.Name = "label_Nationality";
            this.label_Nationality.Size = new System.Drawing.Size(86, 20);
            this.label_Nationality.TabIndex = 21;
            this.label_Nationality.Text = "Nationality:";
            // 
            // label_TeamNumber
            // 
            this.label_TeamNumber.AutoSize = true;
            this.label_TeamNumber.Location = new System.Drawing.Point(23, 102);
            this.label_TeamNumber.Name = "label_TeamNumber";
            this.label_TeamNumber.Size = new System.Drawing.Size(118, 20);
            this.label_TeamNumber.TabIndex = 20;
            this.label_TeamNumber.Text = "Team_Number:";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(23, 65);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(30, 20);
            this.label_ID.TabIndex = 19;
            this.label_ID.Text = "ID:";
            // 
            // dataGridView_Player
            // 
            this.dataGridView_Player.AllowUserToAddRows = false;
            this.dataGridView_Player.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Player.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Player.Location = new System.Drawing.Point(433, 107);
            this.dataGridView_Player.Name = "dataGridView_Player";
            this.dataGridView_Player.RowHeadersVisible = false;
            this.dataGridView_Player.RowHeadersWidth = 62;
            this.dataGridView_Player.RowTemplate.Height = 28;
            this.dataGridView_Player.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Player.Size = new System.Drawing.Size(660, 327);
            this.dataGridView_Player.TabIndex = 18;
            // 
            // comboBox_Nationality
            // 
            this.comboBox_Nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Nationality.FormattingEnabled = true;
            this.comboBox_Nationality.Location = new System.Drawing.Point(150, 136);
            this.comboBox_Nationality.Name = "comboBox_Nationality";
            this.comboBox_Nationality.Size = new System.Drawing.Size(200, 28);
            this.comboBox_Nationality.TabIndex = 36;
            // 
            // textBox_Height
            // 
            this.textBox_Height.Location = new System.Drawing.Point(150, 214);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(200, 26);
            this.textBox_Height.TabIndex = 40;
            // 
            // textBox_Position
            // 
            this.textBox_Position.Location = new System.Drawing.Point(150, 177);
            this.textBox_Position.Name = "textBox_Position";
            this.textBox_Position.Size = new System.Drawing.Size(200, 26);
            this.textBox_Position.TabIndex = 39;
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.Location = new System.Drawing.Point(23, 217);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(64, 20);
            this.label_Height.TabIndex = 38;
            this.label_Height.Text = "Height: ";
            this.label_Height.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Location = new System.Drawing.Point(23, 180);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(73, 20);
            this.label_Position.TabIndex = 37;
            this.label_Position.Text = "Position: ";
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(150, 256);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(200, 26);
            this.textBox_Weight.TabIndex = 42;
            // 
            // label_Weight
            // 
            this.label_Weight.AutoSize = true;
            this.label_Weight.Location = new System.Drawing.Point(23, 259);
            this.label_Weight.Name = "label_Weight";
            this.label_Weight.Size = new System.Drawing.Size(67, 20);
            this.label_Weight.TabIndex = 41;
            this.label_Weight.Text = "Weight: ";
            this.label_Weight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker_Birthdate
            // 
            this.dateTimePicker_Birthdate.Location = new System.Drawing.Point(150, 300);
            this.dateTimePicker_Birthdate.Name = "dateTimePicker_Birthdate";
            this.dateTimePicker_Birthdate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_Birthdate.TabIndex = 43;
            // 
            // label_Birthdate
            // 
            this.label_Birthdate.AutoSize = true;
            this.label_Birthdate.Location = new System.Drawing.Point(23, 305);
            this.label_Birthdate.Name = "label_Birthdate";
            this.label_Birthdate.Size = new System.Drawing.Size(82, 20);
            this.label_Birthdate.TabIndex = 44;
            this.label_Birthdate.Text = "Birthdate: ";
            this.label_Birthdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_TeamName
            // 
            this.label_TeamName.AutoSize = true;
            this.label_TeamName.Location = new System.Drawing.Point(23, 346);
            this.label_TeamName.Name = "label_TeamName";
            this.label_TeamName.Size = new System.Drawing.Size(99, 20);
            this.label_TeamName.TabIndex = 45;
            this.label_TeamName.Text = "Team Name:";
            this.label_TeamName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox_TeamName
            // 
            this.comboBox_TeamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TeamName.FormattingEnabled = true;
            this.comboBox_TeamName.Location = new System.Drawing.Point(150, 343);
            this.comboBox_TeamName.Name = "comboBox_TeamName";
            this.comboBox_TeamName.Size = new System.Drawing.Size(200, 28);
            this.comboBox_TeamName.TabIndex = 46;
            // 
            // label_PlayerDGV
            // 
            this.label_PlayerDGV.AutoSize = true;
            this.label_PlayerDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayerDGV.Location = new System.Drawing.Point(428, 32);
            this.label_PlayerDGV.Name = "label_PlayerDGV";
            this.label_PlayerDGV.Size = new System.Drawing.Size(87, 29);
            this.label_PlayerDGV.TabIndex = 47;
            this.label_PlayerDGV.Text = "Player";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(150, 22);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 26);
            this.textBox_Name.TabIndex = 49;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(23, 25);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(55, 20);
            this.label_Name.TabIndex = 48;
            this.label_Name.Text = "Name:";
            // 
            // label_TeamName2
            // 
            this.label_TeamName2.AutoSize = true;
            this.label_TeamName2.Location = new System.Drawing.Point(431, 71);
            this.label_TeamName2.Name = "label_TeamName2";
            this.label_TeamName2.Size = new System.Drawing.Size(99, 20);
            this.label_TeamName2.TabIndex = 50;
            this.label_TeamName2.Text = "Team Name:";
            this.label_TeamName2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox_TeamName_Update
            // 
            this.comboBox_TeamName_Update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TeamName_Update.FormattingEnabled = true;
            this.comboBox_TeamName_Update.Location = new System.Drawing.Point(558, 68);
            this.comboBox_TeamName_Update.Name = "comboBox_TeamName_Update";
            this.comboBox_TeamName_Update.Size = new System.Drawing.Size(200, 28);
            this.comboBox_TeamName_Update.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_Weight);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Controls.Add(this.label_TeamNumber);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.label_Nationality);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.textBox_TeamNumber);
            this.panel1.Controls.Add(this.comboBox_TeamName);
            this.panel1.Controls.Add(this.button_AddPlayer);
            this.panel1.Controls.Add(this.label_TeamName);
            this.panel1.Controls.Add(this.comboBox_Nationality);
            this.panel1.Controls.Add(this.label_Birthdate);
            this.panel1.Controls.Add(this.label_Position);
            this.panel1.Controls.Add(this.dateTimePicker_Birthdate);
            this.panel1.Controls.Add(this.label_Height);
            this.panel1.Controls.Add(this.textBox_Position);
            this.panel1.Controls.Add(this.label_Weight);
            this.panel1.Controls.Add(this.textBox_Height);
            this.panel1.Location = new System.Drawing.Point(27, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 449);
            this.panel1.TabIndex = 52;
            // 
            // comboBox_TeamManager
            // 
            this.comboBox_TeamManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TeamManager.FormattingEnabled = true;
            this.comboBox_TeamManager.Location = new System.Drawing.Point(684, 566);
            this.comboBox_TeamManager.Name = "comboBox_TeamManager";
            this.comboBox_TeamManager.Size = new System.Drawing.Size(254, 28);
            this.comboBox_TeamManager.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Choose Team:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "Available Managers";
            // 
            // dataGridView_Manager
            // 
            this.dataGridView_Manager.AllowUserToAddRows = false;
            this.dataGridView_Manager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Manager.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Manager.Location = new System.Drawing.Point(27, 562);
            this.dataGridView_Manager.Name = "dataGridView_Manager";
            this.dataGridView_Manager.RowHeadersVisible = false;
            this.dataGridView_Manager.RowHeadersWidth = 62;
            this.dataGridView_Manager.RowTemplate.Height = 28;
            this.dataGridView_Manager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Manager.Size = new System.Drawing.Size(488, 327);
            this.dataGridView_Manager.TabIndex = 57;
            // 
            // panel_Manager
            // 
            this.panel_Manager.BackColor = System.Drawing.Color.LightGray;
            this.panel_Manager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Manager.Controls.Add(this.label_ManagerNationality);
            this.panel_Manager.Controls.Add(this.label_ManagerBirthdate);
            this.panel_Manager.Controls.Add(this.label_ManagerTeamName);
            this.panel_Manager.Controls.Add(this.label_ManagerName);
            this.panel_Manager.Controls.Add(this.label3);
            this.panel_Manager.Controls.Add(this.label4);
            this.panel_Manager.Controls.Add(this.label5);
            this.panel_Manager.Controls.Add(this.label6);
            this.panel_Manager.Controls.Add(this.label9);
            this.panel_Manager.Location = new System.Drawing.Point(558, 611);
            this.panel_Manager.Name = "panel_Manager";
            this.panel_Manager.Size = new System.Drawing.Size(535, 221);
            this.panel_Manager.TabIndex = 53;
            // 
            // label_ManagerNationality
            // 
            this.label_ManagerNationality.Location = new System.Drawing.Point(142, 177);
            this.label_ManagerNationality.Name = "label_ManagerNationality";
            this.label_ManagerNationality.Size = new System.Drawing.Size(360, 20);
            this.label_ManagerNationality.TabIndex = 52;
            this.label_ManagerNationality.Text = "Nationality";
            // 
            // label_ManagerBirthdate
            // 
            this.label_ManagerBirthdate.Location = new System.Drawing.Point(142, 139);
            this.label_ManagerBirthdate.Name = "label_ManagerBirthdate";
            this.label_ManagerBirthdate.Size = new System.Drawing.Size(360, 20);
            this.label_ManagerBirthdate.TabIndex = 51;
            this.label_ManagerBirthdate.Text = "Birthdate";
            // 
            // label_ManagerTeamName
            // 
            this.label_ManagerTeamName.Location = new System.Drawing.Point(142, 102);
            this.label_ManagerTeamName.Name = "label_ManagerTeamName";
            this.label_ManagerTeamName.Size = new System.Drawing.Size(360, 20);
            this.label_ManagerTeamName.TabIndex = 50;
            this.label_ManagerTeamName.Text = "Team Name";
            // 
            // label_ManagerName
            // 
            this.label_ManagerName.Location = new System.Drawing.Point(142, 65);
            this.label_ManagerName.Name = "label_ManagerName";
            this.label_ManagerName.Size = new System.Drawing.Size(360, 20);
            this.label_ManagerName.TabIndex = 49;
            this.label_ManagerName.Text = "Name";
            this.label_ManagerName.MouseHover += new System.EventHandler(this.label_ManagerName_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Team Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Birthdate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Current Manager";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Nationality: ";
            // 
            // button_EditManager
            // 
            this.button_EditManager.Location = new System.Drawing.Point(558, 847);
            this.button_EditManager.Name = "button_EditManager";
            this.button_EditManager.Size = new System.Drawing.Size(133, 33);
            this.button_EditManager.TabIndex = 25;
            this.button_EditManager.Text = "Edit Manager";
            this.button_EditManager.UseVisualStyleBackColor = true;
            this.button_EditManager.Click += new System.EventHandler(this.button_EditManager_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(27, 906);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 16);
            this.panel3.TabIndex = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1125, 967);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_Manager);
            this.Controls.Add(this.dataGridView_Manager);
            this.Controls.Add(this.comboBox_TeamManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_EditManager);
            this.Controls.Add(this.comboBox_TeamName_Update);
            this.Controls.Add(this.label_TeamName2);
            this.Controls.Add(this.label_PlayerDGV);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.dataGridView_Player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manager)).EndInit();
            this.panel_Manager.ResumeLayout(false);
            this.panel_Manager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_AddPlayer;
        private System.Windows.Forms.TextBox textBox_TeamNumber;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Nationality;
        private System.Windows.Forms.Label label_TeamNumber;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.DataGridView dataGridView_Player;
        private System.Windows.Forms.ComboBox comboBox_Nationality;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.TextBox textBox_Position;
        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.Label label_Weight;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birthdate;
        private System.Windows.Forms.Label label_Birthdate;
        private System.Windows.Forms.Label label_TeamName;
        private System.Windows.Forms.ComboBox comboBox_TeamName;
        private System.Windows.Forms.Label label_PlayerDGV;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_TeamName2;
        private System.Windows.Forms.ComboBox comboBox_TeamName_Update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_TeamManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Manager;
        private System.Windows.Forms.Panel panel_Manager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_EditManager;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_ManagerNationality;
        private System.Windows.Forms.Label label_ManagerBirthdate;
        private System.Windows.Forms.Label label_ManagerTeamName;
        private System.Windows.Forms.Label label_ManagerName;
        private System.Windows.Forms.ToolTip toolTip_Info;
        private System.Windows.Forms.Panel panel3;
    }
}

