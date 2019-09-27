using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_core_rm.Models;

namespace webapi_core_rm.Interfaces
{
    public interface userinterface
    {
        bool DoesItemExist(string id);
        IEnumerable<user> All { get; }
        user Find(string id);
        void Insert(user item);
        void Update(user item);
        void Delete(string id);
    }
}
