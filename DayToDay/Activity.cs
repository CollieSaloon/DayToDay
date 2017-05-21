using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace DayToDay
{
    abstract class Activity
    {

        public Activity(string text, int sTime, int dTime)
        {
            description = text;
            SetStartTime(sTime);
            SetDuration(dTime);
        }

        public abstract Color color { get; }
        public abstract string type { get; }
        public int startTime { get; private set; }
        public int duration { get; private set; }
        public string description { get; set; }

        public void SetDuration(int time)
        {
            if (time >= 0)
            {
                duration = time;
            }
            else
            {
                duration = 0;
            }
        }

        public void SetStartTime(int time)
        {
            if(time >= 0)
            {
                startTime = time;
            }
            else
            {
                time = -1;
            }
        }
    }
}
