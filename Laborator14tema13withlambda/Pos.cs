using Laborator14tema13withlambda.Bank;
using Laborator14tema13withlambda.Cards;
using Laborator14tema13withlambda.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator14tema13withlambda
{
    class Pos
    {

        public void Plateste(Card card, double sumaDePlata)
        {
            Connect();
            try
            {
                card.IntroduCard();
                BankSingleton.Instance.Plateste(card.Id, sumaDePlata);
                Console.WriteLine($" plata de {sumaDePlata} a fost efectuata cu succes");
            }
            finally
            {
                card.ExtrageCard();
                BankSingleton.Instance.Disconnect();
            }


        }

        private void Connect()
        {
            var connected = false;
            int incercari = 0;

            while (!connected && incercari < 2)
            {
                incercari++;
                try
                {
                    BankSingleton.Instance.Connect();
                    connected = true;
                }
                catch
                {

                }
                if (!connected)
                {

                    throw new CannotConnectToBankExeption();
                }
            }
        }
    }
}