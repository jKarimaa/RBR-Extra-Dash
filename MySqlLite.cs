using System;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace MySqlLite
{
    class DataClass
    {
        private SQLiteConnection sqlite;

        public DataClass()
        {
            //This part killed me in the beginning.  I was specifying "DataSource"
            //instead of "Data Source"
            
            sqlite = new SQLiteConnection("Data Source=D:\\RBR_hu\\Plugins\\NGPCarMenu\\RaceStat\\raceStatDB.sqlite3");

        }

        public DataTable selectQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                sqlite.Open();  //Initiate connection to the db
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt); //fill the datasource
            }
            catch (SQLiteException ex)
            {
                //Add your exception code here.
                SimHub.Logging.Current.Info("SQLite Exception: " + ex);
            }
            sqlite.Close();
            return dt;
        }
    }
}