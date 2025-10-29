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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblAnswer.Visible = true;
            lblAnswerLine2.Visible = true;
            btnNext.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            grpQuestion.Text = "Question 2";
        }
    }
}
