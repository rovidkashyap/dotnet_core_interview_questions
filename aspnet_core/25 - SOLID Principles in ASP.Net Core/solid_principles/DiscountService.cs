namespace solid_principles
{
    //Bad Example
    public class DiscountService_bad
    {
        public double ApplyDiscount(double price, string discountType)
        {
            if (discountType == "Percentage")
            {
                return price * 0.9;
            }
            else if (discountType == "Fixed")
            {
                return price - 10;
            }
            return price;
        }
    }

    // Good Example
    public abstract class Discount
    {
        public abstract double Apply(double price);
    }

    public class PercentageDiscount : Discount
    {
        public override double Apply(double price)
        {
            return price * 0.9;
        }
    }

    public class FixedDiscount : Discount
    {
        public override double Apply(double price)
        {
            return price - 10;
        }
    }

    public class DiscountService_good
    {
        private readonly Discount _discount;
        public DiscountService_good(Discount discount)
        {
            _discount = discount;
        }

        public double ApplyDiscount(double price)
        {
            return _discount.Apply(price);
        }
    }
}
