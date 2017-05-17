using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayToDay
{
    class ActivityFactory
    {
        public static Activity GetActivity(int type, string text, int time)
        {
            switch (type)
            {
                case 0:
                    return new Meal(text, time);
                case 1:
                    return new Work(text, time);
                case 2:
                    return new Event(text, time);
                case 3:
                    return new Travel(text, time);
                case 4:
                    return new Hobby(text, time);
                case 5:
                    return new FreeTime(text, time);
                default:
                    break;
            }

            return null;
        }

    }
}
