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
    public partial class SchedulePanel : UserControl
    {
        public Notification notification;
        public Form1 form1;
        public SchedulePanel()
        {
            InitializeComponent();
        }

        bool _lockMode = false;









        public bool Set() // handles the set operation
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel3.Visible = true;
            }
            else
            {
                panel1.Visible = true;
                panel3.Visible = false;
            }
            return true;
        }


        public bool lockMode
        {
            get { return _lockMode; }
            set
            {
                if (value == true)
                {
                    _lockMode = true;
                    panel4.Visible = false;
                }
                else
                {
                    _lockMode = false;
                    panel4.Visible = true;
                }
            }
        }
    }
}
