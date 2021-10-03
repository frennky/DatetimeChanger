using System;
using System.IO;
using System.Windows.Forms;

namespace DatetimeChanger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            using var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.AutoUpgradeEnabled = false;

            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                tbPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private async void btnUpdate_ClickAsync(object sender, EventArgs e)
        {
            if (Directory.Exists(tbPath.Text))
            {
                ToggleUserInterfaceOnOff();

                string[] files = Directory.GetFiles(tbPath.Text);

                statusLabel.Text = "Updating";
                statusStrip.Refresh();
                progressBar.Value = 0;
                progressBar.Maximum = files.Length;

                foreach (var file in files)
                {
                    var datetimeUpdater = new DatetimeUpdater(dtpRecorded.Value, dtpReal.Value, file);
                    await datetimeUpdater.UpdateAsync();
                    progressBar.PerformStep();
                }

                progressBar.ToolTipText = $"Updated {files.Length} files";
                statusLabel.Text = "Ready";
                statusStrip.Refresh();

                ToggleUserInterfaceOnOff();
            }
            else
            {
                MessageBox.Show($"Directory {tbPath.Text} does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToggleUserInterfaceOnOff()
        {
            btnUpdate.Enabled = !btnUpdate.Enabled;
            btnPath.Enabled = !btnPath.Enabled;
            tbPath.Enabled = !tbPath.Enabled;
            dtpRecorded.Enabled = !dtpRecorded.Enabled;
            dtpReal.Enabled = !dtpReal.Enabled;
        }
    }
}
