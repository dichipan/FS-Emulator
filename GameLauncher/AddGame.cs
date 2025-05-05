using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace GameLauncher
{
    public partial class AddGame : Form
    {
        string exePath = "";
        string sourceIconPath = "";
        string folderPath = "";
        string alphanumName;
        public AddGame()
        {
            InitializeComponent();
            this.Focus();
        }

        private void AddGame_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        // Brings up file browser to select a game executable
        private void button3_Click(object sender, EventArgs e)
        {
            openFileExe.Filter = "Executable Files (*.exe)|*.exe";
            openFileExe.Title = "Select an EXE File";

            if (openFileExe.ShowDialog() == DialogResult.OK)
            {
                string selectedExePath = openFileExe.FileName;
                textBoxFileLocation.Text = selectedExePath;
                buttonAddGame.Enabled = true;
                exePath = selectedExePath;
            }
        }

        // Brings up file browser to select an icon
        private void buttonChooseIcon_Click(object sender, EventArgs e)
        {
            openFileIcon.Filter = "Image Files (*.jpg;*.jpeg;*.png;*)|*.jpg;*.jpeg;*.png;*";
            openFileIcon.Title = "Select a square Image";

            if (openFileIcon.ShowDialog() == DialogResult.OK)
            {
                sourceIconPath = openFileIcon.FileName;
                pictureIcon.Image = Image.FromFile(sourceIconPath);
            }
        }

        // Adds game to the list
        private void buttonAddGame_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please enter a name for the game.", "Error");
                return;
            }
            if (richTextDesc.Text == "")
            {
                MessageBox.Show("Please enter a description for the game.", "Error");
                return;
            }
            CreateGameXML();
            CopyIcon();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Creates XML file for game
        private void CreateGameXML()
        {
            CreateGameFolder();
            string filePath = Path.Combine(folderPath, alphanumName + ".xml");
            XDocument doc = new XDocument(
                        new XDeclaration("1.0", "utf-8", null),
                        new XElement("Game",
                        new XElement("Name", textBoxName.Text),
                        new XElement("Description", richTextDesc.Text),
                        new XElement("Playtime", "0"),
                        new XElement("FilePath", textBoxFileLocation.Text)
                )
            );

            doc.Save(filePath);
        }

        // Creates game folder if necessary
        private void CreateGameFolder()
        {
            alphanumName = Regex.Replace(textBoxName.Text, "[^a-zA-Z0-9]", "");
            folderPath = Path.Combine(Application.StartupPath, "Games", alphanumName);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        // Copies icon to game folder
        private void CopyIcon()
        {
            try
            {
                if (File.Exists(sourceIconPath))
                {
                    string destIconPath = Path.Combine(folderPath, alphanumName + ".png");
                    File.Copy(sourceIconPath, destIconPath, true);
                }
                else
                {
                    MessageBox.Show("Source icon file does not exist.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying icon: " + ex.Message, "Error");
            }
        }
    }
}
