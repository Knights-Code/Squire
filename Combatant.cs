using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Squire
{
    class Combatant
    {
        string name;
        int maxHP;
        int currentHP;
        int[] attackBonus;
        string[] damage;
        ArrayList effect;
        ArrayList roundsRemaining;
        Boolean bPlayer;
        Boolean bStable;

        public Combatant(string name, int HP)
        {
            this.name = name;
            this.maxHP = HP;
            this.currentHP = HP;
            this.attackBonus = new int[3] {0,0,0};
            this.damage = new string[3] {"+0","+0","+0"};
            this.bPlayer = false;
            this.bStable = true;

            effect = new ArrayList();
            roundsRemaining = new ArrayList();
        }

        public Combatant(string name)
        {
            this.name = name;
            this.attackBonus = new int[3] {0,0,0};
            this.damage = new string[3] {"+0","+0","+0"};
            this.bPlayer = true;
            this.bStable = true;

            effect = new ArrayList();
            roundsRemaining = new ArrayList();
        }

        public int EffectCount
        {
            get
            {
                return effect.Count;
            }
        }

        public string getEffectName(int index)
        {
            return (string)effect[index];
        }

        public decimal getEffectDuration(int index)
        {
            return (decimal)roundsRemaining[index];
        }

        public void addEffect(string name, decimal duration)
        {
            effect.Add(name);
            roundsRemaining.Add(duration);
        }

        public void setEffectName(string name, int index)
        {
            this.effect[index] = name;
        }

        public void setEffectDuration(decimal duration, int index)
        {
            this.roundsRemaining[index] = duration;
        }

        public void removeEffect(int index)
        {
            effect.RemoveAt(index);
            roundsRemaining.RemoveAt(index);
        }

        public Boolean isStable()
        {
            return bStable;
        }

        public void setStable(Boolean stable)
        {
            this.bStable = stable;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string newName)
        {
            this.name = newName;
        }

        public int getMaxHP()
        {
            return maxHP;
        }

        public int getCurrentHP()
        {
            return currentHP;
        }

        public void setCurrentHP(int newHP)
        {
            if (currentHP >= 0 && newHP < 0) this.bStable = false; // If we've been dropped automatically become unstable
            this.currentHP = newHP;
        }

        public int getAttack(int index)
        {
            return attackBonus[(index-1)];
        }

        public void setAttack(int index, int newBonus)
        {
            this.attackBonus[(index - 1)] = newBonus;
        }

        public string getDamage(int index)
        {
            return damage[(index-1)];
        }

        public void setDamage(int index, string newDamage)
        {
            this.damage[(index-1)] = newDamage;
        }

        public override string ToString()
        {
            return name;
        }

        public Boolean isPlayer()
        {
            return bPlayer;
        }

        public string status()
        {
            if (!bPlayer)
            {
                if (currentHP > (maxHP / 2)) return "healthy";
                else if (currentHP > (maxHP / 4)) return "injured";
                else if (currentHP > -10) return "critical";
                else return "dead";
            }
            else
            {
                return "player";
            }
        }

        internal void setMaxHP(int newMax)
        {
            this.maxHP = newMax;
        }
    }
}
