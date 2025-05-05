namespace GameLauncher
{
    partial class AddGame
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonClose = new Button();
            buttonAddGame = new Button();
            textBoxName = new TextBox();
            labelName = new Label();
            labelDesc = new Label();
            richTextDesc = new RichTextBox();
            pictureIcon = new PictureBox();
            buttonChooseIcon = new Button();
            openFileExe = new OpenFileDialog();
            buttonBrowse = new Button();
            textBoxFileLocation = new TextBox();
            openFileIcon = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureIcon).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(476, 304);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonAddGame
            // 
            buttonAddGame.Enabled = false;
            buttonAddGame.Location = new Point(376, 304);
            buttonAddGame.Name = "buttonAddGame";
            buttonAddGame.Size = new Size(94, 29);
            buttonAddGame.TabIndex = 1;
            buttonAddGame.Text = "Add Game";
            buttonAddGame.UseVisualStyleBackColor = true;
            buttonAddGame.Click += buttonAddGame_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(259, 32);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(311, 27);
            textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(259, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 4;
            labelName.Text = "Name";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Location = new Point(259, 62);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(85, 20);
            labelDesc.TabIndex = 5;
            labelDesc.Text = "Description";
            // 
            // richTextDesc
            // 
            richTextDesc.Location = new Point(259, 85);
            richTextDesc.Name = "richTextDesc";
            richTextDesc.Size = new Size(311, 182);
            richTextDesc.TabIndex = 7;
            richTextDesc.Text = "";
            // 
            // pictureIcon
            // 
            pictureIcon.BorderStyle = BorderStyle.Fixed3D;
            pictureIcon.Image = Properties.Resources.no_image_icon_23485;
            pictureIcon.Location = new Point(23, 32);
            pictureIcon.Name = "pictureIcon";
            pictureIcon.Size = new Size(200, 200);
            pictureIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureIcon.TabIndex = 8;
            pictureIcon.TabStop = false;
            // 
            // buttonChooseIcon
            // 
            buttonChooseIcon.Location = new Point(71, 238);
            buttonChooseIcon.Name = "buttonChooseIcon";
            buttonChooseIcon.Size = new Size(100, 29);
            buttonChooseIcon.TabIndex = 9;
            buttonChooseIcon.Text = "Choose Icon";
            buttonChooseIcon.UseVisualStyleBackColor = true;
            buttonChooseIcon.Click += buttonChooseIcon_Click;
            // 
            // openFileExe
            // 
            openFileExe.FileName = "openFileDialog1";
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(12, 302);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(94, 29);
            buttonBrowse.TabIndex = 10;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += button3_Click;
            // 
            // textBoxFileLocation
            // 
            textBoxFileLocation.Location = new Point(112, 304);
            textBoxFileLocation.Name = "textBoxFileLocation";
            textBoxFileLocation.ReadOnly = true;
            textBoxFileLocation.Size = new Size(258, 27);
            textBoxFileLocation.TabIndex = 11;
            // 
            // openFileIcon
            // 
            openFileIcon.FileName = "openFileDialog1";
            // 
            // AddGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(582, 345);
            Controls.Add(textBoxFileLocation);
            Controls.Add(buttonBrowse);
            Controls.Add(buttonChooseIcon);
            Controls.Add(pictureIcon);
            Controls.Add(richTextDesc);
            Controls.Add(labelDesc);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(buttonAddGame);
            Controls.Add(buttonClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddGame";
            Text = "Add Game";
            Load += AddGame_Load;
            ((System.ComponentModel.ISupportInitialize)pictureIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Button buttonAddGame;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelDesc;
        private RichTextBox richTextDesc;
        private PictureBox pictureIcon;
        private Button buttonChooseIcon;
        private OpenFileDialog openFileExe;
        private Button buttonBrowse;
        private TextBox textBoxFileLocation;
        private OpenFileDialog openFileIcon;
    }
}