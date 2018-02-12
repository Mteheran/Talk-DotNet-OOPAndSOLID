using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class UserRepository : EntityRepository
    {
        // This will not compile because the overridden
        // method cannot change the return type
        //public override User GetByID(Guid id)
        //{
        //    return new User();
        //}

        // This will not compile because subtypes cannot exhibit contravariance
        //public override void Save(User user)
        //{

        //}

    }
}
