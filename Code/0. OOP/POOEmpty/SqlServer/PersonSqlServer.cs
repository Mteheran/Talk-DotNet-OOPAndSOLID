using System;
using System.Collections.Generic;
using POOEmpty.Models;

namespace POOEmpty.SqlServer
{
    public class PersonSqlServer
    {

        public object LoginDB()
        {
            object objectWithDBConnection = null;
            Console.WriteLine($"Connected to SQL Server");
            return objectWithDBConnection;
        }

        public PersonModel Create(PersonModel modelo)
        {
            LoginDB();
            Console.WriteLine($"Create {typeof(PersonModel)}: SQL Server");
            return modelo;
        }

        public void Edit(PersonModel modelo)
        {
            LoginDB();
            Console.WriteLine($"Edit {typeof(PersonModel)}: SQL Server");
        }

        public void Delete(PersonModel modelo)
        {
            LoginDB();
            Console.WriteLine($"Delete {typeof(PersonModel)}: SQL Server");
        }

        public ICollection<PersonModel> RetrieveAll()
        {
            LoginDB();
            Console.WriteLine($"Retrieve All {typeof(PersonModel)}: SQL Server");
            var list = new List<PersonModel>();
            return list;
        }

        public ICollection<PersonModel> RetrieveOne(string key)
        {
            LoginDB();
            Console.WriteLine($"Retrieve One {typeof(PersonModel)} with key {typeof(string)} {key}: SQL Server");
            var list = new List<PersonModel>();
            return list;
        }
    }
}
