namespace SingleResponsibilityPrinciple.Contracts
{
    using System.Collections.Generic;

    public interface ITradeStorage
    {
        void Persist(IEnumerable<TradeRecord> trades);
    }
}