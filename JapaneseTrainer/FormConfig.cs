using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseTrainer
{
    public partial class FormConfig : Form
    {
        ConfigHandler configHandler;

        public FormConfig(ConfigHandler config)
        {
            InitializeComponent();
            configHandler = config;

            cbShowID.Checked = (configHandler.getFlags() % 2 == 1);
        }

        private void cbShowID_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowID.Checked)
            {
                configHandler.setFlags(1);
            }
            else
            {
                configHandler.setFlags(0);
            }
            configHandler.createConfig();
        }
    }
}
