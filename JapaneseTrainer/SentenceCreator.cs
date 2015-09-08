using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Drawing;

namespace JapaneseTrainer
{
    class SentenceCreator
    {
        Label JapaneseLabel;
        Label EnglishLabel;
        SQLiteConnection dbConnection;
        ConfigHandler Config;
        int totalEntries;
        string uri;

        public SentenceCreator(Label japaneseLabel, Label englishLabel, ConfigHandler configHandler, string audioURI)
        {
            JapaneseLabel = japaneseLabel;
            EnglishLabel = englishLabel;
            Config = configHandler;
            uri = audioURI;

            //SQLiteConnection.CreateFile("JapaneseDatabase.sqlite");
            dbConnection = new SQLiteConnection("Data Source=dbKanji.sqlite;Version=3;");
            dbConnection.Open();

            string sql = "SELECT COUNT(*) FROM SENTENCES";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader read = cmd.ExecuteReader();
            if(Int32.TryParse(read[0].ToString(), out totalEntries))
                Console.WriteLine("Total read = " + totalEntries);
        }

        private string[] generateNewSentence()
        {
            Random random = new Random();
            int id = random.Next(1, totalEntries + 1);            
            string sql = "SELECT * FROM SENTENCES WHERE id=" + id.ToString();
            
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader read = cmd.ExecuteReader();
            Console.WriteLine("海 id: " + read[0] + " kanji: " + read[1] + " meaning: " + read[2] + " kana: " + read[3]);

            string[] array = { read[0].ToString(), read[1].ToString(), read[2].ToString(), read[3].ToString() };
            return array;
        }

        public string kanaSplitter(string inputKana, string inputKanji)
        {
            string[] kanaArray = inputKana.Split('|');
            string kanaString = "";
            int kanaIdx = 0;

            for (int x = 0; x < inputKanji.Length; x++ )
            {
                if (!isKana(inputKanji[x]))
                {
                    kanaString = kanaString + kanaArray[kanaIdx] + "  ";
                    if ((kanaIdx+1) < kanaArray.Length)
                        kanaIdx++;
                }
                else
                {
                    kanaString = kanaString + "  ";
                }
            }

            return kanaString;
        }

        public void writeToForm(TableLayoutPanel panel)
        {            
            string[] read = generateNewSentence();
            expandTable(read[1], read[3], panel);
            EnglishLabel.Text = read[2];

            int soundId;
            if (Int32.TryParse(read[0], out soundId))                
                playSound(soundId);

            //JapaneseLabel.Text = read[0];            
            //KanaLabel.Text = kanaSplitter(read[2], read[0]);
        }

        private bool isKana(char input)
        {
            bool output = false;
            if (input >= 12353 && input <= 12436)
                output = true; // Hiragana
            else if (input >= 12449 && input <= 12539)
                output = true; // Katakana
            return output;
        }

        private void expandTable(string inputKanji, string inputKana, TableLayoutPanel InnerTable)
        {            
            InnerTable.Controls.Clear();
            InnerTable.ColumnStyles.Clear();
            InnerTable.RowStyles.Clear();
            InnerTable.ColumnCount = 0;
            InnerTable.RowCount = 2;
            //InnerTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;           
            string[] kanaArray = inputKana.Split('|');
            int kanaIndex = 0;
            bool tagFlag = false;
            bool verbFlag = false;
            bool closeFlag = false;
            int y = 0;

            for (int x = 0; x < inputKanji.Length; x++ )
            {
                //InnerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
                //InnerTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                if (inputKanji[x] == '<') { tagFlag = true; }
                if (tagFlag)
                {
                    if (inputKanji[x] == 'v') { 
                        verbFlag = (closeFlag) ? false : true; 
                    }
                    else if (inputKanji[x] == '/') { closeFlag = true; }
                    else if (inputKanji[x] == '>') { 
                        tagFlag = false;
                        closeFlag = (closeFlag) ? false : true;
                    }
                    continue;
                }
                else
                {
                    InnerTable.ColumnCount = InnerTable.ColumnCount + 1;

                    Label furiganaLabel = new Label() { Text = "", Font = (new Font("Microsoft Sans Serif", Config.getFontSize() / 2, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))), TextAlign = ContentAlignment.BottomCenter, AutoSize = true, Dock = DockStyle.Fill };
                    Label kanjiLabel = new Label() { Font = (new Font("Microsoft Sans Serif", Config.getFontSize(), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))), TextAlign = ContentAlignment.TopCenter, AutoSize = true, Dock = DockStyle.Fill };

                    kanjiLabel.ForeColor = (verbFlag) ? Color.FromArgb(0, 255, 0, 0) : Color.FromArgb(0, 0, 0, 0);
                    furiganaLabel.ForeColor = (verbFlag) ? Color.FromArgb(0, 255, 0, 0) : Color.FromArgb(0, 0, 0, 0);
                    
                    if (!isKana(inputKanji[x]))
                    {
                        furiganaLabel.Text = kanaArray[kanaIndex];
                        if (kanaIndex < kanaArray.Length)
                            kanaIndex++;
                    }
                    kanjiLabel.Text = inputKanji[x].ToString();

                    InnerTable.Controls.Add(furiganaLabel, y, 0);
                    InnerTable.Controls.Add(kanjiLabel, y, 1);
                    y++;
                }                
            }
        }

        private void playSound(int id)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"" + uri + id + ".wav");
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to play sound: " + e.ToString());
            }
        }
    }
}
 