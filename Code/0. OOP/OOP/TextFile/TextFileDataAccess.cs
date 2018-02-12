namespace OOP.SqlServer
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class DataAccessArchivoTexto<T> : IDataAccess<T> where T : IRecord
    {
        public T Create(T modelo)
        {
            Console.WriteLine($"Create {nameof(T)}: Archivo Texto");
            return modelo;
        }

        public void Edit(T modelo)
        {
            Console.WriteLine($"Edit {nameof(T)}: Archivo Texto");
        }

        public void Delete(T modelo)
        {
            Console.WriteLine($"Delete {nameof(T)}: Archivo Texto");
        }

        public ICollection<T> RetrieveAll()
        {
            Console.WriteLine($"Retrieve All {nameof(T)}: Archivo Texto");
            var list = new List<T>();
            return list;
        }

        public ICollection<T> RetrieveOne<TKey>(TKey key)
        {
            Console.WriteLine($"Retrieve One {typeof(T)} with key {typeof(TKey)} {key}: SQL Server");
            var list = new List<T>();
            return list;
        }
    }
}
