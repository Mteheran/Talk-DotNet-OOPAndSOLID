using System;
using OOP.Interfaces;

namespace OOP.Models
{
    public class AnimalModel : IAnimalModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Species { get; set; }
    }
}
