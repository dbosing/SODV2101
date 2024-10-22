namespace ControlsListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // get list, append "abc" to list items
            // listFruit.Items.Add("abc");

            // array
            //string[] FruitItems = { "Pear", "Peach" };
            //listFruit.Items.AddRange(FruitItems);

            if (txtNewFruit.Text != "")
            {
                listFruit.Items.Add(txtNewFruit.Text);
                txtNewFruit.Text = "";
            }
            else
            {
                MessageBox.Show("Please input a fruit to add.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // delete the selected item

            // using an easier way to delete at a selected index
            // listFruit.Items.RemoveAt(listFruit.SelectedIndex);

            // using if method
            if (listFruit.SelectedItem != null)
            {
                listFruit.Items.Remove(listFruit.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void txtNewFruit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listFruit.Items.Add(txtNewFruit.Text);
                txtNewFruit.Text = "";
            }
        }
    }
}
