using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IStudentsReadController
    {
        IStudentsReadService StudentsReadService { get; }

        IEnumerable<string> GetStudent();
        string GetStudent(int id);
    }
}
