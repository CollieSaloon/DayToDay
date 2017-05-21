using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace DayToDay
{
    class Event : Activity
    {
        public Event(string text, int sTime, int dTime) : base(text, sTime, dTime)
        {
        }

        public override Color color { get => Colors.Purple; }
        public override string type { get => "Event"; }


    }
}
