using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            
            textBox1.BackColor = Color.White;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonColor.Checked)
            {
                textBox1.ForeColor = Color.FromName(comboBoxParam.Text);
            } else if (radioButtonFont.Checked)
            {
                textBox1.Font = new Font("Vadim's Writing",int.Parse(comboBoxParam.Text));
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
            throw new System.NotImplementedException();
        }

        private void radioButtonFont_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}