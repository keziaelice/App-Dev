namespace THA_W8_KEZIA_Y
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
            this.panel_Header = new System.Windows.Forms.Panel();
            this.panel_MenuStrip = new System.Windows.Forms.Panel();
            this.menuStrip_Menu = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Header.SuspendLayout();
            this.panel_MenuStrip.SuspendLayout();
            this.menuStrip_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Header.Controls.Add(this.panel_MenuStrip);
            this.panel_Header.Controls.Add(this.panel_Logo);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1228, 100);
            this.panel_Header.TabIndex = 0;
            // 
            // panel_MenuStrip
            // 
            this.panel_MenuStrip.Controls.Add(this.menuStrip_Menu);
            this.panel_MenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MenuStrip.Location = new System.Drawing.Point(131, 0);
            this.panel_MenuStrip.Name = "panel_MenuStrip";
            this.panel_MenuStrip.Size = new System.Drawing.Size(1095, 98);
            this.panel_MenuStrip.TabIndex = 1;
            // 
            // menuStrip_Menu
            // 
            this.menuStrip_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip_Menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip_Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.showMatchDetailsToolStripMenuItem});
            this.menuStrip_Menu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Menu.Name = "menuStrip_Menu";
            this.menuStrip_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip_Menu.Size = new System.Drawing.Size(1095, 98);
            this.menuStrip_Menu.TabIndex = 1;
            this.menuStrip_Menu.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(138, 94);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            this.playerDataToolStripMenuItem.MouseEnter += new System.EventHandler(this.playerDataToolStripMenuItem_MouseEnter);
            this.playerDataToolStripMenuItem.MouseLeave += new System.EventHandler(this.playerDataToolStripMenuItem_MouseLeave);
            // 
            // showMatchDetailsToolStripMenuItem
            // 
            this.showMatchDetailsToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMatchDetailsToolStripMenuItem.Name = "showMatchDetailsToolStripMenuItem";
            this.showMatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(217, 94);
            this.showMatchDetailsToolStripMenuItem.Text = "Show Match Details";
            this.showMatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_Click);
            this.showMatchDetailsToolStripMenuItem.MouseEnter += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_MouseEnter);
            this.showMatchDetailsToolStripMenuItem.MouseLeave += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_MouseLeave);
            // 
            // panel_Logo
            // 
            this.panel_Logo.Controls.Add(this.pictureBox_Logo);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(131, 98);
            this.panel_Logo.TabIndex = 0;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::THA_W8_KEZIA_Y.Properties.Resources.premierleague_logo;
            this.pictureBox_Logo.Location = new System.Drawing.Point(18, 9);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(95, 80);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            this.pictureBox_Logo.Click += new System.EventHandler(this.pictureBox_Logo_Click);
            this.pictureBox_Logo.MouseEnter += new System.EventHandler(this.pictureBox_Logo_MouseEnter);
            this.pictureBox_Logo.MouseLeave += new System.EventHandler(this.pictureBox_Logo_MouseLeave);
            // 
            // panel_Main
            // 
            this.panel_Main.AutoScroll = true;
            this.panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 100);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1228, 544);
            this.panel_Main.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 644);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Header);
            this.MainMenuStrip = this.menuStrip_Menu;
            this.Name = "Form1";
            this.Text = "Premier League";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_MenuStrip.ResumeLayout(false);
            this.panel_MenuStrip.PerformLayout();
            this.menuStrip_Menu.ResumeLayout(false);
            this.menuStrip_Menu.PerformLayout();
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Panel panel_MenuStrip;
        private System.Windows.Forms.MenuStrip menuStrip_Menu;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailsToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Logo;
    }
}

