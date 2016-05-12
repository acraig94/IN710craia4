using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitAssignmentBuilder
{
    public class TableBuilder
    {
        private SqlConnection bitDevConnection;
        public TableBuilder()
        {
            bitDevConnection = new SqlConnection();
            bitDevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = World;" +
                                                "User ID = craia4;" +
                                                "Password = ;"; // Add password
        }

        public void CreateTables()
        {            
            String createQuery =    "DROP TABLE IF EXISTS tblPaper" +
                                    "DROP TABLE IF EXISTS tblTutor" +
                                    "DROP TABLE IF EXISTS tblAssignment" +

                                    "CREATE TABLE tblTutor" +
                                    "(" +
                                    "    tutorID      int     IDENTITY," +
                                    "    name    char(50)        NOT NULL," +

                                    "    CONSTRAINT PK_tblTutor PRIMARY KEY(tutorId)" +
                                    ")" +

                                    "CREATE TABLE tblPaper" +
                                    "(" +
                                    "    paperCode        char(20)         NOT NULL," +
                                    "    paperName      char(50)            NOT NULL," +
                                    "    paperTutorId      int         NOT NULL, --FK to tblTutor" +

                                    "    CONSTRAINT PK_tblPaper PRIMARY KEY(paperCode)," +
                                    "    FOREIGN KEY(paperTutorId) REFERENCES tblTutor(tutorId)" +
                                    ")" +                  

                                    "CREATE TABLE tblAssignment" +
                                    "(" +
                                    "    assignmentID       int     IDENTITY," +
                                    "    paperCode        char(20)     NOT NULL, --FK to tlbPaper" +
                                    "    assignmentName     char(40)        NOT NULL," +
                                    "    dateDue        date    NULL," +

                                    "    CONSTRAINT PK_Assignment PRIMARY KEY(assignmentID)," +
                                    "    FOREIGN KEY(paperCode) REFERENCES tblPaper(paperCode)" +
                                    ")";
            bitDevConnection.Open();
            SqlCommand createTables = new SqlCommand(createQuery, bitDevConnection);
            createTables.ExecuteNonQuery();
            bitDevConnection.Close();
        }

        public void InsertSeedData()
        {
            String insertQuery = "INSERT INTO tblPaper VALUES('IN710','OOSD',1)" +
                                    "INSERT INTO tblPaper VALUES('IN712','Mobile Development & Design',1)" +
                                    "INSERT INTO tblPaper VALUES('IN718','Web 3',2)" +

                                    "INSERT INTO tblTutor VALUES('Bob Burgers')" +
                                    "INSERT INTO tblTutor VALUES('Sterling Archer')" +
                                    "INSERT INTO tblTutor VALUES('Rick Sanchez')" +

                                    "INSERT INTO tblAssignment VALUES('IN710', 'Gray Scott Diffusion Model', 20161206)" +
                                    "INSERT INTO tblAssignment VALUES('IN712', 'Language Trainer', 20160606)";
            bitDevConnection.Open();
            SqlCommand insert = new SqlCommand(insertQuery, bitDevConnection);
            insert.ExecuteNonQuery();
            bitDevConnection.Close();
        }


    }
}
