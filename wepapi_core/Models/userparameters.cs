using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi_core_rm.Models
{
    public class userparameters
    {
        public string id = "@_id";
        public string f_name = "@_f_name";
        public string m_name = "@_m_name";
        public string l_name = "@_l_name";
        public string p_address = "@_p_address";
        public string l_address = "@_l_address";
        public string email = "@_email";
        public string phone = "@_phone";
        public string password = "@_password";
        public string gauth = "@_auth";

        public IEnumerable<userparameters> par = new List<userparameters>();
        
        


        /*public userparameters(string id, string f_name, string m_name, string l_name, string p_address, string l_address, string email, string phone)
        {
            this.id = id;
            this.f_name = f_name;
            this.m_name = m_name;
            this.l_name = l_name;
            this.p_address = p_address;
            this.l_address = l_address;
            this.email = email;
            this.phone = phone;
        }*/
    }
}