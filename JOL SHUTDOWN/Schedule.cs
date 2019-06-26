using System;

namespace JOL_SHUTDOWN
{
    public enum ScheduleActions { Lock, SignOut, Sleep, Hibernate, ShutDownNormal , ShutDownForcibly, Restart };
    public enum ScheduleRepeat { OneTime, Daily};
    public enum ScheduleDays { Daily, Monday, Tuesday, Wednesday, Thursday, Friday };
    
    public class Schedule
    {

        public Schedule(int id, ScheduleActions action, DateTime date, TimeSpan time, ScheduleRepeat repeat, int status)
        {
            this.id = id;
            this.action = action;
            this.date = date;
            this.time = time;
            this.repeat = repeat;
            this.status = status;

        }

        public Schedule(int id, ScheduleActions action, ScheduleDays day, TimeSpan time, ScheduleRepeat repeat, int status)
        {
            this.id = id;
            this.action = action;
            this.day = day;
            this.time = time;
            this.repeat = repeat;
            this.status = status;
        }

        public ScheduleActions action { get; private set; }
        public DateTime date { get; private set; }
        public ScheduleDays day { get; private set; }
        public int id { get; private set; }
        public ScheduleRepeat repeat { get; private set; }
        public int status { get; private set; }
        public TimeSpan time { get; private set; }
    }
}