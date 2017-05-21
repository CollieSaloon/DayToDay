using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayToDay
{
    class ActivityFactory
    {
        public static Activity GetActivity(int type, string text, int startTime, int duration)
        {
            switch (type)
            {
                case 0:
                    return new Meal(text, startTime, duration);
                case 1:
                    return new Work(text, startTime, duration);
                case 2:
                    return new Event(text, startTime, duration);
                case 3:
                    return new Travel(text, startTime, duration);
                case 4:
                    return new Hobby(text, startTime, duration);
                case 5:
                    return new FreeTime(text, startTime, duration);
                case 6:
                    return new Sleep(text, startTime, duration);
                default:
                    break;
            }

            return null;
        }

    }
}
