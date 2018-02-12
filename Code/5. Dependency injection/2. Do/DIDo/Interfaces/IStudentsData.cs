using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDo.Interfaces
{
    public interface IStudentsData
    {
        IEnumerable<string> Retrieve();

        string Retrieve(int id);

        void Create(string value);

        void Update(int id, string value);

        void Delete(int id);
    }
}
