using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
using System.Collections;

namespace EmployeeManagement
{
    public class Computations
    {
        string path = "server=.; database = employee_crud; Integrated Security = true";
        public DataTable GetAll()
        {            
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetAllEmployees", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);            
            conn.Close();
            return dt;
        }
        public void Add(Employee employee)
        {
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            SqlCommand cmd = new SqlCommand("AddEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Employee_ID", employee.Employee_ID));
            cmd.Parameters.Add(new SqlParameter("@Name", employee.Name));
            cmd.Parameters.Add(new SqlParameter("@Phone", employee.Phone));
            cmd.Parameters.Add(new SqlParameter("@Region", employee.Region));
            cmd.Parameters.Add(new SqlParameter("@City", employee.City));
            cmd.Parameters.Add(new SqlParameter("@Sub_City", employee.Sub_City));
            cmd.Parameters.Add(new SqlParameter("@Location_Special_Name", employee.Location_Special_Name));
            cmd.Parameters.Add(new SqlParameter("@Data_Update_Date", employee.Data_Update_Date));
            cmd.Parameters.Add(new SqlParameter("@Active_Ind", employee.Active_Ind));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable GetByName(string Name)
        {
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SearchEmployeeByName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Name", Name));
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool CheckEmployeeDuplication(string Employee_ID)
        {
            List<Employee> employeeList = new List<Employee>();
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SearchEmployeeByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Employee_ID",Employee_ID));
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    employeeList.Add(new Employee()
                    {
                        Employee_ID = reader["Employee_ID"].ToString(),
                        Name = reader["Name"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Region = reader["Region"].ToString(),
                        City = reader["City"].ToString(),
                        Sub_City = reader["Sub_City"].ToString(),
                        Location_Special_Name = reader["Location_Special_Name"].ToString(),
                        Data_Update_Date = reader["Data_Update_Date"].ToString(),
                        Active_Ind = (bool)reader["Active_Ind"]
                    });
                }
            }       
    
    conn.Close();
            if (employeeList.Count == 0)
            {
                return false;
            }
            return true;

        }
        public void Update(Employee employee)
        {
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UpdateEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Employee_ID", employee.Employee_ID));
            cmd.Parameters.Add(new SqlParameter("@Name", employee.Name));
            cmd.Parameters.Add(new SqlParameter("@Phone", employee.Phone));
            cmd.Parameters.Add(new SqlParameter("@Region", employee.Region));
            cmd.Parameters.Add(new SqlParameter("@City", employee.City));
            cmd.Parameters.Add(new SqlParameter("@Sub_City", employee.Sub_City));
            cmd.Parameters.Add(new SqlParameter("@Location_Special_Name", employee.Location_Special_Name));
            cmd.Parameters.Add(new SqlParameter("@Data_Update_Date", employee.Data_Update_Date));
            cmd.Parameters.Add(new SqlParameter("@Active_Ind", employee.Active_Ind));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        
    }
}
