using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string InputName = "";

        private void btnOK_Click(object sender, EventArgs e)
        {
            InputName = txtName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { 
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
