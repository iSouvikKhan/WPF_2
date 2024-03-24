using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Optimize.WPF.Views
{
    public partial class DiskCleanupView : UserControl
    {
        private BackgroundWorker cleanupWorker;

        public DiskCleanupView()
        {
            InitializeComponent();
        }

        private void StartCleanup_Click(object sender, RoutedEventArgs e)
        {
            if (cleanupWorker != null && cleanupWorker.IsBusy)
            {
                MessageBox.Show("Cleanup is already in progress.");
                return;
            }

            cleanupWorker = new BackgroundWorker();
            cleanupWorker.DoWork += CleanupWorker_DoWork;
            cleanupWorker.ProgressChanged += CleanupWorker_ProgressChanged;
            cleanupWorker.RunWorkerCompleted += CleanupWorker_RunWorkerCompleted;
            cleanupWorker.WorkerReportsProgress = true;
            cleanupWorker.WorkerSupportsCancellation = true;

            cleanupWorker.RunWorkerAsync();
        }

        private void CleanupWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i += 10)
            {
                System.Threading.Thread.Sleep(500);
                cleanupWorker.ReportProgress(i);
            }
        }

        private void CleanupWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void CleanupWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Cleanup completed.");
        }
    }
}
