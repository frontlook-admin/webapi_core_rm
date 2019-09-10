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

        public user_manager(string id, string f_name, string m_name, string l_name, string p_address, string l_address, string email, string phone, string password, string gauth)
        {
            this.id = id;
            this.f_name = f_name;
            this.m_name = m_name;
            this.l_name = l_name;
            this.p_address = p_address;
            this.l_address = l_address;
            this.email = email;
            this.phone = phone;
            this.password = gauth;
            this.gauth = password;
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
        public string password { get; set; }
        public string gauth { get; set; }
    }
}