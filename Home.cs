using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_org_personal_archive_projecy
{
    public partial class Home : Form
    {
        public string  userName;
        public Home()
        {
            InitializeComponent();
        }
        public Home(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            label2.Text= userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocumentScreen documentScreen= new DocumentScreen();
            documentScreen.Show();
        }
    }
}
