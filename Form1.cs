namespace File_org_personal_archive_projecy
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Home home = new Home(name);
            home.Show();
            
        }
    }
}