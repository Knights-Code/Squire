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

        public Combatant(string name, int HP)
        {
            this.name = name;
            this.maxHP = HP;
            this.currentHP = HP;
            this.attackBonus = new int[3];
            this.damage = new string[3];
        }

        public Combatant(string name)
        {
            this.name = name;
            this.attackBonus = new int[3];
            this.damage = new string[3];
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
            return attackBonus[(index+1)];
        }

        public void setAttack(int index, int newBonus)
        {
            this.attackBonus[(index + 1)] = newBonus;
        }

        public string getDamage(int index)
        {
            return damage[(index+1)];
        }

        public void setDamage(int index, string newDamage)
        {
            this.damage[(index+1)] = newDamage;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
