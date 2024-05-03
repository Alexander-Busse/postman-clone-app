using PostManCloneLibrary.BusinessLogic;
using PostManCloneLibrary.Interfaces;

namespace PostManCloneUi
{
    public partial class MainWindowDashboard : Form
    {
        private readonly IApiAccess apiAccess = new ApiAccess();

        public MainWindowDashboard()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private async void CallApiTextBoxButton_Click(object sender, EventArgs e)
        {
            SystemStatus.Text = Resources.SystemStatusMessages.CallingApi;
            ResultsTextBox.Text = string.Empty;

            if (!apiAccess.IsValidUrl(ApiTextBox.Text))
            {
                SystemStatus.Text = Resources.SystemStatusMessages.InvalidUrl;
                return;
            }

            try
            {
                ResultsTextBox.Text = await apiAccess.CallApiAsync(ApiTextBox.Text);

                SystemStatus.Text = Resources.SystemStatusMessages.Ready;
            }
            catch (Exception ex)
            {
                ResultsTextBox.Text = string.Format(Resources.UiErrorMessages.Exception, ex.Message);
                SystemStatusBar.Text = Resources.SystemStatusMessages.Error;
            }
        }

        private void MainWindowDashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
