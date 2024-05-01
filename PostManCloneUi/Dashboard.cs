namespace PostManCloneUi
{
    public partial class _mainWindowDashboard : Form
    {
        public _mainWindowDashboard()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        private async void _CallApiTextBoxButton_Click(object sender, EventArgs e)
        {

            // Add Some validation for API URL here
            try
            {
                _systemStatus.Text = "Calling API...";


                // Sample code - replace with the acutal API call.

                await Task.Delay(2000);


                _systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                _resultsTextBox.Text = $"Enjoy this beautfiul exception message: {ex.Message}";
                _systemStatusBar.Text = "Error";
            }
        }

        private void _mainWindowDashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
