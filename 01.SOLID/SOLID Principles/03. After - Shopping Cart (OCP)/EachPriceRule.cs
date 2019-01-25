using OpenClosedShoppingCartAfter.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedShoppingCartAfter
{
    public class EachPriceRule : IPriceRule
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("EACH");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * 5m;
        }
    }
}
