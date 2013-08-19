using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squire
{
    class Character
    {
        string name;
        decimal baseAC, touchAC, FFAC;
        ArrayList metricName, metricValue;

        public Character(string name)
        {
            this.name = name;
        }

        public override String ToString()
        {
            return name;
        }
    }
}
