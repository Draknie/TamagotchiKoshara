using System;
using System.Security.Cryptography.X509Certificates;

namespace TamagotchiKoshara
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Food foodApple = new Food { type = "яблоко", hungerpoints = 10 };
            Food foodPelmeni = new Food { type = "пельмени", hungerpoints = 30 };
            Food foodCake = new Food { type = "торт", hungerpoints = 40 };
            Food foodBigMac = new Food { type = "Биг Мак", hungerpoints = 50 };
            Drink drinkWater = new Drink { type = "воды", thirstpoints = 15 };
            Drink drinkMilk = new Drink { type = "молоко", thirstpoints = 25 };
            Drink drinkKakao = new Drink { type = "какао", thirstpoints = 35 };
            Drink drinkPivo = new Drink { type = "пива", thirstpoints = 50 };
            Console.WriteLine("Дайте имя своей кошке/коту.\n");
            Cat cat = new Cat { name = Console.ReadLine(), hunger = 5, thirst = 5 };
            MainMenu();
            int input = int.Parse(Console.ReadLine());
            while (flag)
            {
                switch (input)
                {
                    case 1:
                        cat.ToMeow();
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню...");
                        Console.ReadKey();
                        MainMenu();
                        input = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        cat.CheckStat();
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню...");
                        Console.ReadKey();
                        MainMenu();
                        input = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("\nВыберите чем хотите покормить котика:\n1 - Яблоко.\n2 - Пельмени.\n3 - Тортик.\n4 - Биг Мак.\n");
                        int fd = int.Parse(Console.ReadLine());
                        switch (fd)
                        {
                            case 1:
                                DoMeal(cat, foodApple);
                                break;
                            case 2:
                                DoMeal(cat, foodPelmeni);
                                break;
                            case 3:
                                DoMeal(cat, foodCake);
                                break;
                            case 4:
                                DoMeal(cat, foodBigMac);
                                break;
                        }
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню...");
                        Console.ReadKey();
                        MainMenu();
                        input = int.Parse(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("\nВыберите чем хотите напоить котика:\n1 - Водичка.\n2 - Молоко.\n3 - Какао.\n4 - Пиво.\n");
                        int dd = int.Parse(Console.ReadLine());
                        switch (dd)
                        {
                            case 1:
                                DoDrink(cat, drinkWater);
                                break;
                            case 2:
                                DoDrink(cat, drinkMilk);
                                break;
                            case 3:
                                DoDrink(cat, drinkKakao);
                                break;
                            case 4:
                                DoDrink(cat, drinkPivo);
                                break;
                        }
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню...");
                        Console.ReadKey();
                        MainMenu();
                        input = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        cat.ToPlay();
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню...");
                        Console.ReadKey();
                        MainMenu();
                        input = int.Parse(Console.ReadLine());
                        break;
                    case 6:
                        cat.ToRun();
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню...");
                        Console.ReadKey();
                        MainMenu();
                        input = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Такого пункта нет!");
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню...");
                        Console.ReadKey();
                        MainMenu();
                        input = int.Parse(Console.ReadLine());
                        break;
                }
            }
        }
        static void DoMeal(Cat c, Food f)
        {
            c.ToEat(f);
        }
        static void DoDrink(Cat c, Drink d)
        {
            c.ToDrink(d);
        }
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню:\n1 - Помяукать :3\n2 - Проверить характеристики.\n3 - Покушать.\n4 - Попить.\n5 - Поиграть.\n6 - Побегать.\n7 - Выход.\n");
        }
    }
}