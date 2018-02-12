namespace SingleResponsibilityPrinciple.Contracts
{
    using System.Collections.Generic;

    public interface ITradeDataProvider
    {
        IEnumerable<string> GetTradeData();
    }
}