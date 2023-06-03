using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCards
{
    public abstract class AccessBankCard
    {
        public string UserNameSurname;
        public long Password;
        public int CVC;
        public decimal Balance;

        public virtual void IncreaseBalance(decimal amount)
        {
            if (amount <= 0) return;

            Balance += amount * 3/1000 ;
        }

        public virtual void WithdrawAmount(decimal amount)
        {
            if (amount <= 0) return;
            if (amount > Balance) return;

            Balance -= amount * 16/1000;


        }


        public AccessBankCard(string usernamesurname, long password, int cvc, decimal balance) 
        {
            UserNameSurname = usernamesurname;
            Password = password;
            CVC = cvc;
            Balance=balance;



        }
    }

       
    
}
