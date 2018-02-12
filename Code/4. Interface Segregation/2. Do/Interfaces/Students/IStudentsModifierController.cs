using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IStudentsModifierController //: IStudentsReadController
    {
        IStudentsModifierService StudentsModifierService { get; }

        void PostStudent(string value);
        void PutStudent(int id, string value);
        void DeleteStudent(int id);
    }
}
