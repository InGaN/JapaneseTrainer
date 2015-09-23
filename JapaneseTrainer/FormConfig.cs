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
            cbx_trainer_timer.Checked = configHandler.getTrainerTimerEnabled();            
            num_timer1.Value = (configHandler.getTrainerTimerInterval() < 2) ? 1 : (decimal)configHandler.getTrainerTimerInterval();
            num_timer2.Value = (configHandler.getTrainerTimerInterval2() < 2) ? 1 : (decimal)configHandler.getTrainerTimerInterval2();
            num_timer1.Enabled = num_timer2.Enabled = lbl_timer1.Enabled = lbl_timer2.Enabled = lbl_timer3.Enabled = lbl_timer4.Enabled = (cbx_trainer_timer.Checked);
        }

        private void cbShowID_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowID.Checked)
            {
                configHandler.setFlags(1);
            }
            else
            {
                configHandler.unsetFlags(1);
            }
            configHandler.createConfig();
        }

        private void cbHighlightVerbs_CheckedChanged(object sender, EventArgs e)
        {
            configHandler.createConfig();
        }

        private void cbx_trainer_timer_CheckedChanged(object sender, EventArgs e)
        {
            num_timer1.Enabled = num_timer2.Enabled = lbl_timer1.Enabled = lbl_timer2.Enabled = lbl_timer3.Enabled = lbl_timer4.Enabled = (((CheckBox)sender).Checked);
            configHandler.enableTrainerTimer(((CheckBox)sender).Checked);
        }
        private void num_timer_ValueChanged(object sender, EventArgs e)
        {
            configHandler.setTrainerTimerInterval((double)((NumericUpDown)sender).Value);
        }

        private void num_timer2_ValueChanged(object sender, EventArgs e)
        {
            configHandler.setTrainerTimerInterval2((double)((NumericUpDown)sender).Value);
        }
    }
}
