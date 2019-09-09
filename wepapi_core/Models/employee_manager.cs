using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentMasterApi.Models
{
    public class employee_manager : IEquatable<employee_manager>
    {
        public IEnumerable<employee_manager> Employees { get; set; }
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (p_Id != null ? p_Id.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ p_intv_no.GetHashCode();
                hashCode = (hashCode * 397) ^ (p_f_name != null ? p_f_name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_m_name != null ? p_m_name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_l_name != null ? p_l_name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_qualification != null ? p_qualification.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_school != null ? p_school.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_adr1 != null ? p_adr1.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_adr2 != null ? p_adr2.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_adr3 != null ? p_adr3.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_st_no != null ? p_st_no.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_st_name != null ? p_st_name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_city != null ? p_city.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_state != null ? p_state.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_pin != null ? p_pin.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_employment_type != null ? p_employment_type.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ p_interview_date.GetHashCode();
                hashCode = (hashCode * 397) ^ (p_online_diary_no != null ? p_online_diary_no.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_dispatch_no != null ? p_dispatch_no.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ p_join_date.GetHashCode();
                hashCode = (hashCode * 397) ^ p_dated.GetHashCode();
                hashCode = (hashCode * 397) ^ (p_gen_applied_post != null ? p_gen_applied_post.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_gen_basic_pay != null ? p_gen_basic_pay.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_gen_pay_scale_level != null ? p_gen_pay_scale_level.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_gen_payscale != null ? p_gen_payscale.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_addhoc_net_salary != null ? p_addhoc_net_salary.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (p_addhoc_tenure != null ? p_addhoc_tenure.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ p_addhoc_from_date.GetHashCode();
                hashCode = (hashCode * 397) ^ p_addhoc_to_date.GetHashCode();
                return hashCode;
            }
        }

        public employee_manager()
        {
        }

        public employee_manager(string p_Id, long? p_intv_no, string p_f_name, string p_m_name, string p_l_name, string p_qualification, string p_school, string p_adr1, string p_adr2, string p_adr3, string p_st_no, string p_st_name, string p_city, string p_state, string p_pin, string p_employment_type, DateTime? p_interview_date, string p_online_diary_no, string p_dispatch_no, DateTime? p_join_date, DateTime? p_dated, string p_gen_applied_post, string p_gen_basic_pay, string p_gen_pay_scale_level, string p_gen_payscale, string p_addhoc_net_salary, string p_addhoc_tenure, DateTime? p_addhoc_from_date, DateTime? p_addhoc_to_date)
        {
            this.p_Id = p_Id;
            this.p_intv_no = p_intv_no;
            this.p_f_name = p_f_name;
            this.p_m_name = p_m_name;
            this.p_l_name = p_l_name;
            this.p_qualification = p_qualification;
            this.p_school = p_school;
            this.p_adr1 = p_adr1;
            this.p_adr2 = p_adr2;
            this.p_adr3 = p_adr3;
            this.p_st_no = p_st_no;
            this.p_st_name = p_st_name;
            this.p_city = p_city;
            this.p_state = p_state;
            this.p_pin = p_pin;
            this.p_employment_type = p_employment_type;
            this.p_interview_date = p_interview_date;
            this.p_online_diary_no = p_online_diary_no;
            this.p_dispatch_no = p_dispatch_no;
            this.p_join_date = p_join_date;
            this.p_dated = p_dated;
            this.p_gen_applied_post = p_gen_applied_post;
            this.p_gen_basic_pay = p_gen_basic_pay;
            this.p_gen_pay_scale_level = p_gen_pay_scale_level;
            this.p_gen_payscale = p_gen_payscale;
            this.p_addhoc_net_salary = p_addhoc_net_salary;
            this.p_addhoc_tenure = p_addhoc_tenure;
            this.p_addhoc_from_date = p_addhoc_from_date;
            this.p_addhoc_to_date = p_addhoc_to_date;
        }

        public string p_Id { get; set; }
        public long? p_intv_no { get; set; }
        public string p_f_name { get; set; }
        public string p_m_name { get; set; }
        public string p_l_name { get; set; }
        public string p_qualification { get; set; }
        public string p_school { get; set; }
        public string p_adr1 { get; set; }
        public string p_adr2 { get; set; }
        public string p_adr3 { get; set; }
        public string p_st_no { get; set; }
        public string p_st_name { get; set; }
        public string p_city { get; set; }
        public string p_state { get; set; }
        public string p_pin { get; set; }
        public string p_employment_type { get; set; }
        public DateTime? p_interview_date { get; set; }
        public string p_online_diary_no { get; set; }
        public string p_dispatch_no { get; set; }
        public DateTime? p_join_date { get; set; }
        public DateTime? p_dated { get; set; }
        public string p_gen_applied_post { get; set; }
        public string p_gen_basic_pay { get; set; }
        public string p_gen_pay_scale_level { get; set; }
        public string p_gen_payscale { get; set; }
        public string p_addhoc_net_salary { get; set; }
        public string p_addhoc_tenure { get; set; }
        public DateTime? p_addhoc_from_date { get; set; }
        public DateTime? p_addhoc_to_date { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as employee_manager);
        }

        public bool Equals(employee_manager other)
        {
            return other != null &&
                   p_Id == other.p_Id &&
                   EqualityComparer<long?>.Default.Equals(p_intv_no, other.p_intv_no) &&
                   p_f_name == other.p_f_name &&
                   p_m_name == other.p_m_name &&
                   p_l_name == other.p_l_name &&
                   p_qualification == other.p_qualification &&
                   p_school == other.p_school &&
                   p_adr1 == other.p_adr1 &&
                   p_adr2 == other.p_adr2 &&
                   p_adr3 == other.p_adr3 &&
                   p_st_no == other.p_st_no &&
                   p_st_name == other.p_st_name &&
                   p_city == other.p_city &&
                   p_state == other.p_state &&
                   p_pin == other.p_pin &&
                   p_employment_type == other.p_employment_type &&
                   EqualityComparer<DateTime?>.Default.Equals(p_interview_date, other.p_interview_date) &&
                   p_online_diary_no == other.p_online_diary_no &&
                   p_dispatch_no == other.p_dispatch_no &&
                   EqualityComparer<DateTime?>.Default.Equals(p_join_date, other.p_join_date) &&
                   EqualityComparer<DateTime?>.Default.Equals(p_dated, other.p_dated) &&
                   p_gen_applied_post == other.p_gen_applied_post &&
                   p_gen_basic_pay == other.p_gen_basic_pay &&
                   p_gen_pay_scale_level == other.p_gen_pay_scale_level &&
                   p_gen_payscale == other.p_gen_payscale &&
                   p_addhoc_net_salary == other.p_addhoc_net_salary &&
                   p_addhoc_tenure == other.p_addhoc_tenure &&
                   EqualityComparer<DateTime?>.Default.Equals(p_addhoc_from_date, other.p_addhoc_from_date) &&
                   EqualityComparer<DateTime?>.Default.Equals(p_addhoc_to_date, other.p_addhoc_to_date);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(employee_manager manager1, employee_manager manager2)
        {
            return EqualityComparer<employee_manager>.Default.Equals(manager1, manager2);
        }

        public static bool operator !=(employee_manager manager1, employee_manager manager2)
        {
            return !(manager1 == manager2);
        }
    }
}