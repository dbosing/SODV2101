namespace MultipleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Number 1
            //Form2 F2 = new Form2(txtName.Text);
            //F2.ShowDialog();

            //Number 2
            //Form2 F2 = new Form2();
            //F2.DispayName = txtName.Text;

            // Modal Form
            //F2.ShowDialog();

            // Modaless Form
            // F2.Show();

            // Check if the user clicked OK or Cancel
            Form2 F2 = new Form2();
            F2.DisplayName = txtName.Text;
            DialogResult result = F2.ShowDialog();
            if (result == DialogResult.OK)
            {
                labelResult.Text = "User clicked OK!";
            }
            if (result == DialogResult.Cancel)
            {
                labelResult.Text = "User clicked Cancel!";
            }
        }
    }
}
