using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_core_rm.Interfaces;
using webapi_core_rm.Models;

namespace webapi_core_rm.services
{
    public class userservices: Interfaces.userinterface
    {
        private List<user> _user;

        public userservices()
        {
            
        }

        public bool DoesItemExist(string id)
        {
            return _user.Any(item => item.gauth == id);
        }

        public IEnumerable<user> All { get { return _user; } }
        public user Find(string id)
        {
            return _user.FirstOrDefault(item => item.id == id || item.gauth==id);
        }

        public void Insert(user item)
        {
            _user.Add(item);
        }

        public void Update(user item)
        {
            var todoItem = this.Find(item.id);
            var index = _user.IndexOf(todoItem);
            _user.RemoveAt(index);
            _user.Insert(index, item);
        }

        public void Delete(string id)
        {
            _user.Remove(this.Find(id));
        }
    }
}
