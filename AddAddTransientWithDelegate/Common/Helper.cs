using AddAddTransientWithDelegate.Service;

namespace AddAddTransientWithDelegate.Common
{
    public delegate IDiscount DiscountServiceResolver(string memberShipLevel);
}