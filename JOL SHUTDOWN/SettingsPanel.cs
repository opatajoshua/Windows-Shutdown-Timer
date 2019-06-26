using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOL_SHUTDOWN
{
    public partial class SettingsPanel : UserControl
    {
        public SettingsPanel()
        {
            InitializeComponent();
        }

        void menuBtnChange(Button btn)
        {
            foreach (Button b in menuBtnPanel.Controls)
            {
                if (b != btn)
                {
                    b.BackColor = Color.FromArgb(29, 29, 29);
                }
            }
            btn.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            menuBtnChange(btnGeneral);
            pnlGeneral.BringToFront();
        }

        private void btnCountUp_Click(object sender, EventArgs e)
        {
            menuBtnChange(btnCountUp);
        }

        private void btnCountDown_Click(object sender, EventArgs e)
        {
            menuBtnChange(btnCountDown);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            menuBtnChange(btnSchedule);
        }

        public void btnAbout_Click(object sender, EventArgs e)
        {
            menuBtnChange(btnAbout);
            about1.BringToFront();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            menuBtnChange(btnHelp);
            help1.BringToFront();
        }
    }
}
