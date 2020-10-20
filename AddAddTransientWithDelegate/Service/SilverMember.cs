namespace AddAddTransientWithDelegate.Service
{
    public class SilverMember: IDiscount
    {
        public string GetDiscount()
        {
            return "10% Discount available!!!";
        }
    }
}