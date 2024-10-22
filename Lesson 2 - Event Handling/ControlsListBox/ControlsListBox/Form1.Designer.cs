namespace ControlsListBox
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
            listFruit = new ListBox();
            btnAdd = new Button();
            txtNewFruit = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listFruit
            // 
            listFruit.FormattingEnabled = true;
            listFruit.ItemHeight = 25;
            listFruit.Items.AddRange(new object[] { "Apple", "Orange", "Banana", "Pineapple" });
            listFruit.Location = new Point(226, 40);
            listFruit.Name = "listFruit";
            listFruit.Size = new Size(223, 229);
            listFruit.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(276, 311);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 35);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNewFruit
            // 
            txtNewFruit.Location = new Point(257, 275);
            txtNewFruit.Name = "txtNewFruit";
            txtNewFruit.Size = new Size(150, 31);
            txtNewFruit.TabIndex = 2;
            txtNewFruit.KeyDown += txtNewFruit_KeyDown;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(276, 351);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 412);
            Controls.Add(btnDelete);
            Controls.Add(txtNewFruit);
            Controls.Add(btnAdd);
            Controls.Add(listFruit);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fruit List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listFruit;
        private Button btnAdd;
        private TextBox txtNewFruit;
        private Button btnDelete;
    }
}
