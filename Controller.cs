using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_and_Registration_System
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public bool CheckIfUsernameExists(string username)
        {
            // SQL query to check if the input exists
            string query = "SELECT COUNT(*) FROM [Account Details] WHERE Username = '" + username + "';";

            // Execute the query and get the count
            int rowCount = Convert.ToInt32(dbMan.ExecuteScalar(query));

            // Return true if count is greater than 0, indicating existence
            return rowCount > 0;
        }

        public bool CheckIfPasswordExists(string username, string password)
        {
            // SQL query to check if the input exists
            string query = "SELECT COUNT(*) FROM [Account Details] WHERE Username = '" + username + "' AND Password = '" + password + "';";

            // Execute the query and get the count
            int rowCount = Convert.ToInt32(dbMan.ExecuteScalar(query));

            // Return true if count is greater than 0, indicating existence
            return rowCount > 0;
        }

        public int InsertUser(string username, string email, string phonenumber, string password)
        {
            string query = "INSERT INTO [Account Details](Username, Email, Password, [Phone Number]) " + "VALUES ('" + username + "', '" + email + "', '" + password + "', '" + phonenumber + "');";
            int insert = 1;
            insert = dbMan.ExecuteNonQuery(query);

            return insert;
        }

        public string GetEmail(string username)
        {
            string query = "SELECT Email FROM [Account Details] WHERE Username = '" + username + "';";
            object result = dbMan.ExecuteScalar(query);
            return result != null ? result.ToString() : "";
        }

        public string GetPhoneNumber(string username)
        {
            string query = "SELECT [Phone Number] FROM [Account Details] WHERE Username = '" + username + "';";
            object result = dbMan.ExecuteScalar(query);
            return result != null ? result.ToString() : "";
        }
    }
}
