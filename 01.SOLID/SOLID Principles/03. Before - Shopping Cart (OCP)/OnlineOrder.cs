using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedShoppingCartBefore
{
    public class OnlineOrder : Order
    {
        public OnlineOrder(Cart cart)
            : base(cart)
        {
        }
    }
}
