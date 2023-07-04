using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Homework
{
    public class Graduate
    {
        //constructor to assign default values
        public Graduate()
        {
            this.TotalNumberOfHoursToGraduate = 1000;
        }

        //fields or peoperties for this class
        public int TotalNumberOfHoursToGraduate { get; set; }
        public string outputforStudent { get; set; }

        public void CalculateGraduateEstimate(int StudyHoursPerWeek, int StudyWeeksCompleted, string NameOfStudent)
        {
            int numberOfWeeksBasedOnStudentWeeklyHoursCommitment = this.TotalNumberOfHoursToGraduate / StudyHoursPerWeek;

            int remainingnumberOfWeeksToStudy = numberOfWeeksBasedOnStudentWeeklyHoursCommitment - StudyWeeksCompleted;

            //for example, suppose the output is 25 weeks.
            //that is roughly 5 months. 

            int numberofMonths = 0;

            while (remainingnumberOfWeeksToStudy > 4)
            {
                numberofMonths = numberofMonths + 1;
                remainingnumberOfWeeksToStudy =
                    remainingnumberOfWeeksToStudy - 4;
            }

            this.outputforStudent = $" Student Name : {NameOfStudent} will need to study for {numberofMonths} months to graduate";
        }

        public void DisplayGraduateEstimate()
        {
            Console.WriteLine(outputforStudent);
        }
    }
}
