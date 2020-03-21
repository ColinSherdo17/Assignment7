using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;


namespace DbAssignment6
{
    class BusinessMethods
    {
        static List<Veichle> veichle = new List<Veichle>();
        public static List<Veichle> ValidPermitCount()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Owner\Desktop\COLLEGE\.NET\Veichles.accdb";
            //String Variables as queries to be executed on the db
            string Query = "SELECT * FROM Veichles";

            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(Query, connection);

            connection.Open();


            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine("----Original Data------");


                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString());
                    Console.WriteLine(reader[1].ToString());
                    Console.WriteLine(reader[2].ToString());
                    Console.WriteLine(reader[3].ToString());
                    Console.WriteLine(reader[4].ToString());
                    Console.WriteLine(reader[5].ToString());
                    Console.WriteLine(reader[6].ToString());

                    veichle.Add(new Veichle()
                    {

                        Student_ID = int.Parse(reader[0].ToString()),
                        Veichle_Model = reader[1].ToString(),
                        Registration = reader[2].ToString(),
                        Owner = reader[3].ToString(),
                        Apartment = reader[4].ToString(),
                        Permit = DateTime.Parse(reader[5].ToString()),
                        Fees = double.Parse(reader[6].ToString()),
                    });
                }
                return veichle;
            }
        }
        public void CalculatePermits()
        {
            int expiredCount = 0;
            int ValidCount = 0;
            veichle = BusinessMethods.ValidPermitCount();
            foreach (Veichle v in veichle)
            {

                if (ExpiredPermits(v.Permit) == true)
                {
                    expiredCount++;

                }
                else
                {
                    ValidCount++;
                }
            }

            Console.WriteLine("Expired Parking Permits:" + " " + expiredCount);
            Console.WriteLine("Valid Parking Permits:" + " " + ValidCount);
        }

        public static bool ExpiredPermits(DateTime Permit)
        {
           
                DateTime Expired = Permit.AddMonths(6);
                if (Expired > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }
    }
}
