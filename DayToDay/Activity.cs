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

        public Activity(string text, int time)
        {
            description = text;
            SetDuration(time);
        }

        public abstract Color color { get; }
        public int duration { get; private set; }
        public string description { get; set; }

        public void SetDuration(int time)
        {
            if (duration >= 0)
            {
                duration = time;
            }
            else
            {
                duration = 0;
            }
        }
    }
}
