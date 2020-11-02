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
            this.radioButtonColor = new System.Windows.Forms.RadioButton();
            this.radioButtonSize = new System.Windows.Forms.RadioButton();
            this.radioButtonStyle = new System.Windows.Forms.RadioButton();
            this.radioButtonFont = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxParam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Vadim\'s Writing", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.Location = new System.Drawing.Point(28, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 69);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButtonColor
            // 
            this.radioButtonColor.Location = new System.Drawing.Point(28, 87);
            this.radioButtonColor.Name = "radioButtonColor";
            this.radioButtonColor.Size = new System.Drawing.Size(74, 21);
            this.radioButtonColor.TabIndex = 1;
            this.radioButtonColor.TabStop = true;
            this.radioButtonColor.Text = "Color";
            this.radioButtonColor.UseVisualStyleBackColor = true;
            this.radioButtonColor.CheckedChanged += new System.EventHandler(this.radioButtonColor_CheckedChanged);
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
            this.radioButtonSize.CheckedChanged += new System.EventHandler(this.radioButtonSize_CheckedChanged);
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
            this.button1.Location = new System.Drawing.Point(28, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 110);
            this.button1.TabIndex = 5;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxParam
            // 
            this.comboBoxParam.FormattingEnabled = true;
            this.comboBoxParam.Location = new System.Drawing.Point(139, 87);
            this.comboBoxParam.Name = "comboBoxParam";
            this.comboBoxParam.Size = new System.Drawing.Size(226, 24);
            this.comboBoxParam.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 319);
            this.Controls.Add(this.comboBoxParam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonFont);
            this.Controls.Add(this.radioButtonStyle);
            this.Controls.Add(this.radioButtonSize);
            this.Controls.Add(this.radioButtonColor);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxParam;

        private System.Windows.Forms.RadioButton radioButtonColor;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.RadioButton radioButtonFont;

        private System.Windows.Forms.RadioButton radioButtonStyle;

        private System.Windows.Forms.RadioButton radioButtonSize;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}