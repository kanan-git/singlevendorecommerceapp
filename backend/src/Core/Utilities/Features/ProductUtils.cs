namespace Core.Utilities.Features;

public static class ProductUtils
{
    public static decimal FindDiscountedPrice(decimal price, int discount)
    {
        return discount != 0 ? price - (price * discount / 100) : price;
    }

    public static double FindRating(long count, long sum)
    {
        return count != 0 ? Math.Round((double)sum/count*10)/10 : 0;
    }
}
