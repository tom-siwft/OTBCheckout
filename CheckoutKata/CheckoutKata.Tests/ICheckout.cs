namespace CheckoutKata.Tests
{
    public interface ICheckout
    {
        void Scan(string sku);
        int GetTotal();
    }
}
