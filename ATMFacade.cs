using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    public class ATMFacade
    {
        private ATMController controller;

        public ATMFacade()
        {
            controller = ATMController.GetInstance();
        }

        public void InsertCard()
        {
            controller.InsertCard();
        }

        public void EnterPin(string pin)
        {
            controller.EnterPin(pin);
        }

        public void WithdrawCash(double amount)
        {
            controller.WithdrawCash(amount);
        }

        public void DepositCash(double amount)
        {
            controller.DepositCash(amount);
        }

        public void CheckBalance()
        {
            controller.CheckBalance();
        }
    }
}
