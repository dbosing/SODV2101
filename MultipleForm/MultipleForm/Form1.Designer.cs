namespace MultipleForm
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
            btnSubmit = new Button();
            txtName = new TextBox();
            label1 = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(122, 161);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 72);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(113, 209);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 25);
            labelResult.TabIndex = 3;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 292);
            Controls.Add(labelResult);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnSubmit);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private TextBox txtName;
        private Label label1;
        private Label labelResult;
    }
}
