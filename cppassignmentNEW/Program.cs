using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cppassignmentNEW
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new home());
        }
    }

    public static class global_variables
    {
        public static Form[] windows = {
            new home(),
            new Form1(),
            new database_window()


        };
        public static void nextWindow(Form windowtype)
        {
            Form tempform = windowtype;
            foreach (Form window in windows)
            {
                if(window.Visible == true)
                {
                    window.Hide();
                }
            }
            foreach (Form window in windows)
            {
                if (window.GetType().ToString() == tempform.GetType().ToString())
                {
                    window.Show();
                    break;
                }
            }
        }

    }

    public static class queryDB
    {
        //PUT THE CONNECTOR PORT HERE AS A BY RIGHT CLICKING THE DATABASE AND TAKE THE DATAPORT FORM THE PROPERITES
        static string database_properties = "Data Source=localhost; user id='root'; Initial Catalog='StudOrgInfo'";
        //PLS DO THIS OR ELSE PROGRAM WILL FAIL TO RUN DUMB SKIBIDI GYATT

        public static MySqlCommand cmd = new MySqlCommand();//DONT TOUCH THIS BTW
        public static string Last_Created_ID = "";
        static MySqlConnection con = new MySqlConnection(database_properties);
        static bool isConnectionOpened = false;
        public static void query(string SQLCOMMAND)//Performs a commmand through a string
        {
            
            if (isConnectionOpened)
            {
                con.Close();
            }
            con.Open();
            isConnectionOpened = true;
            cmd.CommandText = SQLCOMMAND;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

        }

        public static void update(string New_Value, string Column, string RowIdentifier, string Row, string Table)//changes a specified field in a specified row 
        {

            try
            {
                query("UPDATE " + Table + " SET " + Column + " = '" + New_Value + "' where " + RowIdentifier + " = '" + Row + "'");
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { return; }   //DOES NOTHING IF THE SPECIFIED  FIELDS DO NOT EXIST AT ALL.
        }

        public static String select(string Column, string RowIdentifier, string Row, string Table)//returns a string value of  a specified row and column
        {
            try
            {
                query("SELECT " + Column + " from " + Table + " where " + RowIdentifier + " = '" + Row + "'");
                MySqlDataReader table_scanner = cmd.ExecuteReader();
                table_scanner.Read();
                return table_scanner.GetValue(0).ToString();
            }
            catch (Exception e) { return null; }   //DOES NOTHING IF THE SPECIFIED  FIELDS DO NOT EXIST AT ALL.

        }

        public static Array selectMultiple(string Column, string Table)
        {
            String[] templar = new String[0];
            int index = 0;
            query("SELECT " + Column + " From " + Table);
            MySqlDataReader table_scanner = cmd.ExecuteReader();
            string storedString = "";
            while (true)
            {
                try
                {
                    table_scanner.Read();
                    storedString = table_scanner.GetValue(0).ToString();
                    Array.Resize(ref templar, templar.Length + 1);
                    templar[index] = storedString;
                    index++;
                    continue;
                }
                catch (Exception e)
                {
                    break;
                }
            }
            return templar;
        }
        public static void insert(string PrimaryKeyName, string Table)//creates a new row with a random key
        {
            while (true)
            {
                Random rnd = new Random();
                string IDNumber = DateTime.Now.Year.ToString() + rnd.Next(100000, 999999);
                try
                {
                    query("SELECT " + PrimaryKeyName + " From " + Table + " where " + PrimaryKeyName + " = " + IDNumber);
                    MySqlDataReader table_scanner = cmd.ExecuteReader();
                    table_scanner.Read();
                    Console.WriteLine(table_scanner.GetValue(0).ToString());

                    continue;
                }
                catch (Exception e)
                {
                    Last_Created_ID = IDNumber;
                    query("INSERT INTO " + Table + "(" + PrimaryKeyName + ") VALUES (" + IDNumber + ")");
                    Console.WriteLine("INSERT INTO " + Table + "(" + PrimaryKeyName + ") VALUES ('" + IDNumber + "')");
                    cmd.ExecuteNonQuery();
                    break;
                }
            }
        }

        public static DataTable selectTable(string Query) { 
            query(Query);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        
        }
    }
}