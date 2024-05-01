namespace PostManCloneUi
{
    partial class _mainWindowDashboard
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
            _appHeaderLabel = new Label();
            _apiLabel = new Label();
            apiTextBox = new TextBox();
            _apiTextBoxButton = new Button();
            _resultsLabel = new Label();
            systemStatus = new ToolStripStatusLabel();
            systemStatusBar = new StatusStrip();
            resultsTextBox = new TextBox();
            systemStatusBar.SuspendLayout();
            SuspendLayout();
            // 
            // _appHeaderLabel
            // 
            _appHeaderLabel.AutoSize = true;
            _appHeaderLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _appHeaderLabel.ForeColor = SystemColors.ControlLightLight;
            _appHeaderLabel.Location = new Point(45, 24);
            _appHeaderLabel.Name = "_appHeaderLabel";
            _appHeaderLabel.Size = new Size(440, 65);
            _appHeaderLabel.TabIndex = 0;
            _appHeaderLabel.Text = "PostMan Clone Test";
            // 
            // _apiLabel
            // 
            _apiLabel.AutoSize = true;
            _apiLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _apiLabel.ForeColor = SystemColors.ControlLightLight;
            _apiLabel.Location = new Point(50, 138);
            _apiLabel.Name = "_apiLabel";
            _apiLabel.Size = new Size(81, 48);
            _apiLabel.TabIndex = 1;
            _apiLabel.Text = "API:";
            // 
            // _apiTextBox
            // 
            apiTextBox.Location = new Point(137, 140);
            apiTextBox.Name = "_apiTextBox";
            apiTextBox.Size = new Size(1120, 55);
            apiTextBox.TabIndex = 2;
            // 
            // _apiTextBoxButton
            // 
            _apiTextBoxButton.BackColor = Color.Black;
            _apiTextBoxButton.ForeColor = SystemColors.ControlLightLight;
            _apiTextBoxButton.Location = new Point(1263, 140);
            _apiTextBoxButton.Name = "_apiTextBoxButton";
            _apiTextBoxButton.Size = new Size(124, 55);
            _apiTextBoxButton.TabIndex = 3;
            _apiTextBoxButton.TabStop = false;
            _apiTextBoxButton.Text = "Go";
            _apiTextBoxButton.UseVisualStyleBackColor = false;
            _apiTextBoxButton.Click += CallApiTextBoxButton_Click;
            // 
            // _resultsLabel
            // 
            _resultsLabel.AutoSize = true;
            _resultsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _resultsLabel.ForeColor = SystemColors.ControlLightLight;
            _resultsLabel.Location = new Point(50, 231);
            _resultsLabel.Name = "_resultsLabel";
            _resultsLabel.Size = new Size(139, 48);
            _resultsLabel.TabIndex = 6;
            _resultsLabel.Text = "Results:";
            // 
            // _systemStatus
            // 
            systemStatus.ActiveLinkColor = Color.DarkRed;
            systemStatus.AutoToolTip = true;
            systemStatus.Font = new Font("Segoe UI", 12F);
            systemStatus.ForeColor = SystemColors.ControlLightLight;
            systemStatus.Name = "_systemStatus";
            systemStatus.Size = new Size(78, 32);
            systemStatus.Text = "Ready";
            // 
            // _systemStatusBar
            // 
            systemStatusBar.ImageScalingSize = new Size(24, 24);
            systemStatusBar.Items.AddRange(new ToolStripItem[] { systemStatus });
            systemStatusBar.Location = new Point(0, 1053);
            systemStatusBar.Name = "_systemStatusBar";
            systemStatusBar.Size = new Size(1437, 39);
            systemStatusBar.SizingGrip = false;
            systemStatusBar.TabIndex = 5;
            systemStatusBar.Text = "_statusBar";
            // 
            // _resultsTextBox
            // 
            resultsTextBox.Location = new Point(50, 307);
            resultsTextBox.Multiline = true;
            resultsTextBox.Name = "_resultsTextBox";
            resultsTextBox.ScrollBars = ScrollBars.Both;
            resultsTextBox.Size = new Size(1337, 693);
            resultsTextBox.TabIndex = 7;
            // 
            // _mainWindowDashboard
            // 
            AcceptButton = _apiTextBoxButton;
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1437, 1092);
            Controls.Add(resultsTextBox);
            Controls.Add(_resultsLabel);
            Controls.Add(systemStatusBar);
            Controls.Add(_apiTextBoxButton);
            Controls.Add(apiTextBox);
            Controls.Add(_apiLabel);
            Controls.Add(_appHeaderLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "_mainWindowDashboard";
            Text = "Postman Clone";
            TopMost = true;
            KeyDown += _mainWindowDashboard_KeyDown;
            systemStatusBar.ResumeLayout(false);
            systemStatusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _appHeaderLabel;
        private Label _apiLabel;
        private TextBox apiTextBox;
        private Button _apiTextBoxButton;
        private Label _resultsLabel;
        private ToolStripStatusLabel systemStatus;
        private StatusStrip systemStatusBar;
        private TextBox resultsTextBox;
    }
}
