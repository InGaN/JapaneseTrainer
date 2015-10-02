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
        int priority;
        int currentID;
        int index = 0;
        int[] currentArray;

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
                    break;
                case 'a':
                case 'A':
                    Console.WriteLine("starting adjective trainer");
                    databaseName = "JP_Adjectives";
                    tableName = "ADJECTIVES";
                    break;
                case 'n':
                case 'N':
                    Console.WriteLine("starting noun trainer");
                    databaseName = "JP_Nouns";
                    tableName = "NOUNS";
                    break;
                default:
                    Console.WriteLine("ERROR - invalid session type for singular trainer!");
                    break;
            }
            setupDatabase();
            currentArray = createProiritizedArray();
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

        private int[] createProiritizedArray()
        {
            Console.WriteLine("Prioritizing items...");            
            int[] totalArray = { };
            for(int x = 9; x >= 0; x--)
            {
                List<int> IDarray = new List<int>();
                string sql = "SELECT id FROM " + tableName + " WHERE priority=" + x;
                SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    IDarray.Add(Int32.Parse(read["id"].ToString()));
                }
                int[] array = IDarray.ToArray();
                FisherYatesShuffle(array);
                totalArray = totalArray.Concat(array).ToArray();    
            }

            foreach (int value in totalArray)
            {
                Console.Write(value);
            }
            Console.WriteLine("");
            return totalArray;
        }

        private static void FisherYatesShuffle<T>(T[] array)
        {
            int n = array.Length;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {                
                int r = i + (int)(random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }

        public string[] generateSingular()
        {            
            int id = currentArray[index];
            index++;
            if(index >= totalEntries)
            {
                index = 0;
                currentArray = createProiritizedArray();
                Console.WriteLine("Generating new array of IDs");
            }
            string sql = "SELECT * FROM " + tableName + " WHERE id=" + id.ToString();

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader read = cmd.ExecuteReader();

            string[] array = { read[0].ToString(), read[1].ToString(), read[2].ToString(), read[3].ToString(), read[4].ToString()};
            currentID = Int32.Parse(read[0].ToString());
            priority = Int32.Parse(read[5].ToString());

            return array;
        }

        public void changePriority(int newPriority)
        {
            if (newPriority <= 9 && newPriority >= 0)
            {
                priority = newPriority;
                string sql = "UPDATE " + tableName + " SET priority=" + newPriority.ToString() + " WHERE id=" + currentID.ToString();

                SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader read = cmd.ExecuteReader();
                Console.WriteLine("Database updated - ID:" + currentID + " new priority:" + newPriority.ToString());
            }
        }

        public int getPriority()
        {
            return priority;
        }
    }
}
