namespace BankAccount
{
    using System.Collections.Generic;

    public interface ICurrencyService
    {
        void AddCurrencyRate(string fromCurrency, string toCurrency, double rate);

        IDictionary<string, double> GetCurrencyRates();
    }
}
