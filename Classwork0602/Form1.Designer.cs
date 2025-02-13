namespace Classwork0602
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            btnCheck = new Button();
            lblResult = new Label();
            lblScore = new Label();
            lblEndMessage = new Label();
            lblTitel = new Label();
            lblTotalAttempts = new Label();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(118, 129);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 20);
            lblQuestion.TabIndex = 0;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(118, 152);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(203, 27);
            txtAnswer.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(327, 152);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 29);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(118, 215);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 3;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(447, 159);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(17, 20);
            lblScore.TabIndex = 5;
            lblScore.Text = "0";
            // 
            // lblEndMessage
            // 
            lblEndMessage.AutoSize = true;
            lblEndMessage.Location = new Point(124, 215);
            lblEndMessage.Name = "lblEndMessage";
            lblEndMessage.Size = new Size(0, 20);
            lblEndMessage.TabIndex = 6;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitel.Location = new Point(118, 41);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(206, 50);
            lblTitel.TabIndex = 7;
            lblTitel.Text = "Вікторина";
            // 
            // lblTotalAttempts
            // 
            lblTotalAttempts.AutoSize = true;
            lblTotalAttempts.Location = new Point(584, 159);
            lblTotalAttempts.Name = "lblTotalAttempts";
            lblTotalAttempts.Size = new Size(0, 20);
            lblTotalAttempts.TabIndex = 8;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(118, 329);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(94, 29);
            btnRestart.TabIndex = 9;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRestart);
            Controls.Add(lblTotalAttempts);
            Controls.Add(lblTitel);
            Controls.Add(lblEndMessage);
            Controls.Add(lblScore);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private TextBox txtAnswer;
        private Button btnCheck;
        private Label lblResult;
        private Label lblScore;
        private Label lblEndMessage;
        private Label lblTitel;
        private Label lblTotalAttempts;
        private Button btnRestart;
    }
}
