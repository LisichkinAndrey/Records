using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    public class DiscountCardsDAL
    {
        ApplicationContext db = new ApplicationContext();

        public void AddDiscountCard(DiscountCard card)
        {
            db.DiscountCards.Add(card);
        }

        public int GetLastNumber()
        {
            int? id = db.DiscountCards.Max(r => r.Number);
            if (id == null) { return 1; }
            else { return (int)id; }
        }

        public List<DiscountCard>? GetAllDiscountCards()
        {
            List<DiscountCard>? cards = db.DiscountCards.ToList();
            return cards;
        }

        public DiscountCard? GetDiscountCardByNumber(int cardNumber)
        {
            DiscountCard? card = (from r in db.DiscountCards where r.Number == cardNumber select r).FirstOrDefault();
            return card;
        }

        public List<DiscountCard>? GetDiscountCardsByName(string name)
        {
            List<DiscountCard>? cards = (from r in db.DiscountCards where r.Name.Contains(name) select r).ToList();
            return cards;
        }

        public void UpdateDiscountCardName(int cardNumber, string newName)
        {
            DiscountCard? card = (from r in db.DiscountCards where r.Number == cardNumber select r).FirstOrDefault();
            if (card != null)
            {
                card.Name = newName;
                db.SaveChanges();
            }
        }

        public void RemoveDiscountCard(int cardNumber)
        {
            DiscountCard? card = (from r in db.DiscountCards where r.Number == cardNumber select r).FirstOrDefault();
            if (card != null)
            {
                db.DiscountCards.Remove(card);
            }
        }
    }
}
