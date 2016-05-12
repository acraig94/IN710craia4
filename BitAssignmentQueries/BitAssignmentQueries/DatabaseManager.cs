using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitAssignmentQueries
{
    public class DatabaseManager
    {
        private SqlConnection con;
        private AssignmentDbDataContext db;

        public DatabaseManager()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = World;" +
                                                "User ID = craia4;" +
                                                "Password = ;"; // Add password
            db = new AssignmentDbDataContext();
        }
        // Throwing error on Reader
        public List<String> ListPapers()
        {
            con.Open();
            List<String> queryList = new List<string>();
            string selectQuery = "Select p.paperName, t.name, t.email FROM tblPaper as p JOIN tblTutor as t ON p.paperTutorId=t.tutorId";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = selectQuery;
            SqlDataReader cmdReader = cmd.ExecuteReader();

            while (cmdReader.Read())
            {
                queryList.Add(cmdReader["p.paperName"].ToString() + "\t" + cmdReader["t.name"].ToString() + "\t" + cmdReader["t.email"].ToString());
            }
            cmdReader.Close();
            con.Close();
            return queryList;
        }

    }
}
