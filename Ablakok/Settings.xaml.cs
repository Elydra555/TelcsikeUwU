using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TelcsikeUwU.Ablakok
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            LoadDiskUsage();
        }

        private void LoadDiskUsage()
        {
            DriveInfo driveInfo = new DriveInfo("C");

            double totalSpace = Math.Round(driveInfo.TotalSize / (1024.0 * 1024 * 1024),1);

            double freeSpace = Math.Round(driveInfo.AvailableFreeSpace /(1024.0 * 1024 * 1024), 1);

            double usedSpace = totalSpace - freeSpace;

            DiskUsageChart.Series = new SeriesCollection
    {
        new PieSeries
        {
            Title = "Kihasznált tárhely",
            Values = new ChartValues<double> { usedSpace },
            DataLabels = true
        },
        new PieSeries
        {
            Title = "Szabad tárhely",
            Values = new ChartValues<double> { freeSpace },
            DataLabels = true
        }
    };
            OsszHely.Text = $"Összes hely: {totalSpace:N1} GB";
        }
    }
}
