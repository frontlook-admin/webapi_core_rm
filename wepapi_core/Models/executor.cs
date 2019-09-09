using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using MySql.Data.EntityFrameworkCore;
using MySql.Data.Types;
using MySql.Data.common;

namespace RecruitmentMasterApi.Models
{
    public class executor
    {
        static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        static MySqlConnection con = new MySqlConnection(cs);
        MySqlCommand cmd = new MySqlCommand("",con);

        /*public IEnumerable<user_manager> GetAllUsers()
        {
            IEnumerable<user_manager> cmblist;
            userparameters u = new userparameters();
            cmd.CommandText = "user_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return reader[];
            }
        }*/

        public int PostUser(user_manager _u)
        {
            userparameters u = new userparameters();
            cmd.CommandText = "user_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(u.id, _u.p_id);
            cmd.Parameters.AddWithValue(u.email, _u.p_email);
            cmd.Parameters.AddWithValue(u.f_name, _u.p_f_name);
            cmd.Parameters.AddWithValue(u.l_address, _u.p_l_address);
            cmd.Parameters.AddWithValue(u.l_name, _u.p_l_name);
            cmd.Parameters.AddWithValue(u.m_name, _u.p_m_name);
            cmd.Parameters.AddWithValue(u.p_address, _u.p_p_address);
            cmd.Parameters.AddWithValue(u.phone, _u.p_phone);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }

        public int PutUser(user_manager _u,string _id)
        {
            userparameters u = new userparameters();
            cmd.CommandText = "user_update";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(u.id, _id);
            cmd.Parameters.AddWithValue(u.email, _u.p_email);
            cmd.Parameters.AddWithValue(u.f_name, _u.p_f_name);
            cmd.Parameters.AddWithValue(u.l_address, _u.p_l_address);
            cmd.Parameters.AddWithValue(u.l_name, _u.p_l_name);
            cmd.Parameters.AddWithValue(u.m_name, _u.p_m_name);
            cmd.Parameters.AddWithValue(u.p_address, _u.p_p_address);
            cmd.Parameters.AddWithValue(u.phone, _u.p_phone);
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
            cmd.Parameters.AddWithValue(e.Id,_e.p_Id);
            cmd.Parameters.AddWithValue(e.f_name,_e.p_f_name);
            cmd.Parameters.AddWithValue(e.m_name,_e.p_m_name);
            cmd.Parameters.AddWithValue(e.l_name,_e.p_l_name);
            cmd.Parameters.AddWithValue(e.qualification,_e.p_qualification);
            cmd.Parameters.AddWithValue(e.school,_e.p_school);
            cmd.Parameters.AddWithValue(e.intv_no,_e.p_intv_no);
            cmd.Parameters.AddWithValue(e.adr1,_e.p_adr1);
            cmd.Parameters.AddWithValue(e.adr2,_e.p_adr2);
            cmd.Parameters.AddWithValue(e.adr3,_e.p_adr3);
            cmd.Parameters.AddWithValue(e.st_no,_e.p_st_no);
            cmd.Parameters.AddWithValue(e.st_name,_e.p_st_name);
            cmd.Parameters.AddWithValue(e.city,_e.p_city);
            cmd.Parameters.AddWithValue(e.state,_e.p_state);
            cmd.Parameters.AddWithValue(e.pin,_e.p_pin);
            cmd.Parameters.AddWithValue(e.employment_type,_e.p_employment_type);
            cmd.Parameters.AddWithValue(e.interview_date,_e.p_interview_date);
            cmd.Parameters.AddWithValue(e.online_diary_no,_e.p_online_diary_no);
            cmd.Parameters.AddWithValue(e.dispatch_no,_e.p_dispatch_no);
            cmd.Parameters.AddWithValue(e.join_date,_e.p_join_date);
            cmd.Parameters.AddWithValue(e.dated,_e.p_dated);
            cmd.Parameters.AddWithValue(e.gen_applied_post,_e.p_gen_applied_post);
            cmd.Parameters.AddWithValue(e.gen_basic_pay,_e.p_gen_basic_pay);
            cmd.Parameters.AddWithValue(e.gen_pay_scale_level,_e.p_gen_pay_scale_level);
            cmd.Parameters.AddWithValue(e.gen_payscale,_e.p_gen_payscale);
            cmd.Parameters.AddWithValue(e.addhoc_net_salary,_e.p_addhoc_net_salary);
            cmd.Parameters.AddWithValue(e.addhoc_tenure,_e.p_addhoc_tenure);
            cmd.Parameters.AddWithValue(e.addhoc_from_date,_e.p_addhoc_from_date);
            cmd.Parameters.AddWithValue(e.addhoc_to_date,_e.p_addhoc_to_date);
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
            cmd.Parameters.AddWithValue(e.f_name, _e.p_f_name);
            cmd.Parameters.AddWithValue(e.m_name, _e.p_m_name);
            cmd.Parameters.AddWithValue(e.l_name, _e.p_l_name);
            cmd.Parameters.AddWithValue(e.qualification, _e.p_qualification);
            cmd.Parameters.AddWithValue(e.school, _e.p_school);
            cmd.Parameters.AddWithValue(e.intv_no, _e.p_intv_no);
            cmd.Parameters.AddWithValue(e.adr1, _e.p_adr1);
            cmd.Parameters.AddWithValue(e.adr2, _e.p_adr2);
            cmd.Parameters.AddWithValue(e.adr3, _e.p_adr3);
            cmd.Parameters.AddWithValue(e.st_no, _e.p_st_no);
            cmd.Parameters.AddWithValue(e.st_name, _e.p_st_name);
            cmd.Parameters.AddWithValue(e.city, _e.p_city);
            cmd.Parameters.AddWithValue(e.state, _e.p_state);
            cmd.Parameters.AddWithValue(e.pin, _e.p_pin);
            cmd.Parameters.AddWithValue(e.employment_type, _e.p_employment_type);
            cmd.Parameters.AddWithValue(e.interview_date, _e.p_interview_date);
            cmd.Parameters.AddWithValue(e.online_diary_no, _e.p_online_diary_no);
            cmd.Parameters.AddWithValue(e.dispatch_no, _e.p_dispatch_no);
            cmd.Parameters.AddWithValue(e.join_date, _e.p_join_date);
            cmd.Parameters.AddWithValue(e.dated, _e.p_dated);
            cmd.Parameters.AddWithValue(e.gen_applied_post, _e.p_gen_applied_post);
            cmd.Parameters.AddWithValue(e.gen_basic_pay, _e.p_gen_basic_pay);
            cmd.Parameters.AddWithValue(e.gen_pay_scale_level, _e.p_gen_pay_scale_level);
            cmd.Parameters.AddWithValue(e.gen_payscale, _e.p_gen_payscale);
            cmd.Parameters.AddWithValue(e.addhoc_net_salary, _e.p_addhoc_net_salary);
            cmd.Parameters.AddWithValue(e.addhoc_tenure, _e.p_addhoc_tenure);
            cmd.Parameters.AddWithValue(e.addhoc_from_date, _e.p_addhoc_from_date);
            cmd.Parameters.AddWithValue(e.addhoc_to_date, _e.p_addhoc_to_date);
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