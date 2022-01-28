using System.Windows;
using System.Windows.Controls;

namespace RBRExtraDash
{
    /// <summary>
    /// Logique d'interaction pour SettingsControlDemo.xaml
    /// </summary>
    public partial class SettingsControlDemo : UserControl
    {
        public RBRExtraDash Plugin { get; }

        public SettingsControlDemo()
        {
            InitializeComponent();
        }

        public SettingsControlDemo(RBRExtraDash plugin) : this()
        {
            this.Plugin = plugin;
        }

        void startRally(object sender, RoutedEventArgs e)
        {
            string[] drivers = { name1.Text, name2.Text, name3.Text, name4.Text, name5.Text };
            RBRExtraDash.hotseat = new HotseatOverlay();

            for (int i = 0; i < drivers.Length; i++)
            {
                string driverName = drivers[i].Trim();
                if (driverName != "")
                {
 
                    SimHub.Logging.Current.Info(driverName);
                    RBRExtraDash.hotseat.AddDriver(new Driver(driverName));
                }
 
            }

            
        }
    }
}
