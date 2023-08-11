using ClearSolutions.Services;

namespace App
{
    public partial class AppForm : Form
    {
        private PackagesCleanerService CleanerService;

        public AppForm()
        {
            InitializeComponent();
            CleanerService = new PackagesCleanerService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonDeleteOutputPaths_Click(object sender, EventArgs e)
        {
            CleanerService.ClearOutputFolders(SourcePath);
            pathLabel.Text += "\nOutput packages have been removed";
        }

        private void ButtonBrowsePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog().Equals(DialogResult.OK))
            {
                SourcePath = folderBrowserDialog.SelectedPath;
                pathLabel.Text = SourcePath;
            }
        }
    }
}