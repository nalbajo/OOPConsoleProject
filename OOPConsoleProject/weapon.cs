using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Weapon
    {
        public string name;
        public string description;
        public int power;
    }

    public class WeaponBuilder
    {
        public string name;
        public string description;
        public int power; 
        public WeaponBuilder()
        {
            name = "무기이름";
            description = "무기설명";
            power = 0;
        }

        public Weapon Build()
        {
            Weapon weapon = new Weapon();
            weapon.name = name;
            weapon.description = description;
            weapon.power = power;

            return weapon;
        }

        public WeaponBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }
        public WeaponBuilder SetDescription(string description)
        {
            this.description = description;
            return this;
        }
        public WeaponBuilder SetPower(int power)
        {
            this.power = power;
            return this;
        }
    }

}
