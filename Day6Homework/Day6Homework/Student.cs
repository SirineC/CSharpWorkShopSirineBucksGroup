using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Homework
{
    internal class Student
    {
        //properties or variables

        public int StudyHoursPerWeek { get; set; }
        public int StudyWeeksCompleted { get; set; }

        public string NameOfStudent { get; set; }

        //for the output
        public string OutputStorage { get; set; }

        //functions
        public void BuildStudentInformation()
        {
            this.OutputStorage = $" Study Name: {this.NameOfStudent} Study Hours: {this.StudyHoursPerWeek} Number of Weeks Completed : {this.StudyWeeksCompleted}";
        }

        public void DisplayStudentInformation()
        {
            Console.WriteLine(this.OutputStorage);
        }
    }
}
