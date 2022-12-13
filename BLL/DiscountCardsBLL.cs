using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    [System.ComponentModel.DataObject]
    public class DiscountCardsBLL
    {
        private DiscountCardsDAL DAL = new DiscountCardsDAL();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddDiscountCard(string name, string cardNumber)
        {
            DAL.AddDiscountCard(new DiscountCard
            {
                Number = DAL.GetLastNumber() + 1,
                Name = name,
                ReleaseDate = DateTime.Now
            });
        }

        public List<DiscountCard>? GetAllDiscountCards()
        {
            return DAL.GetAllDiscountCards();
        }

        public DiscountCard? GetDiscountCardByNumber(int cardNumber)
        {
            return DAL.GetDiscountCardByNumber(cardNumber);
        }

        public List<DiscountCard>? GetDiscountCardsByName(string name)
        {
            return DAL.GetDiscountCardsByName(name);
        }

        public void UpdateDiscountCardName(int cardNumber, string newName)
        {
            DAL.UpdateDiscountCardName(cardNumber, newName);
        }

        public void RemoveDiscountCard(int cardNumber)
        {
            DAL.RemoveDiscountCard(cardNumber);
        }
    }
}
