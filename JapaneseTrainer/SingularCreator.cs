using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace JapaneseTrainer
{
    class SingularCreator
    {
        SQLiteConnection dbConnection;
        ConfigHandler config;
        string databaseName, tableName;
        string sqliteVersion = "3";
        int totalEntries;

        public SingularCreator(char sessionType, ConfigHandler configHandler)
        {
            // throw exception instead and catch in creation on FormSingular.cs
            config = configHandler;
            switch (sessionType)
            {
                case 'v':
                case 'V':
                    Console.WriteLine("starting verb trainer");
                    databaseName = "JP_Verbs";
                    tableName = "VERBS";
                    setupDatabase();
                    break;
                default:
                    Console.WriteLine("ERROR - invalid session type for singular trainer!");
                    break;
            }
        }

        private void setupDatabase()
        {
            dbConnection = new SQLiteConnection("Data Source=" + databaseName + ".sqlite;Version=" + sqliteVersion + ";");
            dbConnection.Open();
            string sql = "SELECT COUNT(*) FROM "+ tableName;
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader read = cmd.ExecuteReader();
            if (Int32.TryParse(read[0].ToString(), out totalEntries))
                Console.WriteLine("Total read = " + totalEntries);
        }

        public string[] generateSingular()
        {
            Random random = new Random();
            int id = random.Next(1, totalEntries + 1);
            string sql = "SELECT * FROM " + tableName + " WHERE id=" + id.ToString();

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader read = cmd.ExecuteReader();

            string[] array = { read[0].ToString(), read[1].ToString(), read[2].ToString(), read[3].ToString(), read[4].ToString()};
            return array;
        }
    }
}
