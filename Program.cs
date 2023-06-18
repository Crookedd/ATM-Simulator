using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            ATMFacade atmFacade = new ATMFacade();

            Console.WriteLine("Добро пожаловать в наш банкомат!");

            Console.WriteLine("Вставьте вашу карту.");
            atmFacade.InsertCard();

            /*Console.Write("Введите четырёхзначный Пароль: ");
            string pin = Console.ReadLine();*/
            string pin;

            do {
                Console.Write("Введите четырёхзначный Пароль: ");
                 pin = Console.ReadLine();

            } while (pin.Length != 4);

            atmFacade.EnterPin(pin);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== МЕНЮ ===");
                Console.WriteLine("1. Внести наличные");
                Console.WriteLine("2. Снять наличные");
                Console.WriteLine("3. Узнать баланс");
                Console.WriteLine("4. Выйти");
                Console.Write("Выберите действие (1-4): ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Введите сумму взноса: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        atmFacade.DepositCash(depositAmount);
                        break;
                    case "2":
                        Console.Write("Введите сумму для снятия: ");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        atmFacade.WithdrawCash(withdrawAmount);
                        break;
                    case "3":
                        atmFacade.CheckBalance();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверная операция. Повторите попытку.");
                        break;
                }
            }
        }
    }

}
