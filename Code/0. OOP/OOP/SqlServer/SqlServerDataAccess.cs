namespace OOP.SqlServer
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class DataAccessSqlServer <T> : IDataAccess<T> where T : IRecord
    {
        public object LoginDB()
        {
            object objectWithDBConnection = null;
            Console.WriteLine($"Connected to SQL Server");
            return objectWithDBConnection;
        }

        public T Create(T modelo)
        {
            LoginDB();
            Console.WriteLine($"Create {typeof(T)}: SQL Server");
            return modelo;
        }

        public void Edit(T modelo)
        {
            LoginDB();
            Console.WriteLine($"Edit {typeof(T)}: SQL Server");
        }

        public void Delete(T modelo)
        {
            LoginDB();
            Console.WriteLine($"Delete {typeof(T)}: SQL Server");
        }

        public ICollection<T> RetrieveAll()
        {
            LoginDB();
            Console.WriteLine($"Retrieve All {typeof(T)}: SQL Server");
            var list = new List<T>();
            return list;
        }

        public ICollection<T> RetrieveOne<TKey>(TKey key)
        {
            LoginDB();
            Console.WriteLine($"Retrieve One {typeof(T)} with key {typeof(TKey)} {key}: SQL Server");
            var list = new List<T>();
            return list;
        }
    }
}
