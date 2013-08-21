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

            metricName = new ArrayList();
            metricValue = new ArrayList();
        }

        public decimal getBaseAC()
        {
            return baseAC;
        }

        public decimal getTouchAC()
        {
            return touchAC;
        }

        public decimal getFFAC()
        {
            return FFAC;
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

        public int metricCount()
        {
            return metricName.Count;
        }

        public String getMetricName(int index)
        {
            return (String)metricName[index];
        }

        public decimal getMetricValue(int index)
        {
            return Convert.ToDecimal(metricValue[index]);
        }

        public void updateMetric(int index, decimal newValue)
        {
            if (index < metricName.Count && metricName.Count > 0)
                metricValue[index] = newValue;
        }

        public override String ToString()
        {
            return name;
        }

        public String toString()
        {
            String result = name;
            result += "\t";
            result += baseAC + "\t" + touchAC + "\t" + FFAC + "\t";
            result += metricName.Count;

            for (int i = 0; i < metricName.Count; i++)
                result += "\t"+metricName[i] + "\t" + metricValue[i];

            return result;
        }
    }
}
