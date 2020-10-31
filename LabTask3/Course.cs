using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;
        public void set(String courseName, String courseCode, int courseCredit)
        {
            this.courseCredit = courseCredit;
            this.courseCode = courseCode;
            this.courseName = courseName;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine(courseCode + "  " + courseCredit + "  " + courseName + "  ");
        }
    }

}
