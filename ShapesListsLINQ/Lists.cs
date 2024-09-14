using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    class Lists
    {
        public Student[] Students { get; set; }

        public Lists()
        {
            Students = new Student[] { new Student(1001, "Mark", "Buffon", new double[] { 78, 80, 72, 84, 88 }),
            new Student(1002, "Julia", "Roberts", new double[] { 74, 81, 56, 83, 90 }),
            new Student(1003, "Maria", "Randolph", new double[] { 80, 77, 65, 91, 93 }),
            new Student(1004, "John", "Bain", new double[] { 73, 71, 67, 55, 81 }),
            new Student(1005, "Mark", "Buffon", new double[] { 90, 89, 82, 74, 83 })};

        }

        public double studentTotalAverage(Student _st)
        {
            // find the total average of a student and return it
            double total = 0;
            foreach(double s in _st.Scores)
            {
                total += s;
            }
            return total / _st.Scores.Count();
        }

        public double subjectTotalAverage(int _i)
        {
            // find the total average of a subject and return it (based on index positions)
            double total = 0;
            foreach (Student s in Students)
            {
                total += s.Scores[_i];
            }
            return total / Students.Count();
        }
        public void displayStudentScore()
        {
            // use a LINQ statement to display students in order of their averages
            var filtered = from s in Students
                           orderby studentTotalAverage(s)
                           select s;

            foreach (var item in filtered)
            {
                Console.Write(item.FirstName + " - " + studentTotalAverage(item) + "; ");
            }
        }
        public void displaySubjectScore()
        {
            // find and display the subjects with their averages
            for (int i = 0; i < Student.Subjects.Count(); i++)
            {
                Console.Write(Student.Subjects[i] + " - " + subjectTotalAverage(i) + "; ");
            }
        }
        public void displayMinMaxStudent()
        {
            // find and display the lowest and highest average students and display their averages
            double lowest = 100;
            Student low = Students[0];
            double highest = 0;
            Student high = Students[0];
            foreach (Student s in Students)
            {
                double average = studentTotalAverage(s);
                if (average < lowest)
                {
                    lowest = average;
                    low = s;
                }
                if (average > highest)
                {
                    highest = average;
                    high = s;
                }
            }
            Console.WriteLine("Lowest Score: " + low.FirstName + " - " + lowest);
            Console.WriteLine("Highest Score: " + high.FirstName + " - " + highest);

        }
        public void displayMinMaxSubject()
        {
            // find the lowest and highest mark in each subject and display the students and marks
            for (int i = 0; i < Student.Subjects.Count(); i++)
            {
                double lowest = 100;
                Student low = Students[0];
                double highest = 0;
                Student high = Students[0];
                foreach (Student s in Students)
                {
                    double grade = s.Scores[i];
                    if (grade < lowest)
                    {
                        lowest = grade;
                        low = s;
                    }
                    if (grade > highest)
                    {
                        highest = grade;
                        high = s;
                    }
                }
                Console.WriteLine(Student.Subjects[i] + ": Highest Score - " 
                    + high.FirstName + "(" + highest + ")");
                Console.WriteLine(Student.Subjects[i] + ": Lowest Score - "
                    + low.FirstName + "(" + lowest + ")");
            }
        }
    }
}
