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

namespace JapaneseTrainer
{
    public partial class Form1 : Form
    {             
        ConfigHandler configHandler;
        SentenceCreator sentenceCreator;
        string uri;

        public Form1()
        {      
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
            InitializeComponent();

            uri = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string[] array = uri.Split('\\');
            uri = "";
            for (int x = 0; x < (array.Length - 1); x++)
            {
                uri += array[x] + "\\";
            }
            uri += "Audio\\";
            Console.WriteLine(uri);

            configHandler = new ConfigHandler(this.Size);
            this.Size = configHandler.getFormSize();

            sentenceCreator = new SentenceCreator(lblJapanese, lblMeaning, configHandler, uri);
                       
            lblJapanese.Font = new Font(lblJapanese.Font.FontFamily, configHandler.getFontSize());            

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configHandler.increaseFontSize();
            lblJapanese.Font = new Font(lblJapanese.Font.FontFamily, configHandler.getFontSize());
            configHandler.createConfig();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configHandler.decreaseFontSize();
            lblJapanese.Font = new Font(lblJapanese.Font.FontFamily, configHandler.getFontSize());
            configHandler.createConfig();
        }

        private void btnNextKanji_Click(object sender, EventArgs e)
        {            
            sentenceCreator.writeToForm(innerTable);
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            configHandler.setFormSize(this.Size);
            configHandler.createConfig();
            MessageBox.Show("Closing Program");
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig(configHandler);
            formConfig.Show();
        }    
    }
}
