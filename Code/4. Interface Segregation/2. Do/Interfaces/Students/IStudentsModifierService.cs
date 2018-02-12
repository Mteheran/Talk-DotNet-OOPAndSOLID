using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IStudentsModifierService //: IStudentsReadService
    {
        void Create(string value);
        void Update(int id, string value);
        void Delete(int id);
    }
}
