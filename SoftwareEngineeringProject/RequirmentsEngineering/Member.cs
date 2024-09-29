using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RequirmentsEngineering
{
    internal class Member
    {
        //variables 
        private int MemID;
        private String Fname;   
        private String Sname;
        private DateTime DOB;
        private String Status;
        private String Email;
        private String Phone;
        private int Wallet;
        private DateTime DateRegistered;


        //No argument consrtructor
        public Member()
        {
            this.MemID = 0;
            this.Fname = "";
            this.Sname = "";
            this.DOB = DateTime.Now;
            this.Status = "";
            this.Email = "";
            this.Phone = "";
            this.Wallet = 0;
            this.DateRegistered = DateTime.Now;
        }

        //9 argument constructor
        public Member(int memID, string fname, string sname, DateTime dOB,  string email, string phone)
        {
            this.MemID = memID;
            this.Fname = fname;
            this.Sname = sname;
            this.DOB = dOB;
            this.Status = "A";
            this.Email = email;
            this.Phone = phone;
            this.Wallet = 0;
            this.DateRegistered = DateTime.Now;
        }

        //getters
        public int getMemID() { return this.MemID; }
        public String getFname() { return this.Fname; }
        public String getSname() { return this.Sname;}
        public DateTime getDOB() {  return this.DOB; }
        public string getStatus() { return this.Status;}
        public string getEmail() { return this.Email;}
        public string getPhone() { return this.Phone;}
        public int getWallet() { return this.Wallet;}
        public DateTime getDateRegistered() { return this.DateRegistered;}

        //setters
        public void setMemID(int MemID) {  this.MemID = MemID; }
        public void setFname(String fname) {  this.Fname = fname; }
        public void setSname(String sname) { this.Sname = sname; }
        public void setDOB(DateTime DOB) {  this.DOB = DOB; }
        public void setStatus(String status) {  this.Status = status; }
        public void setEmail(String email) {  this.Email = email; }
        public void setPhone(String phone) {  this.Phone = phone; }
        public void setWallet(int Wallet) {  this.Wallet = Wallet; }
        public void setDateRegistered(DateTime dateRegistered) { this.DateRegistered = dateRegistered;}


        public static void getAllRenewMembers(DataGridView dg)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Members "+ 
                "WHERE Status = 'I'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr= cmd.ExecuteReader();

            if(dg.Columns.Count == 0 )
            {
                dg.Columns.Add("MemID","MemID");
                dg.Columns.Add("Fname", "Fname");
                dg.Columns.Add("Sname", "Sname");
                dg.Columns.Add("Phone", "Phone");
                dg.Columns.Add("Email", "Email");

            }

            dg.Rows.Clear();

            while (dr.Read())
            {
                dg.Rows.Add(dr["MemID"].ToString(), dr["Fname"], dr["Sname"], dr["Phone"].ToString(), dr["Email"]);
            }

            
        }

        public static void getAllCloseMembers(DataGridView dg)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Members " +
                "WHERE Status = 'A'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if (dg.Columns.Count == 0)
            {
                dg.Columns.Add("MemID", "MemID");
                dg.Columns.Add("Fname", "Fname");
                dg.Columns.Add("Sname", "Sname");
                dg.Columns.Add("Phone", "Phone");
                dg.Columns.Add("Email", "Email");

            }

            dg.Rows.Clear();

            while (dr.Read())
            {
                dg.Rows.Add(dr["MemID"].ToString(), dr["Fname"], dr["Sname"], dr["Phone"].ToString(), dr["Email"]);
            }


        }


        public static int getNextMemID()
        {

            //Open a db connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //SQL query to be executed 
            String maxSqlQuery = "SELECT MAX(MemID) FROM Members";

            //Execute Query
            OracleCommand cmd = new OracleCommand(maxSqlQuery,con);
            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //is dr null?
            int nextId;
            dr.Read();

            if(dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close DB Connection
            con.Close();

            return nextId;

        }

        public void addMember()
        {
            //Open Connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //Sql query to be executed
            String addSqlQuery = "INSERT INTO MEMBERS Values (" +
                this.MemID + ",'" +
                this.Fname + "','" +
                this.Sname + "','" +
                this.DOB.ToString("dd-MMM-yyyy") + "','" +
                this.Status + "','" +
                this.Email + "','" +
                this.Phone + "'," +
                this.Wallet + ",'" +
                this.DateRegistered.ToString("dd-MMM-yyyy") + "')";

            //Execute query 
            OracleCommand cmd = new OracleCommand(addSqlQuery,con);
            con.Open();

            cmd.ExecuteNonQuery();

            //Close Connection
            con.Close();
        }

        public void getMember(String fname, String sname)
        {
            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //Query to be executed
            String sqlQuery = "SELECT FNAME, SNAME, EMAIL, PHONE FROM Members WHERE FNAME = '" + fname + "'AND SNAME = '" + sname + "'";

            //execute the query
            OracleCommand cmd = new OracleCommand(sqlQuery,con);

            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();


            setFname(dr.GetString(0));
            setSname(dr.GetString(1));
            setEmail(dr.GetString(2));
            setPhone(dr.GetString(3));
        }

        public void getMemberRenewOrClose(String MemID)
        {
            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //Query to be executed
            String sqlQuery = "SELECT FNAME, SNAME, EMAIL, PHONE FROM Members WHERE MEMID = " + MemID;

            //execute the query
            OracleCommand cmd = new OracleCommand(sqlQuery, con);

            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setFname(dr.GetString(0));
            setSname(dr.GetString(1));
            setEmail(dr.GetString(2));
            setPhone(dr.GetString(3));
        }

        public void updateMember(String fname, String sname)
        {

            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //define query
            String sqlQuery = "UPDATE Members SET " +
                "FNAME = '" + this.Fname + "'," +
                "SNAME = '" + this.Sname + "',"+
                "EMAIL = '" + this.Email + "',"+
                "PHONE = '" + this.Phone + "' "+
                "WHERE FNAME = '" + fname + "'AND SNAME = '" + sname + "'";
        
            //execute query
            OracleCommand cmd = new OracleCommand( sqlQuery,con);
            con.Open();

            cmd.ExecuteNonQuery();

            //close connection
            con.Close();
        
        }

        public void updateStatusRenew(String MemID)
        {
            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //define query
            String sqlQuery = "UPDATE Members " +
                "SET STATUS = 'A'" +
                "WHERE MemID = " + MemID;

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, con);
            con.Open();

            cmd.ExecuteNonQuery();

            //close connection
            con.Close();
        }

        public void updateStatusClose(String MemID)
        {
            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //define query
            String sqlQuery = "UPDATE Members " +
                "SET STATUS = 'I'" +
                "WHERE MemID = " + MemID;

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, con);
            con.Open();

            cmd.ExecuteNonQuery();

            //close connection
            con.Close();
        }

        public void addingFunds(String fname, String sname, double amount)
        {

            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);


            String sqlQuery = "SELECT Wallet FROM Members WHERE FNAME = '" + fname + "'AND SNAME = '" + sname + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, con);
            con.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            double currentBal;
            reader.Read();




                currentBal = Convert.ToDouble(reader.GetString(0));
                double amountToStore = currentBal + amount;
                con.Close();

                //define query
                String sqlQuery2 = "UPDATE Members SET " +
                    "WALLET = " + amountToStore +
                   "WHERE FNAME = '" + fname + "'AND SNAME = '" + sname + "'";

                //execute query
                OracleCommand cmd2 = new OracleCommand(sqlQuery2, con);
                con.Open();

                cmd2.ExecuteNonQuery();

                //close conn
                con.Close();

            }
        }





    
}
