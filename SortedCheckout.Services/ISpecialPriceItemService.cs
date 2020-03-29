using System.Collections.Generic;
using SortedCheckout.Domain;

namespace SortedCheckout.Services
{
    public interface ISpecialPriceItemService
    {
        List<SpecialPriceItem> GetAvailableSpecialPriceItems();
    }
}