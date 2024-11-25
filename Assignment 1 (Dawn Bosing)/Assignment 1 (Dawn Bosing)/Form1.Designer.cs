namespace Assignment_1__Dawn_Bosing_
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
            wordLabel = new Label();
            txtGuess = new TextBox();
            guessBtn = new Button();
            btnShowResults = new Button();
            guessLabel = new Label();
            lettersGuessedLabel = new Label();
            lblRound = new Label();
            lblStreak = new Label();
            lblMaxStreak = new Label();
            SuspendLayout();
            // 
            // wordLabel
            // 
            wordLabel.Location = new Point(253, 38);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(133, 43);
            wordLabel.TabIndex = 0;
            wordLabel.TextAlign = ContentAlignment.MiddleCenter;
            wordLabel.UseWaitCursor = true;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(228, 105);
            txtGuess.MaxLength = 1;
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(189, 31);
            txtGuess.TabIndex = 1;
            txtGuess.TextAlign = HorizontalAlignment.Center;
            txtGuess.KeyPress += txtGuess_KeyPress;
            // 
            // guessBtn
            // 
            guessBtn.Location = new Point(263, 154);
            guessBtn.Name = "guessBtn";
            guessBtn.Size = new Size(123, 50);
            guessBtn.TabIndex = 2;
            guessBtn.Text = "Guess";
            guessBtn.UseVisualStyleBackColor = true;
            guessBtn.Click += guessBtn_Click;
            // 
            // btnShowResults
            // 
            btnShowResults.Location = new Point(497, 313);
            btnShowResults.Name = "btnShowResults";
            btnShowResults.Size = new Size(127, 45);
            btnShowResults.TabIndex = 3;
            btnShowResults.Text = "Results";
            btnShowResults.UseVisualStyleBackColor = true;
            btnShowResults.Click += btnShowResults_Click;
            // 
            // guessLabel
            // 
            guessLabel.Location = new Point(191, 217);
            guessLabel.Name = "guessLabel";
            guessLabel.Size = new Size(133, 56);
            guessLabel.TabIndex = 4;
            guessLabel.Text = "Guesses remaining: 6";
            guessLabel.TextAlign = ContentAlignment.MiddleCenter;
            guessLabel.UseWaitCursor = true;
            // 
            // lettersGuessedLabel
            // 
            lettersGuessedLabel.Location = new Point(330, 220);
            lettersGuessedLabel.Name = "lettersGuessedLabel";
            lettersGuessedLabel.Size = new Size(133, 50);
            lettersGuessedLabel.TabIndex = 5;
            lettersGuessedLabel.Text = "Guessed letters: ";
            lettersGuessedLabel.TextAlign = ContentAlignment.MiddleCenter;
            lettersGuessedLabel.UseWaitCursor = true;
            // 
            // lblRound
            // 
            lblRound.AutoSize = true;
            lblRound.Location = new Point(12, 9);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(64, 25);
            lblRound.TabIndex = 6;
            lblRound.Text = "Round";
            // 
            // lblStreak
            // 
            lblStreak.AutoSize = true;
            lblStreak.Location = new Point(12, 39);
            lblStreak.Name = "lblStreak";
            lblStreak.Size = new Size(123, 25);
            lblStreak.TabIndex = 7;
            lblStreak.Text = "Current Streak";
            // 
            // lblMaxStreak
            // 
            lblMaxStreak.AutoSize = true;
            lblMaxStreak.Location = new Point(12, 74);
            lblMaxStreak.Name = "lblMaxStreak";
            lblMaxStreak.Size = new Size(98, 25);
            lblMaxStreak.TabIndex = 8;
            lblMaxStreak.Text = "Max Streak";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 370);
            Controls.Add(lblMaxStreak);
            Controls.Add(lblStreak);
            Controls.Add(lblRound);
            Controls.Add(lettersGuessedLabel);
            Controls.Add(guessLabel);
            Controls.Add(btnShowResults);
            Controls.Add(guessBtn);
            Controls.Add(txtGuess);
            Controls.Add(wordLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label wordLabel;
        private TextBox txtGuess;
        private Button guessBtn;
        private Button btnShowResults;
        private Label guessLabel;
        private Label lettersGuessedLabel;
        private Label lblRound;
        private Label lblStreak;
        private Label lblMaxStreak;
    }
}
