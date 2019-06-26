using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOL_SHUTDOWN
{
    public class CountTimerControl
    {
        Form1 fm;
        public CountTimerControl(string code,Form1 f)
        {
            _code = code;
            fm = f;
            assign();
        }

        public void setControl(string code, Form1 f)
        {
            _code = code;
            fm = f;
            assign();
        }
        string _code;
        string _name = "";
        Control _control;
        Button _button;

        public string code
        {
            get { return _code; }
        }
        public string name
        {
            get { return _name; }
        }
        public Control control
        {
            get { return _control; }
        }

        public Button button
        {
            get { return _button; }
        }

        //bool _lockMode = false;
        public bool lockMode
        {
            get 
            {
                if (_code == "cu")
                {
                    return fm.countUp1.lockMode;
                }
                else if (_code == "cd")
                {
                    return fm.countDown1.lockMode;
                }
                else if (_code == "sch")
                {
                    return fm.schedulePanel1.lockMode;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if(_code =="cu")
                {
                    fm.countUp1.lockMode = value;
                }
                else if (_code == "cd")
                {
                    fm.countDown1.lockMode = value;
                }
                else if (_code == "sch")
                {
                    fm.schedulePanel1.lockMode = value;
                }
            }
        }

        public bool Start() // handles the start operation
        {
            if (_code == "cu")
            {
                return fm.countUp1.Start();
            }
            else if (_code == "cd")
            {
                return fm.countDown1.Start();
            }
            else
            {
                fm.notification.Show("Timer has no start funtionality");
                return false;
            }
        }

        public bool Pause()// handles the pause operation
        {
            if (_code == "cu")
            {
                return fm.countUp1.Pause();
            }
            else if (_code == "cd")
            {
                return fm.countDown1.Pause();
            }
            else
            {
                fm.notification.Show("Timer has no pause funtionality");
                return false;
            }

        }

        public bool Stop() // handles the stop operation
        {
            if (_code == "cu")
            {
                return fm.countUp1.Stop();
            }
            else if (_code == "cd")
            {
                return fm.countDown1.Stop();
            }
            else
            {
                fm.notification.Show("Timer has no stop funtionality");
                return false;
            }
        }

        public bool Complete() // handles the stop operation
        {
            if (_code == "cu")
            {
                return fm.countUp1.Complete();
            }
            else if (_code == "cd")
            {
                return fm.countDown1.Complete();
            }
            else
            {
                fm.notification.Show("Timer has no complete funtionality");
                return false;
            }
        }

        public bool Set() // handles the set operation
        {
            if (_code == "cu")
            {
                return fm.countUp1.Set();
            }
            else if (_code == "cd")
            {
                return fm.countDown1.Set();
            }
            else if (_code == "sch")
            {
                return fm.schedulePanel1.Set();
            }
            else
            {
                return false;
            }
        }



        void assign()
        {
            if(_code =="cu")
            {
                _name = "Count Up Timer";
                _control = fm.countUp1;
                _button = fm.btnCountUp;
            }
            else if (_code == "cd")
            {
                _name = "Count Down Timer";
                _control = fm.countDown1;
                _button = fm.btnCountDown;
            }
            else if (_code == "sch")
            {
                _name = "Schedule Timer";
                _control = fm.schedulePanel1;
                _button = fm.btnSchedule;
            }
            else if (_code == "set")
            {
                _name = "Settings";
                _control = fm.settingsPanel1;
                _button = fm.btnSettings;
            }
            else
            {
                fm.notification.Show("Unknown control for "+ _code);
            }
        }
    }
}
