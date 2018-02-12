namespace OOP
{
    using System;
    using Interfaces;
    using SqlServer;

    using OOP.Models;
    
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Access data test");
            IPersonModel person = new PersonModel { FirstName = "Jhon", LastName = "Smith", Gender = "M" };
            IAnimalModel animal = new AnimalModel { Name = "Milu", Species = "Cat", Race = "Any" };

            IDataAccess<IPersonModel> personData = new DataAccessSqlServer<IPersonModel>();
            personData.Create(person);

            IDataAccess<IAnimalModel> animalData = new DataAccessSqlServer<IAnimalModel>();
            animalData.Create(animal);

            //IDataAccess<Utilities> utilitiesData = new DataAccessSqlServer<Utilities>();

            /*var tmp = new NullableStruct<bool>();
            Console.WriteLine($"Ha value ? {tmp.HasValue}");
            Console.WriteLine($"Value: {tmp.GetValueOrDefault()}");*/

            Console.ReadLine();
        }
    }
}
