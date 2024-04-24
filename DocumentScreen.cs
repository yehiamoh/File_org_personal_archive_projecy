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
           if(radioButton1.Checked)
            {
                getVideoDocs();
            }
           else if (radioButton2.Checked)
            {
                getAudioDocs(); 
            }else if (radioButton3.Checked)
            {
                getPicturesDocs(); 
            }
            else if (!radioButton1.Checked && !radioButton2.Checked&&!radioButton3.Checked)
            {
                MessageBox.Show("Please select at least one document type.");
            }
        }
        public void getAllDocs()
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())   // creating object from Folder browser
            {
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  // open desktop as initial folder directory 
                DialogResult result = folderBrowserDialog.ShowDialog(); // checkhing result of dialoug 
                if (result == DialogResult.OK)   // if the result it ok     
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;  // create string of folder path that we initialize to desktop in line 35 
                    string[] files = Directory.GetFiles(selectedFolderPath);      // creating array that get the files of the selected folder
                    listBox1.Items.Clear();   // clear the list box before getting new ones
                    foreach (string file in files)
                    {
                        listBox1.Items.Add(Path.GetFileName(file));    //adding the files path in the UI
                    }
                }
            }

        }

        public void getAudioDocs()
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                DialogResult result = folderBrowserDialog.ShowDialog();
                listBox1.Items.Clear();

                if (result == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    string[] mediaExtensions = { ".aac", ".mp3", ".wav", ".flac" };
                    try
                    {
                        var mediaFiles = Directory.EnumerateFiles(selectedFolderPath, "*.*", SearchOption.AllDirectories)
                                            .Where(file => mediaExtensions.Contains(Path.GetExtension(file).ToLower()));
                        foreach (string mediaFile in mediaFiles)
                        {
                            listBox1.Items.Add(Path.GetFileName(mediaFile));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        public void getVideoDocs()
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                DialogResult result = folderBrowserDialog.ShowDialog();
                listBox1.Items.Clear();
                if (result == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    string[] mediaExtensions = { ".mp4", ".avi", ".wmv", ".mkv", ".flv" };
                    try
                    {
                        var mediaFiles = Directory.EnumerateFiles(selectedFolderPath, "*.*", SearchOption.AllDirectories)
                                            .Where(file => mediaExtensions.Contains(Path.GetExtension(file).ToLower()));
                        foreach (string mediaFile in mediaFiles)
                        {
                            listBox1.Items.Add(Path.GetFileName(mediaFile));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        public void getPicturesDocs()
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                DialogResult result = folderBrowserDialog.ShowDialog();
                listBox1.Items.Clear();
                if (result == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    string[] mediaExtensions = { ".png", ".jpg" };
                    try
                    {
                        var mediaFiles = Directory.EnumerateFiles(selectedFolderPath, "*.*", SearchOption.AllDirectories)
                                            .Where(file => mediaExtensions.Contains(Path.GetExtension(file).ToLower()));
                        
                        foreach (string mediaFile in mediaFiles)
                        {
                            listBox1.Items.Add(Path.GetFileName(mediaFile));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            getAllDocs();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            getAllDocs();

        }
    }
}
