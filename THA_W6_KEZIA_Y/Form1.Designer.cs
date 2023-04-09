namespace THA_W6_KEZIA_Y
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
            this.label_Wordle = new System.Windows.Forms.Label();
            this.label_Desc = new System.Windows.Forms.Label();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.button_Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Wordle
            // 
            this.label_Wordle.Font = new System.Drawing.Font("Courier New", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Wordle.Location = new System.Drawing.Point(12, 9);
            this.label_Wordle.Name = "label_Wordle";
            this.label_Wordle.Size = new System.Drawing.Size(370, 63);
            this.label_Wordle.TabIndex = 0;
            this.label_Wordle.Text = "WORDLE";
            this.label_Wordle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Desc
            // 
            this.label_Desc.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Desc.Location = new System.Drawing.Point(12, 69);
            this.label_Desc.Name = "label_Desc";
            this.label_Desc.Size = new System.Drawing.Size(370, 23);
            this.label_Desc.TabIndex = 1;
            this.label_Desc.Text = "Set How Much You Can Guess!";
            this.label_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(127, 104);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(134, 26);
            this.textBox_Input.TabIndex = 2;
            this.textBox_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Input_KeyPress);
            // 
            // button_Play
            // 
            this.button_Play.BackColor = System.Drawing.Color.MistyRose;
            this.button_Play.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Play.Location = new System.Drawing.Point(152, 146);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(85, 40);
            this.button_Play.TabIndex = 3;
            this.button_Play.Text = "Play!";
            this.button_Play.UseVisualStyleBackColor = false;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(394, 209);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.label_Desc);
            this.Controls.Add(this.label_Wordle);
            this.Name = "Form1";
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Wordle;
        private System.Windows.Forms.Label label_Desc;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button button_Play;
    }
}

