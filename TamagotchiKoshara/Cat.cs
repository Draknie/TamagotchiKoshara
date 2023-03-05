using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiKoshara
{
    struct Food
    {
        public string type;
        public int hungerpoints;
    }
    struct Drink
    {
        public string type;
        public int thirstpoints;
    }

    class Cat
    {
        public string? name;
        public int hunger;
        public int thirst;
        public void CheckStat()
        {
            Console.WriteLine($"Hunger = {hunger}/100\nThirst = {thirst}/100\n");
        }
        public void ToMeow()
        {
            Random rndmeow = new Random();
            int x = rndmeow.Next(1, 4);
            switch (x)
            {
                case 1:
                    Console.WriteLine("Мяу!\n");
                    break;
                case 2:
                    Console.WriteLine("Миу!\n");
                    break;
                case 3:
                    Console.WriteLine("Мияу!\n");
                    break;
                case 4:
                    Console.WriteLine("Мрр!\n");
                    break;
            }        
        }
        public void ToEat(Food f)
        {
            hunger += f.hungerpoints;
            Console.WriteLine($"{name} покушал/ла {f.type}. Восстановлено {f.hungerpoints} очков голода.\n");
        }
        public void ToDrink(Drink d)
        {
            thirst += d.thirstpoints;
            Console.WriteLine($"{name} попил/ла {d.type}. Восстановлено {d.thirstpoints} очков жажды.\n");
        }
        public void ToRun()
        {
            hunger = hunger - 20;
            thirst = thirst - 30;
            Console.WriteLine($"{name} и вы вместе бежите наперегонки!\n");
            IsDead();
        }
        public void ToPlay()
        {
            hunger = hunger - 30;
            thirst = thirst - 10;
            Random rndplay = new Random();
            int y = rndplay.Next(1, 4);
            switch (y)
            {
                case 1:
                    Console.WriteLine($"Вы и {name} поиграли в прятки.\n");
                    break;
                case 2:
                    Console.WriteLine($"{name} решил/ла поспаринговать с вами.\n");
                    break;
                case 3:
                    Console.WriteLine($"{name} кинул/ла в вас мячиком, это вызов!\n");
                    break;
            }
            IsDead();
        }
        public void IsDead()
        {
            if (hunger < 5 | thirst < 5)
            {
                Console.WriteLine($"Покойся с миром, {name}... :(\n");
                Environment.Exit(0);
            }
        }
    }
}