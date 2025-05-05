namespace GameLauncher
{
    partial class FantaSYS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            achooToolStripMenuItem = new ToolStripMenuItem();
            lalalalaToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            eeToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            aaaToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            sssToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { achooToolStripMenuItem, lalalalaToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // achooToolStripMenuItem
            // 
            achooToolStripMenuItem.Name = "achooToolStripMenuItem";
            achooToolStripMenuItem.Size = new Size(211, 26);
            achooToolStripMenuItem.Text = "Load Game";
            // 
            // lalalalaToolStripMenuItem
            // 
            lalalalaToolStripMenuItem.Name = "lalalalaToolStripMenuItem";
            lalalalaToolStripMenuItem.Size = new Size(211, 26);
            lalalalaToolStripMenuItem.Text = "Open Main Folder";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(211, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eeToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // eeToolStripMenuItem
            // 
            eeToolStripMenuItem.Name = "eeToolStripMenuItem";
            eeToolStripMenuItem.Size = new Size(108, 26);
            eeToolStripMenuItem.Text = "ee";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aaaToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // aaaToolStripMenuItem
            // 
            aaaToolStripMenuItem.Name = "aaaToolStripMenuItem";
            aaaToolStripMenuItem.Size = new Size(116, 26);
            aaaToolStripMenuItem.Text = "aaa";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sssToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // sssToolStripMenuItem
            // 
            sssToolStripMenuItem.Name = "sssToolStripMenuItem";
            sssToolStripMenuItem.Size = new Size(110, 26);
            sssToolStripMenuItem.Text = "sss";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 10);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Resize += flowLayoutPanel1_Resize;
            // 
            // FantaSYS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 453);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 500);
            Name = "FantaSYS";
            Text = "Game Launcher";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem achooToolStripMenuItem;
        private ToolStripMenuItem lalalalaToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem eeToolStripMenuItem;
        private ToolStripMenuItem aaaToolStripMenuItem;
        private ToolStripMenuItem sssToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
