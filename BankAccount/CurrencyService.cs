namespace BankAccount
{
    using System;
    using System.Collections.Generic;

    public class CurrencyService : ICurrencyService
    {
        private IDictionary<string, double> CurrencyRates = new Dictionary<string, double>();

        public void AddCurrencyRate(string fromCurrency, string toCurrency, double rate)
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, double> GetCurrencyRates()
        {
            throw new NotImplementedException();
        }
    }
}
