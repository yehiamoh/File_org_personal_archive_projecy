using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_org_personal_archive_projecy
{
    public partial class DocumentScreen : Form
    {
        public DocumentScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DocumentScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;

                    // Get all files in the selected folder
                    string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);

                    // Display the files in a list box (or any other control you prefer)
                    listBox1.Items.Clear(); // Clear any existing items
                    foreach (string file in files)
                    {
                        listBox1.Items.Add(Path.GetFileName(file));
                    }
                }
            }
        }
    }
}
