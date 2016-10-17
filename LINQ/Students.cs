using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Students
    {
        List<string> StudentList;

        public Students()
        {
            StudentList = new List<string>() { "Luke Cage", "", "Jessica Jones", "Matthew Murdock", "Jessica Jones", "Luke Cage"};
        }

        public void GetOriginalStudentList()
        {
            foreach (string student in StudentList)
            {
                Console.Write("{0}", student);
            }
        }
        public void GetNewStudentList()
        {
            var studentName = StudentList.Distinct();
            
            foreach (string student in StudentList)
            {
                Console.Write("{0}", student);
            }
        }
    }
}
