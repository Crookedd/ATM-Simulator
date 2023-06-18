using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    public interface IATMState
    {
        void InsertCard();
        void EnterPin(string pin);
        void WithdrawCash(double amount);
        void DepositCash(double amount);
        void CheckBalance();
    }
}
