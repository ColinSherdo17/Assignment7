using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;



namespace DbAssignment6
{
    public class BusinessMethods
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
                    Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", reader["Student_ID"].ToString(), reader["Veichle_Model"].ToString(), reader["Registration"].ToString(), reader["Owner"].ToString(), reader["Apartment"].ToString(), reader["Permit"].ToString(), reader["Fees"].ToString());

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

                    Console.WriteLine();
                }
                return veichle; 
            }
        }
        public void CalculatePermits()
        {
            int expiredCount = 0;
            int ValidCount = 0;
            veichle = BusinessMethods.ValidPermitCount();
            Console.WriteLine("--------Valid And Expired Permits------");
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
            Console.WriteLine();
        }

        public static bool ExpiredPermits(DateTime Permit)
        {
           
                DateTime Expired = Permit.AddMonths(6);
                if (Expired < DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }

        public void changePermit()
        {
            int Pending = 0;
            int NewPermit = 0;
            Console.WriteLine("--------Reallocated Permits------");
            foreach (Veichle b in veichle)
            {

                if (reallocatePermit(b.Permit, b.Fees) == true)
                {
                    NewPermit++;
                    Console.Write(b.Owner.ToString() + " : " + "Permit issued\n");

                }
                else
                {
                    Pending++;
                    Console.Write(b.Owner.ToString() + " : " + "Pending Fees\n");
                }
                


            }
            Console.WriteLine();

            
           
            
        }

        public static bool reallocatePermit(DateTime Permit, Double Fees)
        {
            DateTime NewPermit = DateTime.Now;
            Double Pending = Fees;

            if (NewPermit > Permit.AddMonths(6) && Pending == 0)
            {
                return true;
            }
            else if(NewPermit < Permit.AddMonths(6) && Pending == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double AdditionalFees(double Fees)
        {
            double premium = 0.1;
            double NewFees = (Fees * premium);

            if (Fees > 0)
            {
                Fees = Fees + NewFees;
                return Fees;
            }
            else
            {
               return Fees;
            }
            
        }
        public void ApplyCharges()
        {
            Console.WriteLine("--------Owners with 10% added Premium------");
            foreach (Veichle c in veichle)
            {
               
                    Console.WriteLine(c.Owner.ToString() + ":" + AdditionalFees(c.Fees).ToString());         
                
            }

        }
       
    }
}
