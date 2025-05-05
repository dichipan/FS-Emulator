using System.Xml;
using System.Linq;
using System.Diagnostics;

namespace GameLauncher
{
    public partial class FantaSYS : Form
    {
        string folderPath = Path.Combine(Application.StartupPath, "Games");
        string[] files = Array.Empty<string>();
        string[] folders = Array.Empty<string>();

        // Initializes the system
        public FantaSYS()
        {
            InitializeComponent();
            SetWhiteMenuStrip();
            LoadGames();
        }

        // Reads all folders and loads games
        private void LoadGames()
        {
            folders = Directory.GetDirectories(folderPath);
            foreach (string folder in folders)
            {
                string? xmlFile = Directory.GetFiles(folder, "*.xml").FirstOrDefault();
                string? imgFile = Directory.GetFiles(folder, "*png").FirstOrDefault();
                if (xmlFile != null) LoadGame(xmlFile, imgFile);
            }
        }

        // Loads a game given a .xml and icon file path
        private void LoadGame(string gameFileName, string iconPath)
        {
            XmlDocument doc = new XmlDocument();

            // Checks if the file exists and loads the XML document
            string filePath = Path.Combine(folderPath, gameFileName);
            if (File.Exists(filePath))
            {
                doc.Load(filePath);

                XmlNode? root = doc.SelectSingleNode("Game");
                if (root != null)
                {
                    Game newGame = new Game();
                    newGame.doc = doc;
                    newGame.xmlName = gameFileName;

                    // Checks if each individual node in the XML file is valid
                    XmlNode? nameNode = root.SelectSingleNode("Name");
                    XmlNode? descNode = root.SelectSingleNode("Description");
                    XmlNode? playTime = root.SelectSingleNode("Playtime");
                    XmlNode? gamePath = root.SelectSingleNode("FilePath");
                    if (nameNode != null)
                    {
                        newGame.labelName.Text = nameNode.InnerText;
                    }
                    if (descNode != null)
                    {
                        newGame.labelDesc.Text = descNode.InnerText;
                    }
                    if (playTime != null)
                    {
                        newGame.SetLabelTime(int.Parse(playTime.InnerText));
                        newGame.playTime = playTime;
                    }
                    if (gamePath != null)
                    {
                        newGame.gamePath = gamePath.InnerText;
                    }

                    // Adds the game to the flow layout panel and sets new sizes
                    flowLayoutPanel1.Controls.Add(newGame);
                    flowLayoutPanel1.Height += newGame.Height + 10;
                    newGame.Width = flowLayoutPanel1.Width;

                    // Sets color given odd/even index
                    if (flowLayoutPanel1.Controls.IndexOf(newGame) % 2 == 0)
                    {
                        newGame.BackColor = Color.White;
                    }
                    else
                    {
                        newGame.BackColor = Color.FromArgb(240, 240, 240);
                    }

                    // Sets the icon image if the file exists
                    if (iconPath != null)
                    {
                        if (File.Exists(iconPath))
                        {
                            newGame.picGameIcon.Image.Dispose();
                            newGame.picGameIcon.Image = Image.FromFile(iconPath);
                        }
                        else
                        {
                            MessageBox.Show($"The icon file '{iconPath}' does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // Handle the case where the file does not exist
                MessageBox.Show($"The file '{filePath}' does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Resize game controls along with flow layout panel
        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Width = flowLayoutPanel1.Width;
            }
        }

        // Sets menu strip color to white
        private void SetWhiteMenuStrip()
        {
            menuStrip1.Renderer = new ToolStripSystemRenderer();
            menuStrip1.BackColor = Color.White;
        }

        private void addGameMenuItem_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame();
            if (addGame.ShowDialog() == DialogResult.OK)
            {
                ReloadGames();
                MessageBox.Show("Game successfully added.");
            }
        }

        // Reloads game list
        private void ReloadGames()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Height = 0;
            LoadGames();
        }

        // Opens application directory in file explorer
        private void openFolderMenuItem_Click(object sender, EventArgs e)
        {
            string? appPath = Path.GetDirectoryName(Application.StartupPath);
            if (appPath != null) Process.Start("explorer.exe", appPath);
        }
    }
}
