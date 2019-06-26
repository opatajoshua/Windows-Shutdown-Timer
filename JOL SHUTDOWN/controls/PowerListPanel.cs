using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOL_SHUTDOWN.controls
{
    public partial class PowerListPanel : UserControl
    {
        public PowerListPanel()
        {
            InitializeComponent();
        }

        /*
         *  int lockpc = 1;
            int signout = 2;
            int sleep = 3;
            int hibernate = 4;
            int shutdownNormal = 5;
            int shutdownForcibly = 6;
            int restart = 7;
         * 
         * */

        Button _selectedPower = null;
        Button _selectedButton = null;

        Button selectedPower
        {
            get
            {
                return _selectedPower;
            }
            set
            {
                _selectedPower = value;
                setColor(_selectedPower);
            }
        }

        void setColor(Button b)
        {
            foreach(Button btn in panel1.Controls)
            {
                btn.BackColor = Color.Transparent;
            }
            b.BackColor = Color.FromArgb(74, 83, 123);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPower = ((Button)sender);
        }
    }
}
