using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using records;

#nullable enable

namespace records.Controllers
{
    [ApiController]
    [Route("discountcards")]
    [ApiExplorerSettings(GroupName = "discountcards")]
    public class DiscountCardsController : ControllerBase
    {

        DiscountCardsBLL BLL = new DiscountCardsBLL();

        [HttpPut]
        [Route("add")]
        public void AddDiscountCard(string name, string cardNumber)
        {
            BLL.AddDiscountCard(name, cardNumber);
        }

        [HttpGet]
        [Route("get_all")]
        public List<DiscountCard>? GetAllDiscountCards()
        {
            return BLL.GetAllDiscountCards();
        }

        [HttpGet]
        [Route("get_by_num")]
        public DiscountCard? GetDiscountCardByNumber(int cardNumber)
        {
            return BLL.GetDiscountCardByNumber(cardNumber);
        }

        [HttpGet]
        [Route("get_by_name")]
        public List<DiscountCard>? GetDiscountCardsByName(string name)
        {
            return BLL.GetDiscountCardsByName(name);
        }

        [HttpPatch]
        [Route("patch_name")]
        public void UpdateDiscountCardName(int cardNumber, string newName)
        {
            BLL.UpdateDiscountCardName(cardNumber, newName);
        }

        [HttpDelete]
        [Route("delete_by_num")]
        public void RemoveDiscountCard(int cardNumber)
        {
            BLL.RemoveDiscountCard(cardNumber);
        }

    }
}
