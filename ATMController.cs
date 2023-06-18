using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    public class ATMController
    {
        private static ATMController instance;
        private ATM atm;

        private ATMController()
        {
            atm = new ATM();
        }

        public static ATMController GetInstance()
        {
            if (instance == null)
            {
                instance = new ATMController();
            }
            return instance;
        }

        public void InsertCard()
        {
            atm.InsertCard();
        }

        public void EnterPin(string pin)
        {
            atm.EnterPin(pin);
        }

        public void WithdrawCash(double amount)
        {
            atm.WithdrawCash(amount);
        }

        public void DepositCash(double amount)
        {
            atm.DepositCash(amount);
        }

        public void CheckBalance()
        {
            atm.CheckBalance();
        }
    }
}
