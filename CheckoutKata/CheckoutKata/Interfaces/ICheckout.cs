﻿namespace CheckoutKata
{ 
    public interface ICheckout
    {
        void Scan(string sku);
        int GetTotal();
    }
}
