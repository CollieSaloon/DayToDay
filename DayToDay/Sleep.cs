using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace DayToDay
{
    class Sleep : Activity
    {
        public Sleep(string text, int sTime, int dTime) : base(text, sTime, dTime)
        {
        }

        public override Color color => Colors.DarkGreen;

        public override string type => "Sleep";
    }
}
