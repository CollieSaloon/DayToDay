using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace DayToDay
{
    class Meal : Activity
    {
        public Meal(string text, int sTime, int dTime) : base(text, sTime, dTime)
        {
        }

        public override Color color { get => Colors.Coral; }
        public override string type { get => "Meal"; }

    }
}
