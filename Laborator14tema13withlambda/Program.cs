using Laborator14tema13withlambda.Bank;
using System;

namespace Laborator14tema13withlambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cont1 = BankSingleton.Instance.CreeazaCont();
            var cont2 = BankSingleton.Instance.CreeazaCont();

            BankSingleton.Instance.DepuneNumerar(cont1, 10000);
            BankSingleton.Instance.DepuneNumerar(cont2, 20000);

            var card1 = BankSingleton.Instance.EmiteCard(cont1);
            var card2 = BankSingleton.Instance.EmiteCard(cont1);
            var card3 = BankSingleton.Instance.EmiteCard(cont2);

            Pos pos = new Pos();

            pos.Plateste(card1, 1000);


        }
    }
}
