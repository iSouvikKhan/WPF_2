using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Optimize.WPF.Views
{
    public partial class StartupManagerView : UserControl
    {
        public StartupManagerView()
        {
            InitializeComponent();
            LoadProcesses();
        }

        private void LoadProcesses()
        {
            // Get list of processes and add them to ListBox
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                ProcessListBox.Items.Add(process.ProcessName);
            }
        }

        private void KillProcess_Click(object sender, RoutedEventArgs e)
        {
            // Kill selected process
            string selectedProcess = ProcessListBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedProcess))
            {
                Process[] processes = Process.GetProcessesByName(selectedProcess);
                foreach (Process process in processes)
                {
                    process.Kill();
                }
                LoadProcesses(); // Refresh the list after killing process
            }
            else
            {
                MessageBox.Show("Please select a process to kill.");
            }
        }

        private void StartProcess_Click(object sender, RoutedEventArgs e)
        {
            // Start a new process
            // You can open a file dialog to select an executable file or provide a text box for the user to input the process name
            // For simplicity, let's start notepad.exe
            Process.Start("notepad.exe");
            LoadProcesses(); // Refresh the list after starting process
        }
    }
}
