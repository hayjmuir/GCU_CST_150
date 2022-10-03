using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Assignment_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wordProcessingButton_Click(object sender, EventArgs e)
        {
            try
            {
      
                string currentWord;
                string firstWordAlphabetically = string.Empty; 
                string lastWordAlphabetically = string.Empty;
                string longestWord = string.Empty;
                string largestVowelWord = string.Empty;
                int vowelCount = 0; 

                lowercaseTextBox.Clear();

               OpenFileDialog openFileDialog = new OpenFileDialog();
               
               openFileDialog.Filter = "Text Document (.txt)|*.txt";
               if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
                {
                    
                    StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                    while (!streamReader.EndOfStream)
                    {
                        
                        currentWord = streamReader.ReadLine().ToLower();
                        lowercaseTextBox.AppendText(currentWord + ' ');

                        // If current word comes before first word
                        if (firstWordAlphabetically == string.Empty || currentWord.CompareTo(firstWordAlphabetically) == -1)
                        {
                           firstWordAlphabetically = currentWord;

                        };
                        // If current word comes after last word ...
                        if(currentWord.CompareTo(lastWordAlphabetically) == 1)
                        {
                            lastWordAlphabetically = currentWord;
                        }
                        
                        // If the length of the current word is greater than the length of the longest word
                        if(currentWord.Length > longestWord.Length)
                        {
                            longestWord = currentWord;
                        }


                        // Count vowels in current word

                        int counter = 0;

                        foreach (char c in currentWord)
                        {
                            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                                counter++;
                        }

                        // If vowel count of current word is greater the vowel count of most voweled word
                        if (counter > vowelCount)
                        {
                            vowelCount = counter;
                            largestVowelWord = currentWord;
                        }
                    }
                    streamReader.Close();  

                }


                // Display stats
                firstWordTextBox.Text = firstWordAlphabetically;
                lastWordTextBox.Text = lastWordAlphabetically;
                longWordTextBox.Text = longestWord;
                vowelTextBox.Text = largestVowelWord;

                // Save stats
                StreamWriter outputFile;
                outputFile = File.CreateText("stats.txt"));
                outputFile.WriteLine(firstWordAlphabetically);
                outputFile.WriteLine(lastWordAlphabetically);   
                outputFile.WriteLine(longestWord);
                outputFile.WriteLine(largestVowelWord);
                outputFile.Close();

            }
            catch (Exception ex) {
            MessageBox.Show(ex.Message);
            }













        }

      
    }
}
