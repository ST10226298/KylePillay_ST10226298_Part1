using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Tesing.Models
{
    public class Table_1

    {
        public static string con_string = " Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=test;Data Source=labVMH8OX\\SQLEXPRESS";

        //public static string con_string = " Server=tcp:cldv-sql-server2024.database.windows.net,1433;Initial Catalog=cldv-db;Persist Security Info=False;User ID=PillayK;Password= Kylepill@y07;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public static SqlConnection con = new SqlConnection(con_string);

        public string Name { get; set; }
        public string Surname { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public int insert_User(Table_1 m) // insert_product
        {
            string sql = "INSERT INTO userTable (userName, userSurname, userEmail) VALUES (@Name, @Suranme, @Email)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Name", m.Name);
            cmd.Parameters.AddWithValue("@Surname",m.Surname); // each colum name e.g. product description 
            cmd.Parameters.AddWithValue("@Email",m.email);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;

        }
    }
}
