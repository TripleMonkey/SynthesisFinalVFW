// Nigel Krajewski
// MDV1830-O C202007 01
// Synthesis - FINAL

using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NigelKrajewski_Final
{
    public static class DBUtilities
    {
        // create static string to hold exception message
        public static String excptMsg = "";

        // create connection string for database
        public static string BuildConnectionString()
        {
            // strings to hold ip address and port
            string serverIp = "";
            string port = "";
            // check for connect txt and assign to ip and port
            try
            {
                // open text file using stream reader
                using (StreamReader sr = new StreamReader(@"C:\\VFW\\connect.txt"))
                {
                    serverIp = sr.ReadLine();
                    port = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            // return full conn string
            return $"server={serverIp};uid=dbsAdmin;pwd=password;database=exampleDatabase;SslMode=none;port={port}";
        }

        // method to create connection to database
        public static MySqlConnection Connect(string myConnString)
        {
            // connection object to return
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = myConnString;
                conn.Open();

                // DEBUG messagebox to confirm connection
                //MessageBox.Show("Connected");
            }
            // assign custom message to static excptMsg string
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 1042:
                        excptMsg = "Can't Resolve host address.\n\n" + myConnString;
                        break;
                    case 1045:
                        excptMsg = "Invalid user name or password.";
                        break;
                    default:
                        excptMsg = e.ToString() + "\n\n" + myConnString;
                        break;
                }
            }
            return conn;
        }
    }
}
