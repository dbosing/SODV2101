using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace PrebuitDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // Block of code to open a file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            ofd.Filter = "TXT file|*.txt|RTF file|*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".txt")
                {
                    // To read from a txt file and display in the proper textbox
                    string fileContent = File.ReadAllText(filePath);
                    txtFileContent.Text = fileContent;
                    txtFileContent.Visible = true;
                    rtxtFileContent.Visible = false;
                } else if (extension == ".rtf")
                {
                    // To read from rtf file and display in the proper textbox
                    rtxtFileContent.LoadFile(filePath);
                    rtxtFileContent.Visible = true;
                    txtFileContent.Visible = false;
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            // Block of code to save a file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save File";
            sfd.Filter = "TXT file|*.txt|RTF file|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".txt")
                {
                    // To save the txt file from TextBox
                    File.WriteAllText(filePath, txtFileContent.Text);
                } else if (extension == ".rtf")
                {
                    // To save the rtf file from RichTextBox
                    rtxtFileContent.SaveFile(filePath);
                }
            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            // Block of code to change the text font
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtFileContent.Font = fd.Font;
                rtxtFileContent.Font = fd.Font;
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            // Block of code to change the text color
            //ColorDialog cd = new ColorDialog();
            //cd.FullOpen = true;
            //cd.ShowHelp = true;
            //cd.HelpRequest += new EventHandler(cd_HelpRequest);
            //if (cd.ShowDialog() == DialogResult.OK)
            //{
            //    txtFileContent.ForeColor = cd.Color;
            //    rtxtFileContent.ForeColor = cd.Color;
            //}
            
            // Set up color change in design
            if(cdChangeColor.ShowDialog() == DialogResult.OK)
            {
                btnChangeColor.BackColor = cdChangeColor.Color;
            }

        }
        private void cd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Please choose a color.");
        }
    }
}
