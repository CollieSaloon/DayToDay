using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace DayToDay
{
    class Work : IActivity
    {
        public Color color { get => Colors.Red; }
        public int duration { get => duration; set { if (value >= 0) duration = value; } }
    }
}
