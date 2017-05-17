using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace DayToDay
{
    class Activity
    {
        public Color color { get; private set; }
        public float duration { get => duration; set { if (value >= 0) duration = value; } }
    }
}
