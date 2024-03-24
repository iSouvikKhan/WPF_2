using System.IO;
using System;
using System.Windows.Controls;
using System.Management;

namespace Optimize.WPF.Views
{
    public partial class SystemInformationView : UserControl
    {
        public SystemInformationView()
        {
            InitializeComponent();
            LoadSystemInformation();
        }

        private void LoadSystemInformation()
        {
            // Get CPU name
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                CpuNameTextBlock.Text = obj["Name"].ToString();
                break; // Only first CPU
            }

            // Get RAM name
            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject obj in searcher.Get())
            {
                RamNameTextBlock.Text = obj["Name"].ToString();
                break; // Only first RAM
            }

            // Get disk space
            DriveInfo driveInfo = new DriveInfo(Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1));
            DiskSpaceTextBlock.Text = $"{driveInfo.TotalFreeSpace / (1024 * 1024 * 1024)} GB free / {driveInfo.TotalSize / (1024 * 1024 * 1024)} GB total";

            // Get Windows version
            WindowsVersionTextBlock.Text = Environment.OSVersion.VersionString;
        }
    }
}
