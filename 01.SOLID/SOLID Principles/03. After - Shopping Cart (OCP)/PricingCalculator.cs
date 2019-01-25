using OpenClosedShoppingCartAfter.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosedShoppingCartAfter
{
    public class PricingCalculator : IPricingCalculator
    {
        private readonly List<IPriceRule> pricingRules;

        public PricingCalculator()
        {
            this.pricingRules = new List<IPriceRule>
                                    {
                                        new EachPriceRule(),
                                        new PerGramPriceRule(),
                                        new SpecialPriceRule(),
                                        new Buy4GetOneFree()
                                    };
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return this.pricingRules.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}
