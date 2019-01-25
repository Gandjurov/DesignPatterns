using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedShoppingCartAfter.Contracts
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
