using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double[] Scores { get; set; }
        public static string[] Subjects = new string[5] {"Math", "Biology", "Chemistry", "English", "History"};

        public Student(int _id, string _fName, string _lName, double[] _scores)
        {
            ID = _id;
            FirstName = _fName;
            LastName = _lName;
            Scores = _scores;
        }
    }
}
