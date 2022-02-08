using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Reflection;

namespace WordlePermutations
{
    public partial class MainForm : Form
    {
        #region Fields and Constructor
        private bool locked = false;
        private int guessIndex = 0;
        private string originalTemplateString;

        private List<string> possibleLetters;
        private List<string> yellowLetters;
        private List<string> permutations;
        private List<string> validGuesses;
        private List<string> secretWords;

        private List<TextBox> textBoxes;

        public MainForm()
        {
            InitializeComponent();
            possibleLetters = new List<string>();
            yellowLetters = new List<string>();
            validGuesses = new List<string>();
            secretWords = new List<string>();
            textBoxes = new List<TextBox>();

            textBoxes.Add(txtLetter1);
            textBoxes.Add(txtLetter2);
            textBoxes.Add(txtLetter3);
            textBoxes.Add(txtLetter4);
            textBoxes.Add(txtLetter5);

            validGuesses = WordlePermutations.Properties.Resources.guesses.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            secretWords = WordlePermutations.Properties.Resources.secrets.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
        #endregion

        #region Generate Permutations Code

        private void generatePermutations()
        {
            this.permutations = new List<string>();

            //Did the user forget to put their entered letters into the possible letters area?
            //  Let's do that for them.
            foreach (TextBox txt in textBoxes)
            {
                if (txt.Text != "")
                {
                    if (!possibleLetters.Contains(txt.Text))
                    {
                        possibleLetters.Add(txt.Text);
                    }
                }
            }

            //First, process a string from the entered letters in the right positions
            //  using * as a placeholder for unfilled boxes.
            string templateString = "";
            foreach (TextBox txt in textBoxes)
            {
                templateString += txt.Text == "" ? "*" : txt.Text;
            }

            //Maybe we don't know all the letters that must be included (or maybe there's duplicate letters)
            int unknowns = templateString.Count(wildcardTester);
            if (this.yellowLetters.Count <= unknowns)
            {
                this.yellowLetters.Add("*");
            }


            List<string> templateStrings = this.getPermutationsForTemplate(new List<string>(new string[] { templateString }), this.yellowLetters);

            //We now have a template string for each possible template

            this.permutations = this.getPermutationsForTemplate(templateStrings, this.possibleLetters);
        }

        private List<string> getPermutationsForTemplate(List<string> templateStrings, List<string> possibleCharacters, bool strict = false)
        {
            List<string> ret = new List<string>();

            foreach(string templateString in templateStrings) {
                int unknowns = templateString.Count(wildcardTester);

                //If there are no unknown characters, just add to the output
                if (unknowns == 0)
                {
                    ret.Add(templateString);
                    continue;
                }

                //Create 2D permutation array with known letters
                List<List<string>> permutationArrays = new List<List<string>>();
                for (int i = 0; i < 5; i++)
                {
                    //if (textBoxes[i].Text == "")
                    if(templateString[i] == '*')
                    {
                        permutationArrays.Add(new List<string>(possibleCharacters));
                    }
                    else
                    {
                        permutationArrays.Add(new List<string>());
                        permutationArrays[i].Add(templateString[i].ToString());
                    }
                }

                //From the arrays, create every template string permutation
                for (int pos1 = 0; pos1 < possibleCharacters.Count; pos1++)
                {
                    for (int pos2 = 0; pos2 < possibleCharacters.Count; pos2++)
                    {
                        for (int pos3 = 0; pos3 < possibleCharacters.Count; pos3++)
                        {
                            for (int pos4 = 0; pos4 < possibleCharacters.Count; pos4++)
                            {
                                for (int pos5 = 0; pos5 < possibleCharacters.Count; pos5++)
                                {
                                    string possibleAddition =
                                        (permutationArrays[0][Math.Min(pos1, permutationArrays[0].Count - 1)] +
                                        permutationArrays[1][Math.Min(pos2, permutationArrays[1].Count - 1)] +
                                        permutationArrays[2][Math.Min(pos3, permutationArrays[2].Count - 1)] +
                                        permutationArrays[3][Math.Min(pos4, permutationArrays[3].Count - 1)] +
                                        permutationArrays[4][Math.Min(pos5, permutationArrays[4].Count - 1)])
                                        .ToUpper();

                                    //Does this string contain more wildcards than we have yellow characters?
                                    if (!ret.Contains(possibleAddition) && (!strict || possibleAddition.Count(wildcardTester) <= unknowns - (possibleCharacters.Count - 1)))
                                    {
                                        ret.Add(possibleAddition);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return ret;
        }

        #endregion

        #region Form Element Events
        private void TxtLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = textBoxes.IndexOf((TextBox)sender);
            if (((TextBox)sender).Enabled)
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    ((TextBox)sender).Text = e.KeyChar.ToString().ToUpper();
                    ((TextBox)sender).BackColor = Color.Green;
                    this.focusTextBox(++index);
                }
                else if (e.KeyChar == (char)Keys.Back)
                {
                    ((TextBox)sender).Text = "";
                    ((TextBox)sender).BackColor = Color.White;
                    this.focusTextBox(--index);
                }
                else if (e.KeyChar == (char)Keys.Space)
                {
                    ((TextBox)sender).Text = "";
                    ((TextBox)sender).BackColor = Color.White;
                    this.focusTextBox(++index);
                }
            }

            e.Handled = true;
        }

        private void BtnGeneratePermutations_Click(object sender, EventArgs e)
        {
            this.locked = !this.locked;

            foreach (TextBox txt in textBoxes)
            {
                txt.Enabled = !this.locked;
            }
            txtRemainingLetters.Enabled = !this.locked;
            txtYellowLetters.Enabled = !this.locked;

            btnShow1Guess.Enabled = this.locked;
            btnShowAllPermutations.Enabled = this.locked;
            btnShowListOfKnownMatchingSecrets.Enabled = this.locked;
            btnShowListOfPermutationsThatAreValidGuesses.Enabled = this.locked;

            if (this.locked)
            {
                this.originalTemplateString = "";
                foreach (TextBox txt in textBoxes)
                {
                    originalTemplateString += txt.Text == "" ? "*" : txt.Text;
                }

                this.yellowLetters.AddRange(this.explode(txtYellowLetters.Text.ToUpper()));
                this.possibleLetters.AddRange(this.explode(txtRemainingLetters.Text.ToUpper()));
                this.generatePermutations();
            }
            else
            {
                this.yellowLetters.Clear();
                this.possibleLetters.Clear();

                for (int i = 0; i < 5; i++)
                {
                    textBoxes[i].Text = originalTemplateString[i] == '*' ? "" : originalTemplateString[i].ToString();
                }

                guessIndex = 0;
            }
        }

        private void BtnShow1Guess_Click(object sender, EventArgs e)
        {
            string guessToShow = this.permutations[guessIndex];
            for (int i = 0; i < 5; i++)
            {
                textBoxes[i].Text = guessToShow[i].ToString();
            }
            guessIndex++;
        }

        private void BtnShowAllPermutations_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm(this.permutations);
            listForm.ShowDialog();
        }

        private void BtnShowListOfPermutationsThatAreValidGuesses_Click(object sender, EventArgs e)
        {
            List<string> guesses =
                (from word in this.permutations
                 where this.validGuesses.Contains(word.ToLowerInvariant()) || this.secretWords.Contains(word.ToLowerInvariant())
                 select word).ToList();
                
            ListForm listForm = new ListForm(guesses);
            listForm.ShowDialog();
        }

        private void BtnShowListOfKnownMatchingSecrets_Click(object sender, EventArgs e)
        {
            List<string> guesses =
                (from word in this.permutations
                 where this.secretWords.Contains(word.ToLowerInvariant())
                 select word).ToList();

            ListForm listForm = new ListForm(guesses);
            listForm.ShowDialog();
        }
        #endregion

        #region Helper Functions

        private bool wildcardTester(char c)
        {
            return c == '*';
        }

        private IEnumerable<string> explode(string text)
        {
            List<string> ret = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                ret.Add(text[i].ToString());
            }
            return ret;
        }

        private void focusTextBox(int index)
        {
            if (index < 0)
            {
                return;
            }

            if (index <= 4)
            {
                textBoxes[index].Focus();
            }
            else
            {
                txtYellowLetters.Focus();
            }
        }
        #endregion
    }

    #region Global Helper Stuff
    public struct WildcardData
    {
        public int knownLetterIndex;
        public int stringIndex;
    }

    
    public static class MyExtensions
    {
        //Shamelessly stolen from https://stackoverflow.com/questions/12765819/more-efficient-way-to-get-all-indexes-of-a-character-in-a-string
        public static IEnumerable<int> AllIndexesOf(this string str, string searchstring)
        {
            int minIndex = str.IndexOf(searchstring);
            while (minIndex != -1)
            {
                yield return minIndex;
                minIndex = str.IndexOf(searchstring, minIndex + searchstring.Length);
            }
        }
    }
    #endregion


}