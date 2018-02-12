namespace OOP.Interfaces
{
    using System;

    public interface IPersonModel : IRecord
    {
        Guid Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string Gender { get; set; }
    }
}
