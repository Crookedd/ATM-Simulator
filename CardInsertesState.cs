using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    public class CardInsertedState : IATMState
    {
        private ATM atm;
        private PinEnteredState pinEnteredState;

        public CardInsertedState(ATM atm)
        {
            this.atm = atm;
            pinEnteredState = new PinEnteredState(atm);
        }

        public void InsertCard()
        {
            Console.WriteLine("Карта уже вставлена.");
        }

        public void EnterPin(string pin)
        {
            Console.WriteLine("Введённый Пароль: " + pin);
            atm.SetState(pinEnteredState);
        }

        public void WithdrawCash(double amount)
        {
            Console.WriteLine("Пожалуйста, сначала введите Пароль.");
        }

        public void DepositCash(double amount)
        {
            Console.WriteLine("Пожалуйста, сначала введите Пароль.");
        }

        public void CheckBalance()
        {
            Console.WriteLine("Пожалуйста, сначала введите Пароль.");
        }
    }
}
