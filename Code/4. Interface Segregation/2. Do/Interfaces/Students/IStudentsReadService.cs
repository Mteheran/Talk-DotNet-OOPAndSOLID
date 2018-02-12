using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IStudentsReadService
    {
        IEnumerable<string> Retrieve();
        string Retrieve(int id);
    }
}
