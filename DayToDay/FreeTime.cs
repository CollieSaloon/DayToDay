using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace DayToDay
{
    class FreeTime : Activity
    {
        public FreeTime(string text, int time) : base(text, time)
        {
        }

        public override Color color { get => Colors.DeepSkyBlue; }
    }
}
