using Laborator14tema13withlambda.Cards;
using Laborator14tema13withlambda.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator14tema13withlambda.Bank
{
    class Cont
    {

        private readonly Guid id = Guid.NewGuid();
        private double sold = 0.0;
        public Guid Id { get => id; }
        public List<Card> cards = new List<Card>();
        
        public void AddCard(Card c)
        {
            if (this.cards.Count >=2 )
            {
                throw new TooManyCardsException();
            }
            this.cards.Add(c);
        }
        public void DepunereNumerar(double suma)
            => sold += suma;
        
        public double ExtrageNumerar(double suma)
        {
            if  (suma <= sold)
            {
                sold -= suma;
                return suma;
            }
            throw new InsuficientFundsException(); 
        }

        public bool  DetineCard(Guid cardId)
        {
            return cards.Exists(c => c.Id == cardId);
        }
    }
}
