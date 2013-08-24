using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squire
{
    [Serializable]
    class Player
    {
        string name;
        int currentHP, maxHP;
        int nonlethal;

        ArrayList abilityName, abilityDescription;

        public Player(string name, int maxHP)
        {
            this.name = name;
            this.maxHP = maxHP;
            nonlethal = 0;

            abilityName = new ArrayList();
            abilityDescription = new ArrayList();
        }

        public int getCurrentHP()
        {
            return currentHP;
        }

        public void setCurrentHP(int newHP)
        {
            currentHP = newHP;
        }

        public int getMaxHP()
        {
            return maxHP;
        }

        public void setMaxHP(int newMax)
        {
            maxHP = newMax;
        }

        public int getNonLethal()
        {
            return nonlethal;
        }

        public void setNonLethal(int newNL)
        {
            nonlethal = newNL;
        }

        public void addAbility(string name, string description)
        {
            abilityName.Add(name);
            abilityDescription.Add(description);
        }

        public void removeAbility(int index)
        {
            if (index >= 0 && index < abilityName.Count)
            {
                abilityName.RemoveAt(index);
                abilityDescription.RemoveAt(index);
            }
        }

        public void removeAbility(string name)
        {
            if (abilityName.Contains(name))
            {
                int removeIndex = abilityName.IndexOf(name);
                abilityName.RemoveAt(removeIndex);
                abilityDescription.RemoveAt(removeIndex);
            }
        }
    }
}
