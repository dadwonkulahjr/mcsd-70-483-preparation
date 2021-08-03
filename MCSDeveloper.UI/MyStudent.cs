using System.Collections.Generic;

namespace MCSDeveloper
{
    public class MyStudent
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CourseId { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public MyStudent(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public MyStudent(int studentId, string firstName, string lastName)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
        }
        public MyStudent(int studentId, string firstName, string lastName, int courseId)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            CourseId = courseId;
        }
        public MyStudent()
        {
            StudentId = 0;
            FirstName = "Hello";
            LastName = "World";
            CourseId = 0;
        }

        public static IEnumerable<MyStudent> Students
        {
            get
            {
                List<MyStudent> myStudents = new();
                myStudents.Add(new(101, "Tim", "Corey", 1));
                myStudents.Add(new(102, "Sara", "Collins", 3));
                myStudents.Add(new(103, "Carr", "Roberts", 2));
                myStudents.Add(new(104, "Ben", "Wess", 5));
                myStudents.Add(new(105, "Rose", "Roberson", 2));
                myStudents.Add(new(106, "Cath", "Lawerence", 5));
                myStudents.Add(new(107, "Dan", "Keyne", 1));
                myStudents.Add(new(108, "Denise", "Walker", 3));
                myStudents.Add(new(109, "Zara", "Kay", 5));
                myStudents.Add(new(110, "Win", "Henry", 1));
                myStudents.Add(new(111, "Fred", "Mogreah", 3));
                myStudents.Add(new(112, "Hellen", "Kone", 2));
                myStudents.Add(new(113, "Jay", "Jemel", 1));
                myStudents.Add(new(114, "Cath", "Lawerence", 5));
                myStudents.Add(new(115, "Kellen", "Queen", 2));
                myStudents.Add(new(116, "Henry", "Walkson", 5));
                return myStudents;
            }
        }
    }
}
