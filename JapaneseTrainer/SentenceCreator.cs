using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace JapaneseTrainer
{
    class SentenceCreator
    {
        Label JapaneseLabel;
        Label EnglishLabel;
        Label KanaLabel;
        SQLiteConnection dbConnection;

        public SentenceCreator(Label japaneseLabel, Label englishLabel, Label kanaLabel)
        {
            JapaneseLabel = japaneseLabel;
            EnglishLabel = englishLabel;
            KanaLabel = kanaLabel;

            //SQLiteConnection.CreateFile("JapaneseDatabase.sqlite");
            dbConnection = new SQLiteConnection("Data Source=dbKanji.sqlite;Version=3;");
            dbConnection.Open();
        }

        private string[] generateNewSentence()
        {
            int id = 2;
            string sql = "SELECT * FROM KANJI WHERE id=" + id.ToString();
            
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader read = cmd.ExecuteReader();
            Console.WriteLine("海 id: " + read[0] + " kanji: " + read[1] + " meaning: " + read[2] + " kana: " + read[3]);

            string[] array = { read[1].ToString(), read[2].ToString(), read[3].ToString() };
            return array;
        }

        public string kanaSplitter(string input)
        {
            string[] kanaArray = input.Split('|');
            string kanaString = "";

            for (int x = 0; x < kanaArray.Length; x++)
            {
                kanaString = kanaString + kanaArray[x] + "   ";
            }
            return kanaString;
        }

        public void writeToForm()
        {
            string[] read = generateNewSentence();
                        
            JapaneseLabel.Text = read[0];
            EnglishLabel.Text = read[1];
            KanaLabel.Text = kanaSplitter(read[2]);
        }

        
    }
}
