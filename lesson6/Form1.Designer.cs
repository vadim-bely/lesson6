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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 22);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 428);
            this.Controls.Add(this.radioButtonSize);
            this.Controls.Add(this.radioButtonColour);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton radioButtonSize;

        private System.Windows.Forms.RadioButton radioButtonColour;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}