using System.Collections.Generic;

namespace MCSDeveloper
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }
        public Course()
        {
            CourseId = 101;
            CourseName = "Default Course!";
        }

        public static IEnumerable<Course> Courses
        {
            get
            {
                List<Course> listOfCourses = new();
                listOfCourses.Add(new(1, "Razor Pages"));
                listOfCourses.Add(new(2, "Mvc"));
                listOfCourses.Add(new(3, "DBM"));
                listOfCourses.Add(new(4, "Intro to Programming"));
                listOfCourses.Add(new(5, "Advanced Programming"));
                return listOfCourses;
            }
        }
    }
}
