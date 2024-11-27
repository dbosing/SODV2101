namespace Assignment_3
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
            playerList = new ListBox();
            pictureBox1 = new PictureBox();
            playerName = new Label();
            teamName = new Label();
            playerStats = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPointsPerGame = new TextBox();
            txtAssistsPerGame = new TextBox();
            txtReboundsPerGame = new TextBox();
            txtStealsPerGame = new TextBox();
            txtPhotoPath = new TextBox();
            label5 = new Label();
            txtPlayerName = new TextBox();
            label6 = new Label();
            txtTeam = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // playerList
            // 
            playerList.FormattingEnabled = true;
            playerList.ItemHeight = 25;
            playerList.Location = new Point(461, 47);
            playerList.Name = "playerList";
            playerList.Size = new Size(479, 129);
            playerList.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 520);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.Location = new Point(65, 553);
            playerName.Name = "playerName";
            playerName.Size = new Size(59, 25);
            playerName.TabIndex = 2;
            playerName.Text = "Player";
            playerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // teamName
            // 
            teamName.AutoSize = true;
            teamName.Location = new Point(195, 553);
            teamName.Name = "teamName";
            teamName.Size = new Size(53, 25);
            teamName.TabIndex = 3;
            teamName.Text = "Team";
            teamName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerStats
            // 
            playerStats.AutoSize = true;
            playerStats.Location = new Point(65, 601);
            playerStats.Name = "playerStats";
            playerStats.Size = new Size(50, 25);
            playerStats.TabIndex = 4;
            playerStats.Text = "Stats";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(497, 191);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(659, 191);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(830, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 357);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 8;
            label1.Text = "Points Per Game:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 415);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 9;
            label2.Text = "Assists Per Game:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 476);
            label3.Name = "label3";
            label3.Size = new Size(176, 25);
            label3.TabIndex = 10;
            label3.Text = "Rebounds Per Game:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 538);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 11;
            label4.Text = "Steals Per Game:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPointsPerGame
            // 
            txtPointsPerGame.Location = new Point(622, 354);
            txtPointsPerGame.Name = "txtPointsPerGame";
            txtPointsPerGame.Size = new Size(288, 31);
            txtPointsPerGame.TabIndex = 12;
            // 
            // txtAssistsPerGame
            // 
            txtAssistsPerGame.Location = new Point(622, 412);
            txtAssistsPerGame.Name = "txtAssistsPerGame";
            txtAssistsPerGame.Size = new Size(288, 31);
            txtAssistsPerGame.TabIndex = 13;
            // 
            // txtReboundsPerGame
            // 
            txtReboundsPerGame.Location = new Point(659, 473);
            txtReboundsPerGame.Name = "txtReboundsPerGame";
            txtReboundsPerGame.Size = new Size(251, 31);
            txtReboundsPerGame.TabIndex = 14;
            // 
            // txtStealsPerGame
            // 
            txtStealsPerGame.Location = new Point(622, 535);
            txtStealsPerGame.Name = "txtStealsPerGame";
            txtStealsPerGame.Size = new Size(288, 31);
            txtStealsPerGame.TabIndex = 15;
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.Location = new Point(589, 595);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.Size = new Size(321, 31);
            txtPhotoPath.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 598);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 16;
            label5.Text = "Photo Path:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(589, 246);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(321, 31);
            txtPlayerName.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(461, 249);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 18;
            label6.Text = "Player Name:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTeam
            // 
            txtTeam.Location = new Point(589, 298);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(321, 31);
            txtTeam.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(461, 301);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 20;
            label7.Text = "Player Team:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 643);
            Controls.Add(txtTeam);
            Controls.Add(label7);
            Controls.Add(txtPlayerName);
            Controls.Add(label6);
            Controls.Add(txtPhotoPath);
            Controls.Add(label5);
            Controls.Add(txtStealsPerGame);
            Controls.Add(txtReboundsPerGame);
            Controls.Add(txtAssistsPerGame);
            Controls.Add(txtPointsPerGame);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(playerStats);
            Controls.Add(teamName);
            Controls.Add(playerName);
            Controls.Add(pictureBox1);
            Controls.Add(playerList);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox playerList;
        private PictureBox pictureBox1;
        private Label playerName;
        private Label teamName;
        private Label playerStats;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPointsPerGame;
        private TextBox txtAssistsPerGame;
        private TextBox txtReboundsPerGame;
        private TextBox txtStealsPerGame;
        private TextBox txtPhotoPath;
        private Label label5;
        private TextBox txtPlayerName;
        private Label label6;
        private TextBox txtTeam;
        private Label label7;
    }
}
