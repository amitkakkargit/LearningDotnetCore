namespace AddAddTransientWithDelegate.Service
{
    public class GoldMember: IDiscount
    {
        public string GetDiscount()
        {
            return "20% Discount available!!!";
        }
    }
}