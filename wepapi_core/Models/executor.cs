using System;
using System.Configuration;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using MySql.Data.Types;
using MySql.Data.common;

namespace webapi_core_rm.Models
{
    public class executor
    {
        static string cs = System.Configuration.ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        static MySqlConnection con = new MySqlConnection(cs);
        MySqlCommand cmd = new MySqlCommand("", con);

        private readonly employmentEntities _context;

        private bool userExists(string id)
        {
            return _context.user.Any(e => e.id == id);
        }

        public bool validateUser(string _userid, string _password)
        {
            
            cmd.CommandText = "select validate_user ('"+_userid+"','"+_password+"')";
            //cmd.Parameters.AddWithValue(u.id, userid);
            cmd.CommandType = CommandType.StoredProcedure;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            int r = cmd.ExecuteNonQuery();
            if (r.Equals(1))
            {
                return true;
            }
            return false;
        }

        public int PostUser(user_manager _u)
        {
            userparameters u = new userparameters();
            cmd.CommandText = "user_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(u.id, _u.id);
            cmd.Parameters.AddWithValue(u.email, _u.email);
            cmd.Parameters.AddWithValue(u.f_name, _u.f_name);
            cmd.Parameters.AddWithValue(u.l_address, _u.l_address);
            cmd.Parameters.AddWithValue(u.l_name, _u.l_name);
            cmd.Parameters.AddWithValue(u.m_name, _u.m_name);
            cmd.Parameters.AddWithValue(u.p_address, _u.p_address);
            cmd.Parameters.AddWithValue(u.phone, _u.phone);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }

        public int PutUser(user_manager _u, string _id)
        {
            userparameters u = new userparameters();
            cmd.CommandText = "user_update";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(u.id, _id);
            cmd.Parameters.AddWithValue(u.email, _u.email);
            cmd.Parameters.AddWithValue(u.f_name, _u.f_name);
            cmd.Parameters.AddWithValue(u.l_address, _u.l_address);
            cmd.Parameters.AddWithValue(u.l_name, _u.l_name);
            cmd.Parameters.AddWithValue(u.m_name, _u.m_name);
            cmd.Parameters.AddWithValue(u.p_address, _u.p_address);
            cmd.Parameters.AddWithValue(u.phone, _u.phone);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }

