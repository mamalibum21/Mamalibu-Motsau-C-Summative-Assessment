using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mamalibu_Motsau_C__Summative_Assessment
{
    public partial class Form1 : Form
    {

        private ArrayList words = new ArrayList();
        private ArrayList concatenatedWords = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Please enter a word in the TextBox.", "Error");
                return;
            }

            if (words.Contains(word))
            {
                MessageBox.Show("This word has already been added.", "Error");
                return;
            }

            if (words.Count > 0 && words.Contains(word))
            {
                MessageBox.Show("This word is already in the ComboBox.", "Error");
                return;
            }

            words.Add(word);

            textBox1.Clear();

            comboBox1.Items.Add(word);
            comboBox2.Items.Add(word);
            concatenatedWords.Add(word);

            MessageBox.Show("Word added successfully.", "Success");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a word to remove.", "Error");
                    return;
                }

                if (comboBox1.SelectedItem != null)
                {
                    string selectedWord = comboBox1.SelectedItem.ToString();
                    comboBox1.Items.Remove(selectedWord);
                    concatenatedWords.Remove(selectedWord);
                }

                if (comboBox2.SelectedItem != null)
                {
                    string selectedWord = comboBox2.SelectedItem.ToString();
                    comboBox2.Items.Remove(selectedWord);
                    concatenatedWords.Remove(selectedWord);
                }

                MessageBox.Show("Word removed successfully.", "Success");
            }

            else if (radioButton2.Checked)
            {
                if (comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Please select a word to remove.", "Error");
                    return;
                }

                if (comboBox2.SelectedItem != null)
                {
                    string selectedWord = comboBox1.SelectedItem.ToString();
                    comboBox1.Items.Remove(selectedWord);
                    concatenatedWords.Remove(selectedWord);
                }

                if (comboBox2.SelectedItem != null)
                {
                    string selectedWord = comboBox2.SelectedItem.ToString();
                    comboBox2.Items.Remove(selectedWord);
                    concatenatedWords.Remove(selectedWord);
                }

                MessageBox.Show("Word removed successfully.", "Success");
            }

            else
            {
                if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Please select words from both ComboBoxes to concatenate.", "Error");
                    return;
                }

                string word1 = comboBox1.SelectedItem.ToString();
                string word2 = comboBox2.SelectedItem.ToString();

                if (word1 == word2)
                {
                    MessageBox.Show("Please select different words from both ComboBoxes.", "Error");
                    return;
                }

                string concatenatedWord = word1 + word2;

                label6.Text = concatenatedWord;
                MessageBox.Show("Words concatenated successfully.", "Success");


            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button2.Text = "Remove Item";
            }
            else
            { button2.Text = "Concatenate"; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button2.Text = "Remove Item";
            }
            else
            { button2.Text = "Concatenate"; }
        }
    }
}

