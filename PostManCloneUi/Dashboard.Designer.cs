using PostManCloneUi.Resources;

namespace PostManCloneUi
{
    partial class MainWindowDashboard
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
            AppHeaderLabel = new Label();
            ApiLabel = new Label();
            ApiTextBox = new TextBox();
            ApiTextBoxButton = new Button();
            ResultsLabel = new Label();
            SystemStatus = new ToolStripStatusLabel();
            SystemStatusBar = new StatusStrip();
            ResultsTextBox = new TextBox();
            SystemStatusBar.SuspendLayout();
            SuspendLayout();
            // 
            // AppHeaderLabel
            // 
            AppHeaderLabel.AutoSize = true;
            AppHeaderLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppHeaderLabel.ForeColor = SystemColors.ControlLightLight;
            AppHeaderLabel.Location = new Point(45, 24);
            AppHeaderLabel.Name = "AppHeaderLabel";
            AppHeaderLabel.Size = new Size(440, 65);
            AppHeaderLabel.TabIndex = 0;
            AppHeaderLabel.Text = "PostMan Clone Test";
            // 
            // ApiLabel
            // 
            ApiLabel.AutoSize = true;
            ApiLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApiLabel.ForeColor = SystemColors.ControlLightLight;
            ApiLabel.Location = new Point(50, 138);
            ApiLabel.Name = "ApiLabel";
            ApiLabel.Size = new Size(81, 48);
            ApiLabel.TabIndex = 1;
            ApiLabel.Text = "API:";
            // 
            // ApiTextBox
            // 
            ApiTextBox.Location = new Point(137, 140);
            ApiTextBox.Name = "ApiTextBox";
            ApiTextBox.Size = new Size(1120, 55);
            ApiTextBox.TabIndex = 2;
            // 
            // ApiTextBoxButton
            // 
            ApiTextBoxButton.BackColor = Color.Black;
            ApiTextBoxButton.ForeColor = SystemColors.ControlLightLight;
            ApiTextBoxButton.Location = new Point(1263, 140);
            ApiTextBoxButton.Name = "ApiTextBoxButton";
            ApiTextBoxButton.Size = new Size(124, 55);
            ApiTextBoxButton.TabIndex = 3;
            ApiTextBoxButton.TabStop = false;
            ApiTextBoxButton.Text = UiComponentsDisplayNames.GoButtonText;
            ApiTextBoxButton.UseVisualStyleBackColor = false;
            ApiTextBoxButton.Click += CallApiTextBoxButton_Click;
            // 
            // ResultsLabel
            // 
            ResultsLabel.AutoSize = true;
            ResultsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultsLabel.ForeColor = SystemColors.ControlLightLight;
            ResultsLabel.Location = new Point(50, 231);
            ResultsLabel.Name = "ResultsLabel";
            ResultsLabel.Size = new Size(139, 48);
            ResultsLabel.TabIndex = 6;
            ResultsLabel.Text = "Results:";
            // 
            // SystemStatus
            // 
            SystemStatus.ActiveLinkColor = Color.DarkRed;
            SystemStatus.AutoToolTip = true;
            SystemStatus.Font = new Font("Segoe UI", 12F);
            SystemStatus.ForeColor = SystemColors.ControlLightLight;
            SystemStatus.Name = "SystemStatus";
            SystemStatus.Size = new Size(78, 32);
            SystemStatus.Text = UiComponentsDisplayNames.StatusBarReadyText;
            // 
            // SystemStatusBar
            // 
            SystemStatusBar.ImageScalingSize = new Size(24, 24);
            SystemStatusBar.Items.AddRange(new ToolStripItem[] { SystemStatus });
            SystemStatusBar.Location = new Point(0, 1053);
            SystemStatusBar.Name = "SystemStatusBar";
            SystemStatusBar.Size = new Size(1437, 39);
            SystemStatusBar.SizingGrip = false;
            SystemStatusBar.TabIndex = 5;
            SystemStatusBar.Text = "_statusBar";
            // 
            // ResultsTextBox
            // 
            ResultsTextBox.Location = new Point(50, 307);
            ResultsTextBox.Multiline = true;
            ResultsTextBox.Name = "ResultsTextBox";
            ResultsTextBox.ScrollBars = ScrollBars.Both;
            ResultsTextBox.Size = new Size(1337, 693);
            ResultsTextBox.TabIndex = 7;
            // 
            // MainWindowDashboard
            // 
            AcceptButton = ApiTextBoxButton;
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1437, 1092);
            Controls.Add(ResultsTextBox);
            Controls.Add(ResultsLabel);
            Controls.Add(SystemStatusBar);
            Controls.Add(ApiTextBoxButton);
            Controls.Add(ApiTextBox);
            Controls.Add(ApiLabel);
            Controls.Add(AppHeaderLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "MainWindowDashboard";
            TopMost = true;
            KeyDown += MainWindowDashboard_KeyDown;
            SystemStatusBar.ResumeLayout(false);
            SystemStatusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AppHeaderLabel;
        private Label ApiLabel;
        private TextBox ApiTextBox;
        private Button ApiTextBoxButton;
        private Label ResultsLabel;
        private ToolStripStatusLabel SystemStatus;
        private StatusStrip SystemStatusBar;
        private TextBox ResultsTextBox;
    }
}
