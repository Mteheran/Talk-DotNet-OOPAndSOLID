namespace OOP.Interfaces
{
    using System;

    public interface IAnimalModel : IRecord
    {
        Guid Id { get; set; }

        string Name { get; set; }

        string Race { get; set; }

        string Species { get; set; }
    }
}
