using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi_core_rm.Models
{
    public class employee_manager 
    {
        public employee_manager()
        {
        }

        public employee_manager(string Id, long? intv_no, string f_name, string m_name, string l_name, string qualification, string school, string adr1, string adr2, string adr3, string st_no, string st_name, string city, string state, string pin, string employment_type, DateTime? interview_date, string online_diary_no, string dispatch_no, DateTime? join_date, DateTime? dated, string gen_applied_post, string gen_basic_pay, string gen_pay_scale_level, string gen_payscale, string adhoc_net_salary, string adhoc_tenure, DateTime? adhoc_from_date, DateTime? adhoc_to_date)
        {
            this.Id = Id;
            this.intv_no = intv_no;
            this.f_name = f_name;
            this.m_name = m_name;
            this.l_name = l_name;
            this.qualification = qualification;
            this.school = school;
            this.adr1 = adr1;
            this.adr2 = adr2;
            this.adr3 = adr3;
            this.st_no = st_no;
            this.st_name = st_name;
            this.city = city;
            this.state = state;
            this.pin = pin;
            this.employment_type = employment_type;
            this.interview_date = interview_date;
            this.online_diary_no = online_diary_no;
            this.dispatch_no = dispatch_no;
            this.join_date = join_date;
            this.dated = dated;
            this.gen_applied_post = gen_applied_post;
            this.gen_basic_pay = gen_basic_pay;
            this.gen_pay_scale_level = gen_pay_scale_level;
            this.gen_payscale = gen_payscale;
            this.adhoc_net_salary = adhoc_net_salary;
            this.adhoc_tenure = adhoc_tenure;
            this.adhoc_from_date = adhoc_from_date;
            this.adhoc_to_date = adhoc_to_date;
        }

        public string Id { get; set; }
        public long? intv_no { get; set; }
        public string f_name { get; set; }
        public string m_name { get; set; }
        public string l_name { get; set; }
        public string qualification { get; set; }
        public string school { get; set; }
        public string adr1 { get; set; }
        public string adr2 { get; set; }
        public string adr3 { get; set; }
        public string st_no { get; set; }
        public string st_name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string pin { get; set; }
        public string employment_type { get; set; }
        public DateTime? interview_date { get; set; }
        public string online_diary_no { get; set; }
        public string dispatch_no { get; set; }
        public DateTime? join_date { get; set; }
        public DateTime? dated { get; set; }
        public string gen_applied_post { get; set; }
        public string gen_basic_pay { get; set; }
        public string gen_pay_scale_level { get; set; }
        public string gen_payscale { get; set; }
        public string adhoc_net_salary { get; set; }
        public string adhoc_tenure { get; set; }
        public DateTime? adhoc_from_date { get; set; }
        public DateTime? adhoc_to_date { get; set; }
    }
}