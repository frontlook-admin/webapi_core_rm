//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webapi_core_rm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public user()
        {
        }

        public user(string id, string f_name, string m_name, string l_name, string p_address, string l_address, string email, string phone, string password, string gauth)
        {
            this.id = id;
            this.f_name = f_name;
            this.m_name = m_name;
            this.l_name = l_name;
            this.p_address = p_address;
            this.l_address = l_address;
            this.email = email;
            this.phone = phone;
            this.password = password;
            this.gauth = gauth;
        }

        public user(string id)
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
