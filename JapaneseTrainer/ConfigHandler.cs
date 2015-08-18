using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JapaneseTrainer
{
    class ConfigHandler
    {
        int fontSize;

        public ConfigHandler()
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
            }
            else
            {
                fontSize = 30;            
                createConfig();
            }
        }

        public void createConfig()
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

        public void increaseFontSize()
        {
            fontSize++;
        }
        public void decreaseFontSize()
        {
            fontSize--;
        }
        public int getFontSize()
        {
            return fontSize;
        }
    }
}