        public int DeleteUser(string id)
        {
            userparameters u = new userparameters();
            cmd.CommandText = "user_delete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(u.id, id);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }

        public int PostEmployee(employee_manager _e)
        {
            employeeParameters e = new employeeParameters();
            cmd.CommandText = "employee_recruit_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(e.Id, _e.Id);
            cmd.Parameters.AddWithValue(e.f_name, _e.f_name);
            cmd.Parameters.AddWithValue(e.m_name, _e.m_name);
            cmd.Parameters.AddWithValue(e.l_name, _e.l_name);
            cmd.Parameters.AddWithValue(e.qualification, _e.qualification);
            cmd.Parameters.AddWithValue(e.school, _e.school);
            cmd.Parameters.AddWithValue(e.intv_no, _e.intv_no);
            cmd.Parameters.AddWithValue(e.adr1, _e.adr1);
            cmd.Parameters.AddWithValue(e.adr2, _e.adr2);
            cmd.Parameters.AddWithValue(e.adr3, _e.adr3);
            cmd.Parameters.AddWithValue(e.st_no, _e.st_no);
            cmd.Parameters.AddWithValue(e.st_name, _e.st_name);
            cmd.Parameters.AddWithValue(e.city, _e.city);
            cmd.Parameters.AddWithValue(e.state, _e.state);
            cmd.Parameters.AddWithValue(e.pin, _e.pin);
            cmd.Parameters.AddWithValue(e.employment_type, _e.employment_type);
            cmd.Parameters.AddWithValue(e.interview_date, _e.interview_date);
            cmd.Parameters.AddWithValue(e.online_diary_no, _e.online_diary_no);
            cmd.Parameters.AddWithValue(e.dispatch_no, _e.dispatch_no);
            cmd.Parameters.AddWithValue(e.join_date, _e.join_date);
            cmd.Parameters.AddWithValue(e.dated, _e.dated);
            cmd.Parameters.AddWithValue(e.gen_applied_post, _e.gen_applied_post);
            cmd.Parameters.AddWithValue(e.gen_basic_pay, _e.gen_basic_pay);
            cmd.Parameters.AddWithValue(e.gen_pay_scale_level, _e.gen_pay_scale_level);
            cmd.Parameters.AddWithValue(e.gen_payscale, _e.gen_payscale);
            cmd.Parameters.AddWithValue(e.adhoc_net_salary, _e.adhoc_net_salary);
            cmd.Parameters.AddWithValue(e.adhoc_tenure, _e.adhoc_tenure);
            cmd.Parameters.AddWithValue(e.adhoc_from_date, _e.adhoc_from_date);
            cmd.Parameters.AddWithValue(e.adhoc_to_date, _e.adhoc_to_date);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }

        public int PutEmployee(employee_manager _e, string _id)
        {
            employeeParameters e = new employeeParameters();
            cmd.CommandText = "employee_recruit_update";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(e.Id, _id);
            cmd.Parameters.AddWithValue(e.f_name, _e.f_name);
            cmd.Parameters.AddWithValue(e.m_name, _e.m_name);
            cmd.Parameters.AddWithValue(e.l_name, _e.l_name);
            cmd.Parameters.AddWithValue(e.qualification, _e.qualification);
            cmd.Parameters.AddWithValue(e.school, _e.school);
            cmd.Parameters.AddWithValue(e.intv_no, _e.intv_no);
            cmd.Parameters.AddWithValue(e.adr1, _e.adr1);
            cmd.Parameters.AddWithValue(e.adr2, _e.adr2);
            cmd.Parameters.AddWithValue(e.adr3, _e.adr3);
            cmd.Parameters.AddWithValue(e.st_no, _e.st_no);
            cmd.Parameters.AddWithValue(e.st_name, _e.st_name);
            cmd.Parameters.AddWithValue(e.city, _e.city);
            cmd.Parameters.AddWithValue(e.state, _e.state);
            cmd.Parameters.AddWithValue(e.pin, _e.pin);
            cmd.Parameters.AddWithValue(e.employment_type, _e.employment_type);
            cmd.Parameters.AddWithValue(e.interview_date, _e.interview_date);
            cmd.Parameters.AddWithValue(e.online_diary_no, _e.online_diary_no);
            cmd.Parameters.AddWithValue(e.dispatch_no, _e.dispatch_no);
            cmd.Parameters.AddWithValue(e.join_date, _e.join_date);
            cmd.Parameters.AddWithValue(e.dated, _e.dated);
            cmd.Parameters.AddWithValue(e.gen_applied_post, _e.gen_applied_post);
            cmd.Parameters.AddWithValue(e.gen_basic_pay, _e.gen_basic_pay);
            cmd.Parameters.AddWithValue(e.gen_pay_scale_level, _e.gen_pay_scale_level);
            cmd.Parameters.AddWithValue(e.gen_payscale, _e.gen_payscale);
            cmd.Parameters.AddWithValue(e.adhoc_net_salary, _e.adhoc_net_salary);
            cmd.Parameters.AddWithValue(e.adhoc_tenure, _e.adhoc_tenure);
            cmd.Parameters.AddWithValue(e.adhoc_from_date, _e.adhoc_from_date);
            cmd.Parameters.AddWithValue(e.adhoc_to_date, _e.adhoc_to_date);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }

        public int DeleteEmployee(string id)
        {
            employeeParameters e = new employeeParameters();
            cmd.CommandText = "employee_recruit_delete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(e.Id, id);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }
    }
}