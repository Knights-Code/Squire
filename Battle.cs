using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Squire
{
    [Serializable]
    public class Battle : ISerializable
    {
        public ArrayList combatantList, delayList, dyingList;
        public int cIndex, dlIndex, dyIndex;
        public decimal round;

        public Battle(ArrayList c, int cIndex, ArrayList dl, int dlIndex, ArrayList dy, int dyIndex, decimal round)
        {
            combatantList = c;
            this.cIndex = cIndex;
            delayList = dl;
            this.dlIndex = dlIndex;
            dyingList = dy;
            this.dyIndex = dyIndex;

            this.round = round;
        }

        public Battle(SerializationInfo info, StreamingContext context)
        {
            combatantList = (ArrayList)info.GetValue("CombatantList", typeof(ArrayList));
            cIndex        = (int)info.GetValue("CIndex", typeof(int));
            delayList     = (ArrayList)info.GetValue("DelayList", typeof(ArrayList));
            dlIndex       = (int)info.GetValue("DLIndex", typeof(int));
            dyingList     = (ArrayList)info.GetValue("DyingList", typeof(ArrayList));
            dyIndex       = (int)info.GetValue("DYIndex", typeof(int));

            round         = (decimal)info.GetValue("Round", typeof(decimal));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("CombatantList", combatantList);
            info.AddValue("CIndex", cIndex);
            info.AddValue("DelayList", delayList);
            info.AddValue("DLIndex", dlIndex);
            info.AddValue("DyingList", dyingList);
            info.AddValue("DYIndex", dyIndex);

            info.AddValue("Round", round);
        }
    }
}
