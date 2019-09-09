using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentMasterApi.Models
{
    public class user_manager : IEquatable<user_manager>
    {
        public IEnumerable<user_manager> users { get; set; }
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (p_id != null ? p_id.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_f_name != null ? p_f_name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_m_name != null ? p_m_name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_l_name != null ? p_l_name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_p_address != null ? p_p_address.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_l_address != null ? p_l_address.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_email != null ? p_email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_phone != null ? p_phone.GetHashCode() : 0);
                return hashCode;
            }
        }

        public user_manager()
        {
        }

        public user_manager(string p_id, string p_f_name, string p_m_name, string p_l_name, string p_p_address, string p_l_address, string p_email, string p_phone)
        {
            this.p_id = p_id;
            this.p_f_name = p_f_name;
            this.p_m_name = p_m_name;
            this.p_l_name = p_l_name;
            this.p_p_address = p_p_address;
            this.p_l_address = p_l_address;
            this.p_email = p_email;
            this.p_phone = p_phone;
        }

        public user_manager(string p_id)
        {
            this.p_id = p_id;
        }

        public string p_id { get; set; }
        public string p_f_name { get; set; }
        public string p_m_name { get; set; }
        public string p_l_name { get; set; }
        public string p_p_address { get; set; }
        public string p_l_address { get; set; }
        public string p_email { get; set; }
        public string p_phone { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as user_manager);
        }

        public bool Equals(user_manager other)
        {
            return other != null &&
                   p_id == other.p_id &&
                   p_f_name == other.p_f_name &&
                   p_m_name == other.p_m_name &&
                   p_l_name == other.p_l_name &&
                   p_p_address == other.p_p_address &&
                   p_l_address == other.p_l_address &&
                   p_email == other.p_email &&
                   p_phone == other.p_phone;
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