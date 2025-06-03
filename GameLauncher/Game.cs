using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;

namespace GameLauncher
{
    public partial class Game : UserControl
    {
        public string? gamePath;
        public Process? gameProcess;
        DateTime startTime;
        public XmlNode? playTime;
        public XmlDocument? doc;
        public string xmlName = "";

        // Initializes Game Control component
        public Game()
        {
            InitializeComponent();
        }

        // Starts game when play button is clicked
        private void picPlayButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        // Starts game given a valid gamepath exists
        private void StartGame()
        {
            if (gamePath == null)
            {
                MessageBox.Show("Game path is not set.", "Error");
                return;
            }
            else
            {
                ProcessStart();
            }
        }

        private void ProcessStart()
        {
            try
            {
                startTime = DateTime.Now;
                labelName.Text = labelName.Text + " (Playing)";
                gameProcess = Process.Start(gamePath);
                gameProcess.EnableRaisingEvents = true;
                gameProcess.Exited += (sender, e) =>
                {
                    CloseGame();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Game path is not set.", "Error");
                labelName.Text = labelName.Text.Replace(" (Playing)", "");
            }
        }

        // Closes game
        private void CloseGame()
        {
            labelName.Text = labelName.Text.Replace(" (Playing)", "");
            CalculateTime();
        }

        // Calculates new playtime
        private void CalculateTime()
        {
            TimeSpan duration = DateTime.Now - startTime;
            UpdatePlayTime((int)duration.TotalSeconds);
        }

        // Updates playtime for game given time passed
        private void UpdatePlayTime(int seconds)
        {
            if (doc != null && playTime != null)
            {
                string timeString = playTime.InnerText;
                int timeInt = int.Parse(timeString);
                timeInt += seconds;
                playTime.InnerText = timeInt.ToString();
                SetLabelTime(timeInt);
                doc.Save(xmlName);
            }
        }

        // Sets time label with updated time
        public void SetLabelTime(int seconds)
        {
            float newTime = (float)Math.Round(seconds / 3600.0f, 1);
            labelTime.Text = "Time Played: " + newTime + " Hours";
        }

        // Changes play button to green upon mouse entering
        private void picPlayButton_MouseEnter(object sender, EventArgs e)
        {
            picPlayButton.Image = Properties.Resources.PlayButton;
        }

        // Reverts play button upon mouse leaving
        private void picPlayButton_MouseLeave(object sender, EventArgs e)
        {
            picPlayButton.Image = Properties.Resources.PlayButton2;
        }
    }
}
