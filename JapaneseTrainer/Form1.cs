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

        public Form1()
        {      
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
            InitializeComponent();

            configHandler = new ConfigHandler();
            sentenceCreator = new SentenceCreator(lblJapanese, lblMeaning, lblKana);

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
            sentenceCreator.writeToForm();
        }                
    }
}
