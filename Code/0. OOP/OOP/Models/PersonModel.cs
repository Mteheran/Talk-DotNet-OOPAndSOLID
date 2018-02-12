using System;
using OOP.Interfaces;

namespace OOP.Models
{
    public class PersonModel : IPersonModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
    }
}
