using PostManCloneLibrary.BusinessLogic;
using PostManCloneLibrary.Interfaces;

namespace PostManCloneUi
{
    public partial class _mainWindowDashboard : Form
    {
        private readonly IApiAccess apiAccess = new ApiAccess();

        public _mainWindowDashboard()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private async void CallApiTextBoxButton_Click(object sender, EventArgs e)
        {
            systemStatus.Text = "Calling API...";
            resultsTextBox.Text = string.Empty;

            if (!apiAccess.IsValidUrl(apiTextBox.Text))
            {
                systemStatus.Text = "Invalid URL";
                return;
            }

            try
            {
                resultsTextBox.Text = await apiAccess.CallApiAsync(apiTextBox.Text);

                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultsTextBox.Text = $"Enjoy this beautfiul exception message: {ex.Message}";
                systemStatusBar.Text = "Error";
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
