namespace GameLauncher
{
    partial class Game
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            picPlayButton = new PictureBox();
            labelTime = new Label();
            labelDesc = new Label();
            labelName = new Label();
            picGameIcon = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGameIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(picPlayButton);
            panel1.Controls.Add(labelTime);
            panel1.Controls.Add(labelDesc);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(picGameIcon);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 127);
            panel1.TabIndex = 0;
            // 
            // picPlayButton
            // 
            picPlayButton.Anchor = AnchorStyles.Right;
            picPlayButton.Image = Properties.Resources.PlayButton2;
            picPlayButton.Location = new Point(821, 11);
            picPlayButton.Name = "picPlayButton";
            picPlayButton.Size = new Size(50, 50);
            picPlayButton.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayButton.TabIndex = 4;
            picPlayButton.TabStop = false;
            picPlayButton.Click += picPlayButton_Click;
            picPlayButton.MouseLeave += picPlayButton_MouseLeave;
            picPlayButton.MouseHover += picPlayButton_MouseHover;
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTime.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTime.Location = new Point(797, 64);
            labelTime.Name = "labelTime";
            labelTime.RightToLeft = RightToLeft.No;
            labelTime.Size = new Size(90, 40);
            labelTime.TabIndex = 3;
            labelTime.Text = "Time Played: 0 Hours";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDesc
            // 
            labelDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDesc.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDesc.Location = new Point(136, 36);
            labelDesc.MaximumSize = new Size(500, 0);
            labelDesc.MinimumSize = new Size(150, 0);
            labelDesc.Name = "labelDesc";
            labelDesc.Padding = new Padding(0, 0, 0, 20);
            labelDesc.Size = new Size(400, 75);
            labelDesc.TabIndex = 2;
            labelDesc.Text = "Game Description";
            labelDesc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(136, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(96, 20);
            labelName.TabIndex = 1;
            labelName.Text = "Game Name";
            // 
            // picGameIcon
            // 
            picGameIcon.Image = Properties.Resources.Overwatch_circle_logo_svg;
            picGameIcon.Location = new Point(13, 11);
            picGameIcon.Name = "picGameIcon";
            picGameIcon.Size = new Size(100, 100);
            picGameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picGameIcon.TabIndex = 0;
            picGameIcon.TabStop = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(0);
            MinimumSize = new Size(300, 10);
            Name = "Game";
            Size = new Size(900, 127);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGameIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label labelDesc;
        public Label labelName;
        public PictureBox picGameIcon;
        public PictureBox picPlayButton;
        public Label labelTime;
    }
}
