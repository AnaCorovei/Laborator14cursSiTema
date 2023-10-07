using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator14tema13withlambda.Cards
{
    class Card
    {

        private readonly Guid id;

        public Card ()
        {
            this.id = Guid.NewGuid();

        }
        public Guid Id { get => id; }


        public void IntroduCard()
            => Console.WriteLine("Am introdus cardul");

        public void ExtrageCard()
         => Console.WriteLine("Am extras cardul");


    }
}
