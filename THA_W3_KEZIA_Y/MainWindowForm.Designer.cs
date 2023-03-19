namespace THA_W3_KEZIA_Y
{
    partial class MainWindowForm
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
            this.button_NextForm = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_FavArtist = new System.Windows.Forms.Label();
            this.textBox_FavArtist = new System.Windows.Forms.TextBox();
            this.checkBox_TrueContent = new System.Windows.Forms.CheckBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_NextForm
            // 
            this.button_NextForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NextForm.Location = new System.Drawing.Point(17, 12);
            this.button_NextForm.Name = "button_NextForm";
            this.button_NextForm.Size = new System.Drawing.Size(150, 40);
            this.button_NextForm.TabIndex = 0;
            this.button_NextForm.Text = "Open Next Form";
            this.button_NextForm.UseVisualStyleBackColor = true;
            this.button_NextForm.Click += new System.EventHandler(this.button_NextForm_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(13, 72);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(55, 20);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(17, 95);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(275, 26);
            this.textBox_Name.TabIndex = 2;
            // 
            // label_FavArtist
            // 
            this.label_FavArtist.AutoSize = true;
            this.label_FavArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FavArtist.Location = new System.Drawing.Point(13, 142);
            this.label_FavArtist.Name = "label_FavArtist";
            this.label_FavArtist.Size = new System.Drawing.Size(149, 20);
            this.label_FavArtist.TabIndex = 3;
            this.label_FavArtist.Text = "My Favorite Artist";
            // 
            // textBox_FavArtist
            // 
            this.textBox_FavArtist.Location = new System.Drawing.Point(17, 165);
            this.textBox_FavArtist.Name = "textBox_FavArtist";
            this.textBox_FavArtist.Size = new System.Drawing.Size(275, 26);
            this.textBox_FavArtist.TabIndex = 4;
            // 
            // checkBox_TrueContent
            // 
            this.checkBox_TrueContent.AutoSize = true;
            this.checkBox_TrueContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_TrueContent.Location = new System.Drawing.Point(17, 219);
            this.checkBox_TrueContent.Name = "checkBox_TrueContent";
            this.checkBox_TrueContent.Size = new System.Drawing.Size(289, 24);
            this.checkBox_TrueContent.TabIndex = 5;
            this.checkBox_TrueContent.Text = "All of the content I put above is true!";
            this.checkBox_TrueContent.UseVisualStyleBackColor = true;
            this.checkBox_TrueContent.CheckedChanged += new System.EventHandler(this.checkBox_TrueContent_CheckedChanged);
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.SystemColors.Control;
            this.button_Submit.Enabled = false;
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Submit.Location = new System.Drawing.Point(17, 256);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(90, 40);
            this.button_Submit.TabIndex = 6;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 324);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.checkBox_TrueContent);
            this.Controls.Add(this.textBox_FavArtist);
            this.Controls.Add(this.label_FavArtist);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_NextForm);
            this.Name = "MainWindowForm";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_NextForm;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_FavArtist;
        private System.Windows.Forms.TextBox textBox_FavArtist;
        private System.Windows.Forms.CheckBox checkBox_TrueContent;
        private System.Windows.Forms.Button button_Submit;
    }
}

