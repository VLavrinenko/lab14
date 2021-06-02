using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBoxColor.SelectedIndex = 0;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBoxColor.Text)
            {
                case "Белый":; BackColor = Color.White; break;
                case "Красный":; BackColor = Color.Red; break;
                case "Чёрный":; BackColor = Color.Black; break;
                case "Синий":; BackColor = Color.Blue; break;
                case "Жёлтый":; BackColor = Color.Yellow; break;

                default:
                    BackColor = SystemColors.Control; break;
            }
            toolStripComboBox1.Text = toolStripComboBoxColor.Text;
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripComboBoxColor.Text = toolStripComboBox1.Text;
            toolStripComboBox1_SelectedIndexChanged(sender, e);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = toolStripTextBoxRed.Text;
            toolStripTextBox2.Text = toolStripTextBoxGreen.Text;
            toolStripTextBox3.Text = toolStripTextBoxBlue.Text;
            try
            {
                BackColor = Color.FromArgb(
                    Convert.ToInt32(toolStripTextBoxRed.Text),
                    Convert.ToInt32(toolStripTextBoxGreen.Text),
                    Convert.ToInt32(toolStripTextBoxBlue.Text));
            }
            catch
            {
                MessageBox.Show("Необходимо ввести целое число от 0 до 255", "Ошибка в задании цвета");
            }
        }

        private void toolStripTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            toolStripTextBoxRed.Text = toolStripTextBox1.Text;
            toolStripTextBoxGreen.Text = toolStripTextBox2.Text;
            toolStripTextBoxBlue.Text = toolStripTextBox3.Text;
            toolStripTextBox1_TextChanged(sender, e);
        }
    }
}
