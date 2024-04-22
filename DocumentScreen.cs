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
            using (var folderBrowserDialog = new FolderBrowserDialog())    // creating object from Folder browser
            {
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  // open desktop as initial folder directory 
                DialogResult result = folderBrowserDialog.ShowDialog(); // checkhing result of dialoug 
                if (result == DialogResult.OK)   // if the result it ok     
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;  // create string of folder path that we initialize to desktop in line 35 
                    string[] files = Directory.GetFiles(selectedFolderPath);      // creating array that get the files of the selected folder
                    listBox1.Items.Clear();      // clear the list box before  getting new ones
                    foreach (string file in files)
                    {
                        listBox1.Items.Add(Path.GetFileName(file)); // adding the files path in the UI
                    }
                }
            }
        }
    }
}
