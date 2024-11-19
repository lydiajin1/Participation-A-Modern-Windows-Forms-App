namespace Names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nicksSuperCoolText.Text) && !lstNames.Items.Contains(nicksSuperCoolText.Text))
                    lstNames.Items.Add(nicksSuperCoolText.Text);
        }
    }
}
