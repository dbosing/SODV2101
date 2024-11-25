using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_1__Dawn_Bosing_
{
    public partial class Form1 : Form
    {
        private string secretWord; // Word to be guessed
        private char[] displayWord; // Word displayed with guessed letters
        private int remainingGuesses = 6; // Number of incorrect guesses left
        private List<char> guessedLetters = new List<char>(); // Letters guessed so far
        private Random random = new Random(); // For selecting random word
        private string[] wordList = 
            { "hangman", "developer", "challenge", "windows", "forms", "books", "notebook",
              "bow valley college", "laptop", "software", "appplication", "whiteboard" }; // List of possible words
        private int roundNumber = 1; // Number of the round
        private int currentStreak = 0; // Current win streak of the player
        private int maxStreak = 0; // Maximum streak the player achieved
        private List<RoundResult> roundResults = new List<RoundResult>();

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            // Reset guesses
            remainingGuesses = 6;
            guessedLetters.Clear();

            // Select a random word for the player
            secretWord = wordList[random.Next(wordList.Length)];

            // Initialize display with blanks
            displayWord = new char[secretWord.Length];
            for (int i = 0; i < displayWord.Length; i++)
            {
                displayWord[i] = '_';
            }

            UpdateGameUI();
        }

        // Updates the game's UI
        private void UpdateGameUI()
        {
            wordLabel.Text = new string(displayWord);
            guessLabel.Text = "Guesses remaining: " + remainingGuesses;
            lettersGuessedLabel.Text = "Guessed letters: " + string.Join(", ", guessedLetters);
            lblRound.Text = "Round: " + roundNumber;
            lblStreak.Text = "Current Streak: " + currentStreak;
            lblMaxStreak.Text = "Max Streak: " + maxStreak;
        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            SubmitGuess();
        }

        private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                SubmitGuess();
                e.Handled = true;
            }
        }

        private void SubmitGuess()
        {
            string input = txtGuess.Text.ToLower();

            // Input validation (checks if input is a single letter)
            if (input.Length != 1 || !char.IsLetter(input[0]))
            {
                MessageBox.Show("Please enter a valid letter.");
                txtGuess.Clear();
                txtGuess.Focus();
                return;
            }

            char guessedLetter = input[0];

            // Check if the letter has already been guessed
            if (guessedLetters.Contains(guessedLetter))
            {
                MessageBox.Show("You've already guessed this letter!");
                txtGuess.Clear();
                txtGuess.Focus();
                return;
            }

            // Add the letter to the guessed letters list
            guessedLetters.Add(guessedLetter);
            bool correctGuess = false;

            // Check if the guessed letter is in the secret word
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guessedLetter)
                {
                    displayWord[i] = guessedLetter;
                    correctGuess = true;
                }
            }

            // If the guess was incorrect, reduce the number of remaining guesses
            if (!correctGuess)
            {
                remainingGuesses--;
            }

            UpdateGameUI();
            CheckGameStatus();
            txtGuess.Clear();
            txtGuess.Focus();
        }

        private void CheckGameStatus()
        {
            // Checks if the player has guessed all letters
            if (!displayWord.Contains('_'))
            {
                MessageBox.Show($"Congratulations! You guessed the word: {secretWord}");
                roundResults.Add(new RoundResult { Round = roundNumber, Status = "Win" });
                currentStreak++; // Increment the streak when the player wins
                maxStreak = Math.Max(currentStreak, maxStreak); // Track the maximum streak
                NextRound();
            }
            // Checks if the player rans out of guesses
            else if (remainingGuesses == 0)
            {
                MessageBox.Show($"Sorry, you lost! The word was: {secretWord}");
                roundResults.Add(new RoundResult { Round = roundNumber, Status = "Loss" });
                currentStreak = 0; // Reset the streak when the player loses
                NextRound();
            }
        }

        // Proceeds to the next round, and increments the number of rounds
        private void NextRound()
        {
            roundNumber++;
            StartNewGame();
        }

        private void btnShowResults_Click( object sender, EventArgs e )
        {
            string resultsMessage = "Round Results:\n";

            foreach (var result in  roundResults )
            {
                resultsMessage += $"Round {result.Round}: {result.Status}\n";
            }

            MessageBox.Show(resultsMessage, "Results");
        }

        public class RoundResult
        {
            public int Round { get; set; }
            public string Status { get; set; }
        }

    }
}
