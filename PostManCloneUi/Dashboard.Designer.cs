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
            _apiTextBox = new TextBox();
            _apiTextBoxButton = new Button();
            _resultsLabel = new Label();
            _systemStatus = new ToolStripStatusLabel();
            _systemStatusBar = new StatusStrip();
            _resultsTextBox = new TextBox();
            _systemStatusBar.SuspendLayout();
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
            _apiTextBox.Location = new Point(137, 140);
            _apiTextBox.Name = "_apiTextBox";
            _apiTextBox.Size = new Size(1120, 55);
            _apiTextBox.TabIndex = 2;
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
            _apiTextBoxButton.Click += _CallApiTextBoxButton_Click;
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
            _systemStatus.ActiveLinkColor = Color.DarkRed;
            _systemStatus.AutoToolTip = true;
            _systemStatus.Font = new Font("Segoe UI", 12F);
            _systemStatus.ForeColor = SystemColors.ControlLightLight;
            _systemStatus.Name = "_systemStatus";
            _systemStatus.Size = new Size(78, 32);
            _systemStatus.Text = "Ready";
            // 
            // _systemStatusBar
            // 
            _systemStatusBar.ImageScalingSize = new Size(24, 24);
            _systemStatusBar.Items.AddRange(new ToolStripItem[] { _systemStatus });
            _systemStatusBar.Location = new Point(0, 1053);
            _systemStatusBar.Name = "_systemStatusBar";
            _systemStatusBar.Size = new Size(1437, 39);
            _systemStatusBar.SizingGrip = false;
            _systemStatusBar.TabIndex = 5;
            _systemStatusBar.Text = "_statusBar";
            // 
            // _resultsTextBox
            // 
            _resultsTextBox.Location = new Point(50, 307);
            _resultsTextBox.Multiline = true;
            _resultsTextBox.Name = "_resultsTextBox";
            _resultsTextBox.ScrollBars = ScrollBars.Both;
            _resultsTextBox.Size = new Size(1337, 693);
            _resultsTextBox.TabIndex = 7;
            // 
            // _mainWindowDashboard
            // 
            AcceptButton = _apiTextBoxButton;
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1437, 1092);
            Controls.Add(_resultsTextBox);
            Controls.Add(_resultsLabel);
            Controls.Add(_systemStatusBar);
            Controls.Add(_apiTextBoxButton);
            Controls.Add(_apiTextBox);
            Controls.Add(_apiLabel);
            Controls.Add(_appHeaderLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "_mainWindowDashboard";
            Text = "Postman Clone";
            TopMost = true;
            KeyDown += _mainWindowDashboard_KeyDown;
            _systemStatusBar.ResumeLayout(false);
            _systemStatusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _appHeaderLabel;
        private Label _apiLabel;
        private TextBox _apiTextBox;
        private Button _apiTextBoxButton;
        private Label _resultsLabel;
        private ToolStripStatusLabel _systemStatus;
        private StatusStrip _systemStatusBar;
        private TextBox _resultsTextBox;
    }
}
