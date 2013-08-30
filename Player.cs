using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Squire
{
    [Serializable]
    class Player : ISerializable
    {
        string name;
        int currentHP, nonlethal, maxHP;

        ArrayList abilityName, abilityDescription;

        public Player(string name, int maxHP)
        {
            this.name = name;
            currentHP = maxHP;
            this.maxHP = maxHP;
            nonlethal = 0;

            abilityName = new ArrayList();
            abilityDescription = new ArrayList();
        }

        public Player(SerializationInfo info, StreamingContext context)
        {
            name = (string)info.GetValue("Name", typeof(string));

            currentHP = (int)info.GetValue("CurrentHP", typeof(int));
            maxHP = (int)info.GetValue("MaxHP", typeof(int));
            nonlethal = (int)info.GetValue("Nonlethal", typeof(int));

            abilityName = (ArrayList)info.GetValue("AbilityName", typeof(ArrayList));
            abilityDescription = (ArrayList)info.GetValue("AbilityDescription", typeof(ArrayList));
        }

        public string getName()
        {
            return name;
        }

        public string HPTotal()
        {
            return currentHP + " / " + maxHP;
        }

        public void adjustNL(int NL)
        {
            nonlethal = nonlethal + NL >= 0 ? nonlethal + NL : 0; // Nonlethal cannot be reduced below 0
        }

        public void adjustHP(int HP)
        {
            currentHP = currentHP + HP > maxHP ? maxHP : currentHP + HP;
            
            // If the player is healing, reduce nonlethal damage by an equal amount.
            if (HP > 0)
                adjustNL(HP * -1);
        }

        public int getCurrentHP()
        {
            return currentHP;
        }

        public void setCurrentHP(int newHP)
        {
            if ( newHP <= maxHP )
                currentHP = newHP;
        }

        public int getMaxHP()
        {
            return maxHP;
        }

        public void setMaxHP(int newMax)
        {
            if (newMax > 0)
            {
                int diff = maxHP - newMax;
                maxHP = newMax;
                currentHP += diff;
                currentHP = currentHP < 1 ? 1 : currentHP;
            }
        }

        public int getNonLethal()
        {
            return nonlethal;
        }

        public void setNonLethal(int newNL)
        {
            nonlethal = newNL;
        }

        public int numAbilities()
        {
            return abilityName.Count;
        }

        public string getAbilityName(int index)
        {
            return (string)abilityName[index];
        }

        public string getAbilityDescription(int index)
        {
            return (string)abilityDescription[index];
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", name);

            info.AddValue("CurrentHP", currentHP);
            info.AddValue("MaxHP", maxHP);
            info.AddValue("Nonlethal", nonlethal);

            info.AddValue("AbilityName", abilityName);
            info.AddValue("AbilityDescription", abilityDescription);
        }
    }
}
