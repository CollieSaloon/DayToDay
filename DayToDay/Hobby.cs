using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace DayToDay
{
    class Hobby : Activity
    {
        public Hobby(string text, int sTime, int dTime) : base(text, sTime, dTime)
        {
        }

        public override Color color { get => Colors.MidnightBlue; }
        public override string type { get => "Hobby"; }

    }
}
