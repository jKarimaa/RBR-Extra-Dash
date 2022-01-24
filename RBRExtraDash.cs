using GameReaderCommon;
using SimHub.Plugins;
using System;

namespace RBRExtraDash
{

    [PluginDescription("Additional dash features for RBR")]
    [PluginAuthor("Joona Karimaa")]
    [PluginName("RBR Extra Dash")]

    public class RBRExtraDash : IPlugin, IDataPlugin, IWPFSettings
    {

        public RBRExtraDashSettings Settings;
        private double trip;

        /// <summary>
        /// Instance of the current plugin manager
        /// </summary>
        public PluginManager PluginManager { get; set; }

        /// <summary>
        /// Called one time per game data update, contains all normalized game data, 
        /// raw data are intentionnally "hidden" under a generic object type (A plugin SHOULD NOT USE IT)
        /// 
        /// This method is on the critical path, it must execute as fast as possible and avoid throwing any error
        /// 
        /// </summary>
        /// <param name="pluginManager"></param>
        /// <param name="data"></param>
        public void DataUpdate(PluginManager pluginManager, ref GameData data)
        {
            if (data.GameRunning)
            {
                if (data.GameName == "RBR")
                {
                    trip = Convert.ToDouble(pluginManager.GetPropertyValue("DataCorePlugin.GameData.StintOdo"));
                    
                    if (Convert.ToDouble(pluginManager.GetPropertyValue("DataCorePlugin.GameRawData.StageStartCountdown")) > 4)
                    {
                        if (Settings.trip != 0.0)
                        {
                            Settings.trip = 0.0;
                            pluginManager.SetPropertyValue("LastTrip", this.GetType(), 0.0);
                            //SimHub.Logging.Current.Info("Trip reset");
                        }
   
                    } else
                    {
                        pluginManager.SetPropertyValue("CurrentTrip", this.GetType(), trip - Settings.trip);
                    }
                }
            }
        }

        /// <summary>
        /// Called at plugin manager stop, close/dispose anything needed here ! 
        /// Plugins are rebuilt at game change
        /// </summary>
        /// <param name="pluginManager"></param>
        public void End(PluginManager pluginManager)
        {
            // Save settings
            this.SaveCommonSettings("GeneralSettings", Settings);
        }

        /// <summary>
        /// Returns the settings control, return null if no settings control is required
        /// </summary>
        /// <param name="pluginManager"></param>
        /// <returns></returns>
        public System.Windows.Controls.Control GetWPFSettingsControl(PluginManager pluginManager)
        {
            return new SettingsControlDemo(this);
        }

        /// <summary>
        /// Called once after plugins startup
        /// Plugins are rebuilt at game change
        /// </summary>
        /// <param name="pluginManager"></param>
        public void Init(PluginManager pluginManager)
        {
            // Load settings
            Settings = this.ReadCommonSettings<RBRExtraDashSettings>("GeneralSettings", () => new RBRExtraDashSettings());


            // Declare a property available in the property list
            /*pluginManager.AddProperty("LastTrip", this.GetType(), 0.0);*/
            pluginManager.AddProperty("CurrentTrip", this.GetType(), 0.0);

            // Declare an action which can be called
            pluginManager.AddAction("tripReset", this.GetType(), (a, b) =>
            {
                /*pluginManager.SetPropertyValue("LastTrip", this.GetType(), trip - Settings.trip);*/
                Settings.trip = trip;
                //SimHub.Logging.Current.Info("Trip reset to: " + trip);
            });
        }
    }
}
