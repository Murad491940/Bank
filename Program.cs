namespace BankCards
{
    public class Program
    {
        static void Main(string[] args)
        {
            AccessBankCard accessbank = new LeoBankCard("Murad Azizzade", 123456789, 101, 500);
            var leobank = new LeoBankCard("Murad Azizzade", 987654321, 110, 400);
            var pashabank = new PashaBankCard("Murad Azizzade", 1212121212, 121, 300);
            var unibank = new UnibankCard("Murad Azizzade", 2121212121, 112, 200);


            Console.WriteLine(accessbank.UserNameSurname);
            Console.WriteLine(accessbank.Password);
            Console.WriteLine(accessbank.CVC);
            Console.WriteLine(accessbank.Balance);
            accessbank.IncreaseBalance(100);
            accessbank.WithdrawAmount(50);
            Console.WriteLine(accessbank.Balance);

            Console.WriteLine(leobank.UserNameSurname);
            Console.WriteLine(leobank.Password);
            Console.WriteLine(leobank.CVC);
            Console.WriteLine(leobank.Balance);
            leobank.IncreaseBalance(100);
            leobank.WithdrawAmount(50);
            Console.WriteLine(leobank.Balance);

            Console.WriteLine(pashabank.UserNameSurname);
            Console.WriteLine(pashabank.Password);
            Console.WriteLine(pashabank.CVC);
            Console.WriteLine(pashabank.Balance);
            pashabank.IncreaseBalance(100);
            pashabank.WithdrawAmount(50);
            Console.WriteLine(pashabank.Balance);

            Console.WriteLine(unibank.UserNameSurname);
            Console.WriteLine(unibank.Password);
            Console.WriteLine(unibank.CVC);
            Console.WriteLine(unibank.Balance);
            unibank.IncreaseBalance(100);
            unibank.WithdrawAmount(50);
            Console.WriteLine(unibank.Balance);

            ;

        }

    }
}