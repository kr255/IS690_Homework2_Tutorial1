using System;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        private static void Main()
        {
            using (var db = new SchoolContext()) {

                db.Students.Add(
                new Student
                {
                    StudentId = 1,
                    StudentName = "Bill"
                });
                db.SaveChanges();

            }
        }
    }
}
