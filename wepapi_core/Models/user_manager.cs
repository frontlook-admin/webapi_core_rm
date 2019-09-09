using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wepapi_core.Models
{
    public class user_manager
    {
        public user_manager()
        {
        }

        public user_manager(string id, string f_name, string m_name, string l_name, string p_address, string l_address, string email, string phone)
        {
            this.id = id;
            this.f_name = f_name;
            this.m_name = m_name;
            this.l_name = l_name;
            this.p_address = p_address;
            this.l_address = l_address;
            this.email = email;
            this.phone = phone;
        }

        public user_manager(string id)
        {
            this.id = id;
        }

        public string id { get; set; }
        public string f_name { get; set; }
        public string m_name { get; set; }
        public string l_name { get; set; }
        public string p_address { get; set; }
        public string l_address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as user_manager);
        }

        public bool Equals(user_manager other)
        {
            return other != null &&
                   id == other.id &&
                   f_name == other.f_name &&
                   m_name == other.m_name &&
                   l_name == other.l_name &&
                   p_address == other.p_address &&
                   l_address == other.l_address &&
                   email == other.email &&
                   phone == other.phone;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(user_manager manager1, user_manager manager2)
        {
            return EqualityComparer<user_manager>.Default.Equals(manager1, manager2);
        }

        public static bool operator !=(user_manager manager1, user_manager manager2)
        {
            return !(manager1 == manager2);
        }
    }
}