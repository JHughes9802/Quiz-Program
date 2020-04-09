using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Program
{
    public partial class Form1 : Form
    {

        private readonly SortedList<String, bool> Questions = new SortedList<String, bool>()
        {
            {"SSD are faster than HDD", true},
            {"Microsoft owns GitHub", true},
            {"100 is the ASCII code for 'A'", false}
        };

        private int QuestionNumber = -1;
        private int Score = 0;
        private string incorrectAnswers = null; // The variable to hold all "incorrect answers"

        public Form1()
        {
            InitializeComponent();
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            QuestionNumber++;

            if (QuestionNumber < Questions.Count)
            {
                KeyValuePair<String, bool> question = Questions.ElementAt(QuestionNumber);
                string questionText = question.Key;
                txtQuestion.Text = questionText;

                rdoTrue.Checked = false;
                rdoFalse.Checked = false;
            }

            else
            {
                btnCheckAnswer.Enabled = false;
                btnCheckAnswer.Text = "Quiz over!";

                /* I used a nested if/else statement to reduce redundant code.
                 * Is there a way I could've made this even more compact? */
                if (Score == Questions.Count)
                {
                    MessageBox.Show($"Your score is {Score}", "Quiz Over!");
                }

                /* This pulls from the incorrectAnswers variable,
                 * which displays the Key/Value for each incorrect answer.
                 * I could almost certainly make it look better, but I didn't
                 * want to spend too long on something that's currently trivial */
                else
                {
                    MessageBox.Show($"Your score is {Score}\n\nIncorrect Answers{incorrectAnswers}", "Quiz Over!");
                }
            }
        }

        private void CheckAnswer()
        {
            if (QuestionNumber < Questions.Count)
            {
                KeyValuePair<String, bool> question = Questions.ElementAt(QuestionNumber);
                bool correctAnswer = question.Value;

                if (correctAnswer == true && rdoTrue.Checked == true)
                {
                    Score++;
                }
                
                /* Changed this from an if to an if else so the next statement 
                 * doesn't get forced if this statement's conditions don't get met */
                else if (correctAnswer == false && rdoFalse.Checked == true)
                {
                    Score++;
                }

                /* This adds a new line and Key/Value pair to the incorrectAnswers
                 * variable every time the user gets a question wrong */
                else
                {
                    incorrectAnswers += $"\n{question}";
                }

                lblScore.Text = $"Score: {Score}";

                /* I added this because it was impossible to tab back to the radio buttons
                 * after answering the first question, despite having "Tab Stop" enabled.
                 * Note: you can't tab back if you press tab before selecting an answer.
                 * Instead, it'll only tab to the button. And if you press the arrow keys,
                 * it'll select the text box. Because of this, I'd likely opt to use
                 * a label if at all possible */
                rdoTrue.Focus();
            }
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            if (rdoTrue.Checked || rdoFalse.Checked)
            {
                CheckAnswer();
                ShowNextQuestion();
            }
        }
    }
}
