using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    public class ATM
    {
        private IATMState currentState;
        private IATMState cardInsertedState;
        private IATMState pinEnteredState;
        private double balance;

        public ATM()
        {
            cardInsertedState = new CardInsertedState(this);
            pinEnteredState = new PinEnteredState(this);
            currentState = cardInsertedState;
            balance = 0;
        }

        public void SetState(IATMState state)
        {
            currentState = state;
        }

        public void InsertCard()
        {
            currentState.InsertCard();
        }

        public void EnterPin(string pin)
        {
            currentState.EnterPin(pin);
        }

        public void WithdrawCash(double amount)
        {
            currentState.WithdrawCash(amount);
        }

        public void DepositCash(double amount)
        {
            currentState.DepositCash(amount);
        }

        public void CheckBalance()
        {
            currentState.CheckBalance();
        }

        public void UpdateBalance(double amount)
        {
            balance += amount;
            Console.WriteLine("Теперь баланс: $" + balance);
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
