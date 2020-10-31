namespace lesson6
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonColour = new System.Windows.Forms.RadioButton();
            this.radioButtonSize = new System.Windows.Forms.RadioButton();
            this.radioButtonStyle = new System.Windows.Forms.RadioButton();
            this.radioButtonFont = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 69);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButtonColour
            // 
            this.radioButtonColour.Location = new System.Drawing.Point(28, 87);
            this.radioButtonColour.Name = "radioButtonColour";
            this.radioButtonColour.Size = new System.Drawing.Size(74, 21);
            this.radioButtonColour.TabIndex = 1;
            this.radioButtonColour.TabStop = true;
            this.radioButtonColour.Text = "Colour";
            this.radioButtonColour.UseVisualStyleBackColor = true;
            this.radioButtonColour.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonSize
            // 
            this.radioButtonSize.Location = new System.Drawing.Point(28, 114);
            this.radioButtonSize.Name = "radioButtonSize";
            this.radioButtonSize.Size = new System.Drawing.Size(74, 21);
            this.radioButtonSize.TabIndex = 2;
            this.radioButtonSize.TabStop = true;
            this.radioButtonSize.Text = "Size";
            this.radioButtonSize.UseVisualStyleBackColor = true;
            // 
            // radioButtonStyle
            // 
            this.radioButtonStyle.Location = new System.Drawing.Point(28, 141);
            this.radioButtonStyle.Name = "radioButtonStyle";
            this.radioButtonStyle.Size = new System.Drawing.Size(74, 21);
            this.radioButtonStyle.TabIndex = 3;
            this.radioButtonStyle.TabStop = true;
            this.radioButtonStyle.Text = "Style";
            this.radioButtonStyle.UseVisualStyleBackColor = true;
            // 
            // radioButtonFont
            // 
            this.radioButtonFont.Location = new System.Drawing.Point(28, 168);
            this.radioButtonFont.Name = "radioButtonFont";
            this.radioButtonFont.Size = new System.Drawing.Size(74, 21);
            this.radioButtonFont.TabIndex = 4;
            this.radioButtonFont.TabStop = true;
            this.radioButtonFont.Text = "Font";
            this.radioButtonFont.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Vadim\'s Writing", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(108, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 110);
            this.button1.TabIndex = 5;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonFont);
            this.Controls.Add(this.radioButtonStyle);
            this.Controls.Add(this.radioButtonSize);
            this.Controls.Add(this.radioButtonColour);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.RadioButton radioButtonFont;

        private System.Windows.Forms.RadioButton radioButtonStyle;

        private System.Windows.Forms.RadioButton radioButtonSize;

        private System.Windows.Forms.RadioButton radioButtonColour;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}