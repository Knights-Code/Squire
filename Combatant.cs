using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squire
{
    class Combatant
    {
        string name;
        int maxHP;
        int currentHP;
        int[] attackBonus;
        string[] damage;
        Boolean bPlayer;

        public Combatant(string name, int HP)
        {
            this.name = name;
            this.maxHP = HP;
            this.currentHP = HP;
            this.attackBonus = new int[3] {0,0,0};
            this.damage = new string[3] {"+0","+0","+0"};
            this.bPlayer = false;
        }

        public Combatant(string name)
        {
            this.name = name;
            this.attackBonus = new int[3] {0,0,0};
            this.damage = new string[3] {"+0","+0","+0"};
            this.bPlayer = true;
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
                else return "critical";
            }
            else
            {
                return "player";
            }
        }
    }
}
