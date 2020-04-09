namespace Quiz_Program
{
    partial class Form1
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.pnlAnswer = new System.Windows.Forms.Panel();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.pnlAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(13, 13);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(224, 20);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.TabStop = false;
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.Controls.Add(this.rdoFalse);
            this.pnlAnswer.Controls.Add(this.rdoTrue);
            this.pnlAnswer.Location = new System.Drawing.Point(13, 40);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.Size = new System.Drawing.Size(224, 46);
            this.pnlAnswer.TabIndex = 1;
            this.pnlAnswer.TabStop = true;
            // 
            // rdoFalse
            // 
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.Location = new System.Drawing.Point(3, 26);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(50, 17);
            this.rdoFalse.TabIndex = 1;
            this.rdoFalse.TabStop = true;
            this.rdoFalse.Text = "False";
            this.rdoFalse.UseVisualStyleBackColor = true;
            // 
            // rdoTrue
            // 
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.Location = new System.Drawing.Point(3, 3);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(47, 17);
            this.rdoTrue.TabIndex = 0;
            this.rdoTrue.TabStop = true;
            this.rdoTrue.Text = "True";
            this.rdoTrue.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(96, 132);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(47, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: ?";
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(64, 92);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(116, 23);
            this.btnCheckAnswer.TabIndex = 4;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 163);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAnswer.ResumeLayout(false);
            this.pnlAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Panel pnlAnswer;
        private System.Windows.Forms.RadioButton rdoFalse;
        private System.Windows.Forms.RadioButton rdoTrue;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnCheckAnswer;
    }
}

