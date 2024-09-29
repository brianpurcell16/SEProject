using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequirmentsEngineering
{
    internal class Classes
    {
        //variables
        private int ClassID;
        private String Title;
        private int Price;
        private String Status;
        private String CTime;
        private DateTime CDate;
        private int Capacity;
        private int AvailableSpaces;
        private DataGrid dg;


        //no argument constructor
        public Classes() {
            this.ClassID = 0;
            this.Title = "";
            this.Price = 0;
            this.Status = "";
            this.CTime = "";
            this.CDate = DateTime.Now;
            this.Capacity = 0;  
            this.AvailableSpaces = 0;
        
        }

        //multi argument constructor
        public Classes(int classID, string title, int price, string cTime, DateTime cDate, int capacity, int availableSpaces)
        {
            this.ClassID = classID;
            this.Title = title;
            this.Price = price;
            this.Status = "A";
            this.CTime = cTime;
            this.CDate = cDate;
            this.Capacity = capacity;
            this.AvailableSpaces = capacity;
        }

        //getters
        public int getClassID() { return this.ClassID; }
        public String getTitle() { return this.Title; }
        public int getPrice() { return this.Price;}
        public String getStatus() { return this.Status; }
        public String getCTime() { return this.CTime;}
        public int getCapacity() { return this.Capacity;}
        public int getAvailableSpaces() { return this.AvailableSpaces;} 
        public DateTime GetCDate() { return this.CDate; }

        //setters
        public void setClassID(int ClassID) {  this.ClassID = ClassID; }
        public void setTitle(String Title) {  this.Title = Title; }
        public void setPrice(int Price) {  this.Price = Price; }
        public void setStatus(String Status) {  this.Status = Status; }
        public void setCTime(String CTime) { this.CTime = CTime; }
        public void setCapacity(int Capacity) {  this.Capacity = Capacity; }
        public void setAvailableSpaces(int AvailableSpaces) {  this.AvailableSpaces = AvailableSpaces; }
        public void setCDate(DateTime CDate) { this.CDate = CDate;}

        public static int getNextClassID()
        {

            //Open a db connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //SQL query to be executed 
            String maxSqlQuery = "SELECT MAX(ClassID) FROM Classes";

            //Execute Query
            OracleCommand cmd = new OracleCommand(maxSqlQuery, con);
            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //is dr null?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close DB Connection
            con.Close();

            return nextId;

        }

        public void addClass()
        {
            //Open Connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //Sql query to be executed
            String addSqlQuery = "INSERT INTO CLASSES Values (" +
                this.ClassID + ",'" +
                this.Title + "'," +
                this.Price + ",'" +
                this.Status + "','" +
                this.CTime + "','" +
                this.CDate.ToString("dd-MMM-yyyy") + "'," +
                this.Capacity + "," +
                this.AvailableSpaces+ ")";

            //Execute query 
            OracleCommand cmd = new OracleCommand(addSqlQuery, con);
            con.Open();

            cmd.ExecuteNonQuery();

            //Close Connection
            con.Close();
        }

        public static void activeClasses(DataGridView dg)
        {
            //Open Connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //Sql query to be executed
            String selectSqlQuery = "SELECT * " +
                "FROM Classes " +
                "WHERE Status = 'A'";

            //Execute query 
            OracleCommand cmd = new OracleCommand(selectSqlQuery, con);
            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if(dg.Columns.Count == 0)
            {
                dg.Columns.Add("ClassID", "ClassID");
                dg.Columns.Add("Title", "Title");
                dg.Columns.Add("Price", "Price");
                dg.Columns.Add("Time", "Time");
                dg.Columns.Add("Date", "Date");
                dg.Columns.Add("Capacity", "Capacity");
                dg.Columns.Add("AvailableSpaces", "AvailableSpaces");
            }

            dg.Rows.Clear();

            while (dr.Read())
            {
                dg.Rows.Add(dr["ClassID"].ToString(),dr["Title"],dr["Price"].ToString(),dr["CTime"].ToString(),dr["CDate"].ToString().Substring(0,10),dr["Capacity"].ToString(), dr["AvailableSpaces"].ToString());
            }

            

        }

        public void getCancelDetails(String ClassID)
        {
            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //Query to be executed
            String sqlQuery = "SELECT Title,CDate,CTime,Price,Capacity FROM CLASSES WHERE ClassID = " +ClassID;

            //execute the query
            OracleCommand cmd = new OracleCommand(sqlQuery, con);

            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.Read() == false)
            {
                return;
            }

            setTitle(dr.GetString(0));
            setCDate(DateTime.Parse(dr.GetString(1)));
            setCTime(dr.GetString(2));
            setPrice(Convert.ToInt32(dr.GetString(3)));
            setCapacity(Convert.ToInt32(dr.GetString(4)));

        }

        public void cancelClass(String ClassID)
        {
            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //define query
            String sqlQuery = "UPDATE Classes " +
                "SET STATUS = 'I'" +
                "WHERE ClassID = " + ClassID;

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, con);
            con.Open();

            cmd.ExecuteNonQuery();

            //close connection
            con.Close();
        }






    }
}
