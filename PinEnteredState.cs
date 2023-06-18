using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    public class PinEnteredState : IATMState
    {
        private ATM atm;

        public PinEnteredState(ATM atm)
        {
            this.atm = atm;
        }

        public void InsertCard()
        {
            Console.WriteLine("Карта уже вставлена.");
        }

        public void EnterPin(string pin)
        {
            Console.WriteLine("Пароль уже введён.");
        }

        public void WithdrawCash(double amount)
        {
            if (atm.GetBalance() >= amount)
            {
                Console.WriteLine("Выдано $" + amount);
                atm.UpdateBalance(-amount);
            }
            else
            {
                Console.WriteLine("Недостаточно средств.");
            }
        }

        public void DepositCash(double amount)
        {
            Console.WriteLine("Внесено $" + amount);
            atm.UpdateBalance(amount);
        }

        public void CheckBalance()
        {
            Console.WriteLine("Текущий баланс: $" + atm.GetBalance());
        }
    }
}
