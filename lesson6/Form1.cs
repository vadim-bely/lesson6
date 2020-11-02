using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxParam.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Bisque;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("В введите любое слово или число");
            }
            
            if (radioButtonColor.Checked)
            {
                if (comboBoxParam.Text.Equals("White"))
                {
                    textBox1.BackColor = Color.Gray;
                } else textBox1.BackColor = Color.Bisque;
                textBox1.ForeColor = Color.FromName(comboBoxParam.Text);
            } else if (radioButtonSize.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.Name,int.Parse(comboBoxParam.Text), textBox1.Font.Style);
            } else if (radioButtonStyle.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.Name,textBox1.Font.Size, (FontStyle)Enum.Parse(typeof(FontStyle),comboBoxParam.Text));
            } else if (radioButtonFont.Checked)
            {
                textBox1.Font = new Font(comboBoxParam.Text, textBox1.Font.Size, textBox1.Font.Style);
            }

        }

        private void radioButtonColor_CheckedChanged(object sender, EventArgs e)
        {
            
            string[] color = {"Red", "Blue", "White", "Green", "Gray"};
            comboBoxParam.Items.Clear();
            comboBoxParam.Items.AddRange(color);
            comboBoxParam.Visible = true;
        }
        
        private void radioButtonSize_CheckedChanged(object sender, EventArgs e)
        {
            string[] size = {"7", "8", "9", "11", "12", "14", "16", "18", "20", "24", "28", "36", "48", "72"};
            comboBoxParam.Items.Clear();
            comboBoxParam.Items.AddRange(size);
            comboBoxParam.Visible = true;
        }
        
        private void radioButtonStyle_CheckedChanged(object sender, EventArgs e)
        {
            string[] style = {"Bold", "Italic", "Regular", "Strikeout", "Underline"};
            comboBoxParam.Items.Clear();
            comboBoxParam.Items.AddRange(style);
            comboBoxParam.Visible = true;
            
        }

        private void radioButtonFont_CheckedChanged(object sender, EventArgs e)
        {
            string[] font = {"algerian", "Vadim's Writing", "IrinaC", "marlett", "WEBDINGS"};
            comboBoxParam.Items.Clear();
            comboBoxParam.Items.AddRange(font);
            comboBoxParam.Visible = true;
        }
    }
}