using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedShoppingCartAfter.Contracts
{
    public interface IPriceRule
    {
        bool IsMatch(OrderItem item);

        decimal CalculatePrice(OrderItem item);
    }
}
