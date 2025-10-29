namespace Topic_12_GUI_assignment_2
{
    partial class FormQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.radA = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radD = new System.Windows.Forms.RadioButton();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblAnswerLine2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpQuestion
            // 
            this.grpQuestion.BackColor = System.Drawing.Color.Transparent;
            this.grpQuestion.Controls.Add(this.radD);
            this.grpQuestion.Controls.Add(this.radC);
            this.grpQuestion.Controls.Add(this.radB);
            this.grpQuestion.Controls.Add(this.lblQuestion);
            this.grpQuestion.Controls.Add(this.radA);
            this.grpQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.grpQuestion.Location = new System.Drawing.Point(42, 32);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(400, 379);
            this.grpQuestion.TabIndex = 0;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "Question 1";
            this.grpQuestion.Enter += new System.EventHandler(this.grpQuestion_Enter);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(115, 429);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(248, 41);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radA.Location = new System.Drawing.Point(34, 129);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(143, 29);
            this.radA.TabIndex = 0;
            this.radA.TabStop = true;
            this.radA.Text = "radioButton1";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(29, 39);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(344, 82);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "What is the answer to this question?";
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radB.Location = new System.Drawing.Point(34, 182);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(143, 29);
            this.radB.TabIndex = 2;
            this.radB.TabStop = true;
            this.radB.Text = "radioButton1";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC.Location = new System.Drawing.Point(34, 232);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(143, 29);
            this.radC.TabIndex = 3;
            this.radC.TabStop = true;
            this.radC.Text = "radioButton1";
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radD.Location = new System.Drawing.Point(34, 282);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(143, 29);
            this.radD.TabIndex = 4;
            this.radD.TabStop = true;
            this.radD.Text = "radioButton1";
            this.radD.UseVisualStyleBackColor = true;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAnswer.Location = new System.Drawing.Point(464, 46);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(224, 32);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "The answer was:";
            this.lblAnswer.Visible = false;
            // 
            // lblAnswerLine2
            // 
            this.lblAnswerLine2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerLine2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAnswerLine2.Location = new System.Drawing.Point(469, 78);
            this.lblAnswerLine2.Name = "lblAnswerLine2";
            this.lblAnswerLine2.Size = new System.Drawing.Size(219, 154);
            this.lblAnswerLine2.TabIndex = 3;
            this.lblAnswerLine2.Text = "[Answer]";
            this.lblAnswerLine2.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(478, 247);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(201, 63);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next question";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(733, 498);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblAnswerLine2);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpQuestion);
            this.Name = "FormQuiz";
            this.Text = "Multiple Choice Questions";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblAnswerLine2;
        private System.Windows.Forms.Button btnNext;
    }
}

