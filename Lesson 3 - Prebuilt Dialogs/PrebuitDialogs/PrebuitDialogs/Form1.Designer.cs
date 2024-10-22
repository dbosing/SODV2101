namespace PrebuitDialogs
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
            btnOpenFile = new Button();
            txtFileContent = new TextBox();
            btnChangeFont = new Button();
            btnChangeColor = new Button();
            btnSaveFile = new Button();
            rtxtFileContent = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            cdChangeColor = new ColorDialog();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(409, 82);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(136, 34);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Open File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(33, 104);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.ScrollBars = ScrollBars.Vertical;
            txtFileContent.Size = new Size(354, 259);
            txtFileContent.TabIndex = 1;
            // 
            // btnChangeFont
            // 
            btnChangeFont.Location = new Point(43, 25);
            btnChangeFont.Name = "btnChangeFont";
            btnChangeFont.Size = new Size(141, 34);
            btnChangeFont.TabIndex = 2;
            btnChangeFont.Text = "Change Font";
            btnChangeFont.UseVisualStyleBackColor = true;
            btnChangeFont.Click += btnChangeFont_Click;
            // 
            // btnChangeColor
            // 
            btnChangeColor.Location = new Point(213, 25);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new Size(151, 34);
            btnChangeColor.TabIndex = 3;
            btnChangeColor.Text = "Change Color";
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(409, 139);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(136, 34);
            btnSaveFile.TabIndex = 4;
            btnSaveFile.Text = "Save File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // rtxtFileContent
            // 
            rtxtFileContent.Location = new Point(33, 445);
            rtxtFileContent.Name = "rtxtFileContent";
            rtxtFileContent.Size = new Size(354, 240);
            rtxtFileContent.TabIndex = 5;
            rtxtFileContent.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 76);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 6;
            label1.Text = "TXT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 417);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 7;
            label2.Text = "RTF";
            // 
            // cdChangeColor
            // 
            cdChangeColor.ShowHelp = true;
            cdChangeColor.HelpRequest += cd_HelpRequest;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 722);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtxtFileContent);
            Controls.Add(btnSaveFile);
            Controls.Add(btnChangeColor);
            Controls.Add(btnChangeFont);
            Controls.Add(txtFileContent);
            Controls.Add(btnOpenFile);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFile;
        private TextBox txtFileContent;
        private Button btnChangeFont;
        private Button btnChangeColor;
        private Button btnSaveFile;
        private RichTextBox rtxtFileContent;
        private Label label1;
        private Label label2;
        private ColorDialog cdChangeColor;
    }
}
