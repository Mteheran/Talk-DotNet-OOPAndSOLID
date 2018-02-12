namespace OOP.Interfaces
{
    using System.Collections.Generic;

    public interface IDataAccess <T> where T : IRecord
    {
        T Create(T model);

        void Edit(T model);

        void Delete(T model);

        ICollection<T> RetrieveAll();

        ICollection<T> RetrieveOne<TKey>(TKey key);
    }
}

