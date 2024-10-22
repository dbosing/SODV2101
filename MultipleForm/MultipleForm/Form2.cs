using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForm
{
    public partial class Form2 : Form
    {
        // Number 1
        //public Form2(string Name)
        //{
        //    InitializeComponent();
        //    labelName.Text += Name;
        //}

        // Number 2
        public Form2()
        {
            InitializeComponent();

        }

        public string DisplayName = "";

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelName.Text += $"{DisplayName},";
            labelName.Text += "\n \n Please confirm your name!";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
