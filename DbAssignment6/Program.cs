using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;


namespace DbAssignment6
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            BusinessMethods businessMethods = new BusinessMethods();
            Console.WriteLine("");
            Console.WriteLine("");
            businessMethods.CalculatePermits();
            businessMethods.changePermit();
            businessMethods.ApplyCharges();

            List<Veichle> veichle = new List<Veichle>();

            //ConnectionString which creates the path to the database
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Owner\Desktop\COLLEGE\.NET\Veichles.accdb";
            //String Variables as queries to be executed on the db
            string Query = "SELECT * FROM Veichles";
            string Query1 = "UPDATE Veichles set Veichle_Model = 'Nissan' WHERE Veichle_Model = 'Ford'";
            string Query2 = "DELETE from Veichles WHERE Owner = 'Finula McGowan'";
            //string Query3 = "INSERT INTO Veichles(Veichle_Model, Registration, Owner, Apartment) VALUES ('16','SmartCar', '598473254', 'Finula McGowan', '20B')";

            //new OLEDB connection
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                //new OLEDB command to execute our first Query
                OleDbCommand cmd = new OleDbCommand(Query, connection);

                try
                {
                    //Opens the connection
                    connection.Open();

                    //DataReader to read the data returned from the command and executes it
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        //Console.WriteLine("----Original Data------");


                        while (reader.Read())
                        {
                            //Console.WriteLine("{0},{1},{2},{3},{4}", reader["Student_ID"].ToString(), reader["Veichle_Model"].ToString(), reader["Registration"].ToString(), reader["Owner"].ToString(), reader["Apartment"].ToString());

                        }
                    }
                    //Skip Line
                    Console.WriteLine();

                    //new Command set up to executeour second Query which is an update Query
                    OleDbCommand command = new OleDbCommand(Query1, connection);
                    command.ExecuteNonQuery(); //NonQuery which is not returning current items in the db but updating it

                    //execute the command
                    using (OleDbDataReader read = command.ExecuteReader())
                    {
                        //While loop to traverse through and print to console
                        while (read.Read())
                        {
                            Console.WriteLine(read["Veichle_Model"].ToString());
                        }
                    }

                    //new OLEDB command to execute our third Query Delete
                    OleDbCommand com = new OleDbCommand(Query2, connection);
                    command.ExecuteNonQuery(); //executes DELETE Query

                    using (OleDbDataReader rdr = com.ExecuteReader())
                    {
                        //loop to traverse and print to console
                        while (rdr.Read())
                        {
                            Console.WriteLine(rdr["Owner"].ToString());
                        }
                    }

                    //Command to execute our last Query which is an insert Query 
                    /* OleDbCommand Command = new OleDbCommand(Query3, connection);
                     Command.ExecuteNonQuery();

                     using (OleDbDataReader rdr = com.ExecuteReader())
                     {
                         //loop to traverse and print to console
                         while (rdr.Read())
                         {
                             Console.WriteLine(rdr["Veichles"].ToString());
                         }
                     }
                     */


                }
                //exception Handling
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }



        }
    }
}

