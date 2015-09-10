using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JapaneseTrainer
{
    public class ConfigHandler
    {
        int fontSize;
        int formWidth;
        int formHeight;
                
        byte flags;
        const byte FLAG_SHOWID = 1;
        const byte FLAG_HIGHLIGHTVERBS = 2;

        public ConfigHandler(Size formSize)
        {
            var perUserAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string pathString = System.IO.Path.Combine(perUserAppData, "JapaneseTrainer");
            string fileName = "config.txt";
            pathString = System.IO.Path.Combine(pathString, fileName);

            formWidth = formSize.Width;
            formHeight = formSize.Height;

            flags = 0;

            if (System.IO.File.Exists(pathString))
            {
                try
                {
                    string[] read = System.IO.File.ReadAllLines(pathString);
                    read = read[0].Split(',');
                    fontSize = Int32.Parse(read[0]);
                    formWidth = Int32.Parse(read[1]);
                    formHeight = Int32.Parse(read[2]);
                    flags = Byte.Parse(read[3]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("ERROR - Index out of bounds reading config file!");
                    fontSize = 30;
                    createConfig();
                }                
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

            string configString = fontSize.ToString() + "," + formWidth + "," + formHeight + "," + flags;

            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.StreamWriter writer = System.IO.File.CreateText(pathString))
                {
                    writer.Write(configString);
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
                            writer.Write(configString);
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

        public Size getFormSize()
        {
            return new Size(formWidth, formHeight);
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
        public void setFormSize(Size formSize)
        {
            formWidth = formSize.Width;
            formHeight = formSize.Height;
        }
        public int getFormHeight()
        {
            return formHeight;
        }
        public int getFormWidth()
        {
            return formWidth;
        }
        public byte getFlags()
        {
            return flags;
        }
        public void setFlags(byte newFlags)
        {
            flags = newFlags;
        }
        public void unsetFlags(byte newFlags)
        {            
            flags = newFlags;
        }
    }
}
