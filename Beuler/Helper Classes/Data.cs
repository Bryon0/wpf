using System.Data.SqlClient;

namespace Beuler
{
    class Data
    {
        private string _serverName;
        private string _database;

        public Data(string server, string database)
        {
            _serverName = server;
            _database = database;
        }
        public void InsertNewUser(string firstName, string lastName, string email, string password, string address)
        {
            //string connectionString = $"server=(local)\SQLExpress;database=CompanyDB;integrated Security=SSPI;";
            string connectionString = $@"server={_serverName};database={_database};integrated Security=SSPI;";
            using(SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatement = @"INSERT INTO User (FistName, LastName, Email, Address, Password, DateTime) VALUES(@FistName, @LastName, @Email, @Address, @Password, @DateTime);";

                using(SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    _cmd.Parameters.AddWithValue("@FirstName", firstName);
                    _cmd.Parameters.AddWithValue("@LastName", lastName);
                    _cmd.Parameters.AddWithValue("@Email", email);
                    _cmd.Parameters.AddWithValue("@Password", password);
                    _cmd.Parameters.AddWithValue("@Address", address);
                    _cmd.Parameters.AddWithValue("@DateTime", System.DateTime.Now.ToString("MMMM dd, yyyy H:mm:ss"));
                    
                    _con.Open();
                    _cmd.ExecuteNonQuery();
                }
            }
        }

        public bool CheckForUser(string email)
        { 
            bool result = false:  
            //string connectionString = $"server=(local)\SQLExpress;database=CompanyDB;integrated Security=SSPI;";
            string connectionString = $@"server={_serverName};database={_database};integrated Security=SSPI;";
            using(SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatement = @"SELECT * FROM User WHERE Email='@Email'";;

                using(SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    _cmd.Parameters.AddWithValue("@Email", email);                    
                    _con.Open();
                    _cmd.ExecuteNonQuery();
                }
            }

            return result;
        }

    }
}
