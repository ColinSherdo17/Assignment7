using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;



namespace DbAssignment6
{
    //Methods to Analyze Database 
    public class BusinessMethods
    {
        //Creating a new Veichle List
        static List<Veichle> veichle = new List<Veichle>();
        public static List<Veichle> ValidPermitCount()
        {
            //String Connection
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Owner\Desktop\Assignmentone\Common7\COLLEGE\.NET\Veichles.accdb";
           //Selecting all from the Veichles Database
            string Query = "SELECT * FROM Veichles";

            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(Query, connection);
            //Opening the connection
            connection.Open();


            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine("----Original Data------");

                //While loop to create and print the Veichle object 
                while (reader.Read())
                {
                    Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", reader["Student_ID"].ToString(), reader["Veichle_Model"].ToString(), reader["Registration"].ToString(), reader["Owner"].ToString(), reader["Apartment"].ToString(), reader["Permit"].ToString(), reader["Fees"].ToString());

                    //Adding a new Veichle
                    veichle.Add(new Veichle()
                    {
                        //passing in the Db atributes and their datatype
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
        //Method to Calculate the number of valid and expired permits
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

        //Method to determine if a permit is expired or not
        public static bool ExpiredPermits(DateTime Permit)
        {
           //the permit is expired is the Permit date plus 6 months
                DateTime Expired = Permit.AddMonths(6);

            //if the expired is less than the date now it is expired
                if (Expired < DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }

        //Method for changing the Permit
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

        //Method that determines if a permit is to be reallocated or not depending on fees and the Permit date
        public static bool reallocatePermit(DateTime Permit, Double Fees)
        {
            DateTime NewPermit = DateTime.Now;
            Double Pending = Fees;

            //if the permit is valid and the fees are equals zero they are allocated a new Permit
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

        //Method to apply a 10% premium to the accounts with pending Fees
        public double AdditionalFees(double Fees)
        {
            //Declaring variables
            double premium = 0.1;
            double NewFees = (Fees * premium);

            //if fees are greater than 0
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

        //Method to Apply the charges to the accounts who have fees
        public void ApplyCharges()
        {
            Console.WriteLine("--------Owners with 10% added Premium------");

            //For loop to itterate through the List
            foreach (Veichle c in veichle)
            {
               
                    Console.WriteLine(c.Owner.ToString() + ":" + AdditionalFees(c.Fees).ToString());         
                
            }

        }
       
    }
}
