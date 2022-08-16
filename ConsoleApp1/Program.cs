using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите урон первого игрока: ");
            int HeroDamage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите урон второго игрока: ");
            int HeroDamage2 = Convert.ToInt32(Console.ReadLine());

            Hero hero = new Hero(100, "Raven", 10, HeroDamage);
            Hero hero2 = new Hero(150, "Nick", 5, HeroDamage2);

            while(hero.Health >= 0 && hero2.Health >= 0)
            {
                hero.ShowInfo();
                hero2.ShowInfo();
                hero.GetHit(hero2.Damage, hero.Armor);
                hero2.GetHit(hero.Damage, hero2.Armor);
                /*Console.ReadKey();*/
            }

            if (hero.Health <= 0)
            {
                Console.WriteLine("Победил: " + hero2.Name);
            }
            else
            {
                Console.WriteLine("Победил: " + hero.Name);
            }

            Console.ReadKey();
        }    
    }

    class Hero
    {
        private int _health;
        private string _name;
        private int _armor;
        private int _damage;

        public int Health
        {
            get { return _health; }
        }

        public int Damage
        {
            get { return _damage; }
        }

        public int Armor
        {
            get { return _armor; }
        }

        public string Name
        {
            get { return _name; }
        }

        public Hero (int health, string name, int armor, int damage)
        {
            _health = health;
            _name = name;
            _armor = armor;
            _damage = damage;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя персонажа: {_name}\nЖизни: {_health}\nЗащита: {_armor}\nУрон: {_damage}\n ---------------------");
        }
        
        public void ShowWin(string _name)
        {
            Console.WriteLine($"Победа персонажем {_name}");
        }

        public int GetHit(int _damage, int _armor)
        {
            return _health -= _damage / _armor;
        }
    }
}
