namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            DialogResult result = F2.ShowDialog();
            if (result == DialogResult.OK)
            {
                labelName.Text = "Hello " + $"{F2.InputName},";
            }
            else
            {
                labelName.Text = "Please login first!";
            }
        }
    }
}
