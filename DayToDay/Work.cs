using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace DayToDay
{
    class Work : Activity
    {

        public Work(string text, int sTime, int dTime) : base(text, sTime, dTime)
        {
        }

        public override Color color { get => Colors.Red; }
        public override string type { get => "Work"; }

    }
}
