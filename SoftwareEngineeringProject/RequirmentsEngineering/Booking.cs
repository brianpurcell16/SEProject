using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace RequirmentsEngineering
{
    internal class Booking
    {

        //variables
        private int BookingID;
        private int MemID;
        private int ClassID;
        private DateTime DateBooked;
        private String Status;

        //no argument constructor
        public Booking()
        {
            this.BookingID = 0;
            this.MemID = 0;
            this.ClassID = 0;
            this.DateBooked = DateTime.Now;
            this.Status = "";
        }

        //multi argument constructor
        public Booking(int BookingID, int MemID, int ClassID, DateTime DateBooked)
        {
            this.BookingID = BookingID;
            this.MemID = MemID;
            this.ClassID = ClassID;
            this.DateBooked = DateBooked;
            this.Status = "A";

        }

        //getters
        public int getBookingID() { return this.BookingID; }
        public int getMemID() {  return this.MemID; }
        public int getClassID() { return this.ClassID; }
        public DateTime getDateBooked() {  return this.DateBooked; }
        public String getStatus() { return this.Status;}


        //setters
        public void setBookingID(int BookingID) {  this.BookingID = BookingID;}

        public void setMemID(int MemID) {  this.MemID = MemID;}
        public void setClassID(int ClassID) {  this.ClassID = ClassID;}

        public void setDateBooked(DateTime DateBooked) {  this.DateBooked = DateBooked;}

        public void setStatus(String Status) {  this.Status = Status;}



        public static int getNextBookingID()
        {

            //Open a db connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //SQL query to be executed 
            String maxSqlQuery = "SELECT MAX(BookingID) FROM Bookings";

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

        public int getMemberID(String fname, String sname)
        {
            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //Query to be executed
            String sqlQuery = "SELECT MemID FROM Members WHERE FNAME = '" + fname + "'AND SNAME = '" + sname + "'";

            //execute the query
            OracleCommand cmd = new OracleCommand(sqlQuery, con);

            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            int MemID = dr.GetInt32(0);

            return MemID;

        }


        public static void getActiveClasses(DataGridView dg)
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

            if (dg.Columns.Count == 0)
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
                dg.Rows.Add(dr["ClassID"].ToString(), dr["Title"], dr["Price"].ToString(), dr["CTime"].ToString(), dr["CDate"].ToString(), dr["Capacity"].ToString(), dr["AvailableSpaces"].ToString());
            }



        }

        public int removingPrice(String fname, String sname, int ClassID)
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
            con.Close();


            String sqlQuery2 = "SELECT Price FROM Classes WHERE ClassID =" + ClassID;


            OracleCommand cmd2 = new OracleCommand(sqlQuery2, con);
            con.Open();
            OracleDataReader reader2 = cmd2.ExecuteReader();
            double price;
            reader2.Read(); 

            price = Convert.ToDouble(reader2.GetString(0));
            con.Close();

            if (currentBal < price)
            {
                return 0;
            }

            double amountToStore = currentBal - price;

            //define query
            String sqlQuery3 = "UPDATE Members SET " +
                "WALLET = " + amountToStore +
               "WHERE FNAME = '" + fname + "'AND SNAME = '" + sname + "'";

            //execute query
            OracleCommand cmd3 = new OracleCommand(sqlQuery3, con);
            con.Open();

            cmd3.ExecuteNonQuery();

            //close conn
            con.Close();

            return 1;
        }

        public int updatingAvailability(int ClassID)
        {
            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT AvailableSpaces FROM Classes WHERE ClassID = " + ClassID;

            OracleCommand cmd = new OracleCommand(sqlQuery, con);
            con.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            int availableSpaces;
            reader.Read();

            availableSpaces = Convert.ToInt32(reader.GetString(0));
            con.Close();

            if(availableSpaces < 0) 
            {
                return 0;
            
            }

            int newAvailableSpaces = availableSpaces - 1;

            String sqlQuery2 = "UPDATE Classes SET " +
                "AvailableSpaces = " + newAvailableSpaces +
               "WHERE ClassID = " + ClassID;

            OracleCommand cmd2 = new OracleCommand(sqlQuery2, con);
            con.Open();

            cmd2.ExecuteNonQuery();

            //Close connection
            con.Close();

            return 1;
        }

        public void addBooking(int ClassID)
        {
            //Open Connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT Price FROM Classes WHERE ClassID =" + ClassID;


            OracleCommand cmd = new OracleCommand(sqlQuery, con);
            con.Open();
            OracleDataReader reader = cmd.ExecuteReader();
            double price;
            reader.Read();

            price = Convert.ToDouble(reader.GetString(0));
            con.Close();

            //Sql query to be executed
            String addSqlQuery = "INSERT INTO Bookings Values (" +
               this.BookingID + ","+
               this.MemID + ","+
               this.ClassID + ","+
               price + ",'"+
               this.DateBooked.ToString("dd-MMM-yyyy") + "','"+
               this.Status + "')";

            //Execute query 
            OracleCommand cmd2 = new OracleCommand(addSqlQuery, con);
            con.Open();

            cmd2.ExecuteNonQuery();

            //Close Connection
            con.Close();
        }

        public static void activeBookings(DataGridView dg)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Bookings " +
                "WHERE Status = 'A'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if (dg.Columns.Count == 0)
            {
                dg.Columns.Add("BookingID", "BookingID");
                dg.Columns.Add("MemID", "MemID");
                dg.Columns.Add("ClassID", "ClassID");
                dg.Columns.Add("DateBooked", "DateBooked");

            }

            dg.Rows.Clear();

            while (dr.Read())
            {
                dg.Rows.Add(dr["BookingID"].ToString(), dr["MemID"].ToString(), dr["ClassID"].ToString(), dr["DateBooked"].ToString().Substring(0,10));
            }

        }

        public void getBookingDetails(int BookingID)
        {
            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            //Query to be executed
            String sqlQuery = "SELECT BookingID,MemID,ClassID,DateBooked FROM Bookings WHERE BookingID =" + BookingID;

            //execute the query
            OracleCommand cmd = new OracleCommand(sqlQuery, con);

            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();



            setBookingID(Convert.ToInt32(dr.GetString(0)));
            setMemID(Convert.ToInt32(dr.GetString(1)));
            setClassID(Convert.ToInt32(dr.GetString(2)));
            setDateBooked(DateTime.Parse(dr.GetString(3)));

            con.Close();

        
        }

        public void cancelBooking(int BookingID)
        {
            //open connection
            OracleConnection con = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT MemID,ClassID FROM bookings WHERE BookingID =" + BookingID;

            int MemID;
            int ClassID;

            OracleCommand cmd = new OracleCommand(sqlQuery, con);
            con.Open();

            OracleDataReader dr =  cmd.ExecuteReader();
            dr.Read();


            MemID = Convert.ToInt32(dr.GetString(0));
            ClassID = Convert.ToInt32(dr.GetString(1));

            con.Close();

            String sqlQuery2 = "SELECT Wallet FROM Members WHERE MemID =" + MemID;

            int wallet;

            OracleCommand cmd2 = new OracleCommand(sqlQuery2, con);
            con.Open();

            OracleDataReader dr2 = cmd2.ExecuteReader();
            dr2.Read();

            wallet = Convert.ToInt32(dr2.GetString(0));

            con.Close();

            String sqlQuery3 = "SELECT price,AvailableSpaces FROM Classes WHERE ClassID =" + ClassID;

            int price;
            int spaces;

            OracleCommand cmd3 = new OracleCommand(sqlQuery3, con);
            con.Open();

            OracleDataReader dr3 = cmd3.ExecuteReader();
            dr3.Read();

            price = Convert.ToInt32(dr3.GetString(0));
            spaces = Convert.ToInt32(dr3.GetString(1));

            con.Close();

            int refund = wallet + price;
            int newSpaces = spaces + 1;

            //define query
            String sqlQuery4 = "UPDATE Members SET " +
                "WALLET = " + refund +
               "WHERE MemID = " + MemID;

            //execute query
            OracleCommand cmd4 = new OracleCommand(sqlQuery4, con);
            con.Open();

            cmd4.ExecuteNonQuery();

            //close conn
            con.Close();

            //define query
            String sqlQuery5 = "UPDATE Classes SET " +
                "AvailableSpaces = " + newSpaces +
               "WHERE ClassID = " + ClassID;

            //execute query
            OracleCommand cmd5 = new OracleCommand(sqlQuery5, con);
            con.Open();

            cmd5.ExecuteNonQuery();

            //close conn
            con.Close();





            //define query
            String sqlQuery6 = "UPDATE Bookings " +
                "SET STATUS = 'I'" +
                "WHERE BookingID = " + BookingID;

            //execute query
            OracleCommand cmd6 = new OracleCommand(sqlQuery6, con);
            con.Open();

            cmd6.ExecuteNonQuery();

            //close connection
            con.Close();

            
        }

        public void genReport(String year,DataGridView dg)
        {

            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT to_Char(DateBooked, 'MM MONTH') AS Month,SUM(Price) AS Total FROM Bookings WHERE to_Char(DateBooked,'YYYY') = "+year+" GROUP BY to_Char(DateBooked, 'MM MONTH')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if (dg.Columns.Count == 0)
            {
                dg.Columns.Add("Month", "Month");
                dg.Columns.Add("Total", "Total");

            }

            dg.Rows.Clear();

            while (dr.Read())
            {
                dg.Rows.Add(dr["Month"], dr["Total"]);
            }

        }

        
        
    }
}




        



    

