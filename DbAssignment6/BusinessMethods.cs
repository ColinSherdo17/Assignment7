using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;


namespace DbAssignment6
{
    class BusinessMethods
    {
        public int ValidPermitCount()
        {
            int count = 0;

            foreach(Student student in Veichles)
            {
                foreach(Program veichle in student.veichles)
                {
                    if(veichle.Permit.Date <= DateTime.Now)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
