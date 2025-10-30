using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_12_GUI_assignment_2
{
    public partial class FormQuiz : Form
    {
        public FormQuiz()
        {
            InitializeComponent();
        }

        private void grpQuestion_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Galaxy;
        }

        int round = 0, score = 0;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            round++;

            lblAnswer.Visible = true;
            lblAnswerLine2.Visible = true;
            lblAnswerLine3.Visible = true;
            btnNext.Visible = true;

            if (round == 1)
            {
                if (radA.Checked)
                {
                    lblAnswerLine3.Text = "Daisy was almost named Alice, but you're still WRONG.";
                }
                else if (radB.Checked)
                {
                    lblAnswerLine3.Text = "These are 4 of the most common dog names of 2024. You're WRONG.";
                }
                else if (radC.Checked)
                {
                    score++;
                    lblAnswerLine3.Text = "You were correct!";
                }
                else if (radD.Checked)
                {
                    lblAnswerLine3.Text = "These are all names of other dogs I've known. You're WRONG.";
                }
            }
            else if (round == 2)
            {
                lblAnswerLine2.Text = "A) Pippin, Frodo, and Samwise";

                if (radA.Checked)
                {
                    score++;
                    lblAnswerLine3.Text = "Correct! Unfortunately, Meriadoc decided to chew on the cord for the heater.";
                }
                else if (radB.Checked)
                {
                    lblAnswerLine3.Text = "These were the names of the rabbits I had in the past.";
                }
                else if (radC.Checked)
                {
                    lblAnswerLine3.Text = "These are some common rabbit names; you were WRONG.";
                }
                else if (radD.Checked)
                {
                    lblAnswerLine3.Text = "These are names of famous rabbits; you were WRONG.";
                }
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblAnswer.Visible = false;
            lblAnswerLine2.Visible = false;
            lblAnswerLine3.Visible = false;
            btnNext.Visible = false;

            if (round == 1)
            {
                grpQuestion.Text = "Question 2";
                lblQuestion.Text = "What are my rabbits' names?";

                radA.Text = "A) Pippin, Frodo, and Samwise";
                radB.Text = "B) Pepsi, Nico, and Neville";
                radC.Text = "C) Thor, Clover, and Willow";
                radD.Text = "D) Thumper, Peter, and Bugs";
            }
            else if (round == 2)
            {
                grpQuestion.Text = "Congratulations!";
                lblQuestion.Text = "You have reached the end of the quiz.";
                radA.Text = "Final score: " + score;

                radB.Visible = false;
                radC.Visible = false;
                radD.Visible = false;
                lblAnswer.Visible = false;
                lblAnswerLine2.Visible = false;
                lblAnswerLine3.Visible = false;
                btnNext.Visible = false;
                btnSubmit.Visible = false;
            }
        }
    }
}
