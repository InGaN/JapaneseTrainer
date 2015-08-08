using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Data.SQLite;

namespace JapaneseTrainer
{
    public partial class Form1 : Form
    {
        SQLiteConnection dbConnection;
        int fontSize;

        public Form1()
        {            
            SQLiteConnection.CreateFile("JapaneseDatabase.sqlite");
            dbConnection = new SQLiteConnection("Data Source=dbKanji.sqlite;Version=3;");
            dbConnection.Open();

            string sql = "SELECT * FROM KANJI WHERE id=2 ";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader read = cmd.ExecuteReader();

            Console.WriteLine("海 id: " + read[0] + " kanji: " + read[1] + " meaning: " + read[2]);

            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
            InitializeComponent();
            InitializeConfig();
            
            lblJapanese.Text = read[1].ToString();
            lblMeaning.Text = read[2].ToString();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontSize++;
            lblJapanese.Font = new Font(lblJapanese.Font.FontFamily, fontSize);
            createConfig();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontSize--;
            lblJapanese.Font = new Font(lblJapanese.Font.FontFamily, fontSize);
            createConfig();
        }

        private void createConfig()
        {
            var perUserAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string pathString = System.IO.Path.Combine(perUserAppData, "JapaneseTrainer");
            string fileName = "config.txt";
            System.IO.Directory.CreateDirectory(pathString);
            pathString = System.IO.Path.Combine(pathString, fileName);
            Console.WriteLine("Path to my file: {0}\n", pathString);

            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.StreamWriter writer = System.IO.File.CreateText(pathString))
                {
                    writer.Write(fontSize.ToString());
                }
            }
            else
            {
                try
                {
                    using (var stream = new System.IO.FileStream(pathString, System.IO.FileMode.Truncate))
                    {
                        using (var writer = new System.IO.StreamWriter(stream))
                        {
                           writer.Write(fontSize.ToString());
                        }
                    }
                }
                catch (System.IO.FileNotFoundException e)
                {
                    System.IO.File.Create(pathString);
                    createConfig();
                }
            }            
        }

        private void InitializeConfig()
        {
            var perUserAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string pathString = System.IO.Path.Combine(perUserAppData, "JapaneseTrainer");
            string fileName = "config.txt";
            pathString = System.IO.Path.Combine(pathString, fileName);

            if (System.IO.File.Exists(pathString))
            {
                string[] read = System.IO.File.ReadAllLines(pathString);
                read = read[0].Split(',');
                fontSize = Int32.Parse(read[0]);
                lblJapanese.Font = new Font(lblJapanese.Font.FontFamily, fontSize);
            }
            else
            {
                fontSize = (int)lblJapanese.Font.Size;
                lblJapanese.Font = new Font(lblJapanese.Font.FontFamily, fontSize);
                createConfig();
            }
        }
    }
}
