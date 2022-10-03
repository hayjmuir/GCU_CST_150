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

                /* I have:
                 *    A text file
                 * I want:
                 *    [X] First word alphabetically
                 *    [X] Last word alphabetically
                 *    [ ] Longest word
                 *    [ ] Word with most vowels
                 * 
                 * Get ready to remember the first word, last word, longest word, and word with most vowels
                 * 
                 * [X] Open the file
                 * [X] While there are still words to look at
                 * [X]   Get the next word
                 *    
                 * [X]   Compare the next word to the first word
                 * [X]   If that word comes before the first word alphabetically
                 * [X]       Replace the first word with this word
                 *    
                 * [X]   Compare the next word to the last word
                 * [X]   If that word comes before the last word alphabetically
                 * [X]       Replace the last word with this word
                 *    
                 * [X]   Compare the next word to the longest word
                 * [X]   If that word is longer than the longest word
                 * [X]       Replace the longest word with this word
                 * 
                 * [X]   Compare the next word to the word with the most vowels
                 * [X]   If that word has more vowels
                 * [X]       Replace the most vowels word with this word
                 * 
                 * [X]   Display all words in lowercase
                 * 
                 * [X] Loop
                 * 
                 * [X] Display Stats
                 * [ ] Save stats to file
                 */



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