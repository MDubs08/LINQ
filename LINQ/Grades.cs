using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Grades
    {
        List<string> StudentGrades = new List<string>() { "88,55,62,100,77", "50,50,100,85,72", "65,55,95,50,100"};
        List<decimal> FinalGrades = new List<decimal>();

        private string[] SeperateArray(string grades)
        {
            string[] studentGrades = grades.Split(',');

            return studentGrades;
        }

        private List<decimal> RemoveLowestGrade(string grades)
        {
            var studentGrades = SeperateArray(grades).Select(x => Convert.ToDecimal(x)).ToList();
            studentGrades.Remove(studentGrades.Min());
            return studentGrades;
        }

        public void AddToFinalGrades()
        {
            foreach (string grades in StudentGrades)
            {
                var grade = Convert.ToDecimal(grades);
                FinalGrades.Add(grade);
            }
        }
        public void GetStudentAverage()
        {
            AddToFinalGrades();
            foreach (decimal grade in FinalGrades)
            {
                Console.WriteLine("Student Averages: {0}", grade);
            }

            Console.WriteLine("Total average: {0}", FinalGrades.Average());
        }
    }
}
