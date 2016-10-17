using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            Console.WriteLine("Original Student List");
            students.GetOriginalStudentList();
            Console.WriteLine("Student List Without Duplicates");
            students.GetNewStudentList();
            Console.WriteLine("Class Average");
            Grades grades = new Grades();
            grades.GetStudentAverage();
        }
    }
}
