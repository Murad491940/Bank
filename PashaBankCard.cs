using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCards
{
    class PashaBankCard : AccessBankCard
    {
        public string UserNameSurname;
        public long Password;
        public int CVC;
        public decimal Balance;

        public virtual void IncreaseBalance(decimal amount)
        {
            if (amount <= 0) return;

            Balance += amount * 11/1000;
        }

        public virtual void WithdrawAmount(decimal amount)
        {
            if (amount <= 0) return;
            if (amount > Balance) return;

            Balance -= amount * 6/1000;


        }

        public PashaBankCard (string usernamesurname, long password, int cvc, decimal balance) : base(usernamesurname, password, cvc, balance)
        {
            UserNameSurname = usernamesurname;
            Password = password;
            CVC = cvc;
            Balance = balance;



        }

    }

       
    
}
