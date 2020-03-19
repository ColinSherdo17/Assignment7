using System;
using System.Data;
using System.Data.OleDb;

namespace DbAssignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Owner\Desktop\COLLEGE\.NET\Veichles.accdb";
            connect.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "SELECT Student_ID FROM Veichles";
            OleDbDataReader reader = command.ExecuteReader();
            connect.Close();
        }
    }
}
