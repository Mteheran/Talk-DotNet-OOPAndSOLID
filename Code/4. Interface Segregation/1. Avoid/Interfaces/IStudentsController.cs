using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IStudentsController
    {
        IStudentsService StudentsService { get; }

        IEnumerable<string> GetStudent();
        string GetStudent(int id);
        void PostStudent(string value);
        void PutStudent(int id, string value);
        void DeleteStudent(int id);
    }
}
