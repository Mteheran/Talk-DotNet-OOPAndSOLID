using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IStudentsService
    {
        IEnumerable<string> Retrieve();
        string Retrieve(int id);
        void Create(string value);
        void Update(int id, string value);
        void Delete(int id);
    }
}
