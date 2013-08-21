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
            baseAC = 10;
            touchAC = 10;
            FFAC = 10;
        }

        public void setBaseAC(decimal newBase)
        {
            baseAC = newBase;
        }

        public void setTouchAC(decimal newTouch)
        {
            touchAC = newTouch;
        }

        public void setFFAC(decimal newFF)
        {
            FFAC = newFF;
        }

        public void addMetric(String metricName, decimal metricValue)
        {
            this.metricName.Add(metricName);
            this.metricValue.Add(metricValue);
        }

        public void deleteMetric(int index)
        {
            metricName.RemoveAt(index);
            metricValue.RemoveAt(index);
        }

        public void updateMetric(int index, decimal newValue)
        {
            metricValue[index] = newValue;
        }

        public override String ToString()
        {
            return name;
        }
    }
}
