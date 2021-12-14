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


    }
}
