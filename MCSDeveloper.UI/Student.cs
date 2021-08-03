using System;
using System.Collections.Generic;
using System.Linq;

namespace MCSDeveloper
{
    public class Student : EventArgs, IStudent
    {
        private List<Student> _listOfStudent;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return string.Concat(FirstName + " " + LastName);
            }

        }
        public Student()
        {
            _listOfStudent = new(GetStudents);
        }
        public Student(string firstName, string lastName, int id = 0)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        private static IEnumerable<Student> GetStudents
        {
            get
            {
                return new List<Student>()
                {
                    new(id:1, firstName:"Tom", lastName:"Smiath"),
                    new(id:2, firstName:"Mike", lastName:"George"),
                    new(id : 3, firstName : "Sara", lastName : "Collins"),
                    new(id : 4, firstName : "Tim", lastName : "Roberts"),
                    new(id : 5, firstName : "Sharon", lastName : "Wah"),
                    new(id : 6, firstName : "Michael", lastName : "Doe"),
                    new(id : 7, firstName : "New", lastName : "User"),
                };
            }
        }
        public int TotalStudentCount
        {
            get
            {
                return _listOfStudent.Count;
            }
        }
        public IEnumerable<Student> Get()
        {
            return _listOfStudent.ToList();
        }
        public Student GetStudent(int id)
        {
            return _listOfStudent.FirstOrDefault(s => s.Id == id);
        }
        public Student Remove(int id)
        {
            var findStudent = _listOfStudent.FirstOrDefault(s => s.Id == id);
            if (findStudent != null)
            {
                _listOfStudent.Remove(findStudent);
                return findStudent;
            }

            return null;
        }
        public Student Update(Student stduentToUpdate)
        {
            var findStudent = _listOfStudent.FirstOrDefault(s => s.Id == stduentToUpdate.Id);
            if (findStudent != null)
            {
                findStudent.FirstName = stduentToUpdate.FirstName;
                findStudent.LastName = stduentToUpdate.LastName;
                return findStudent;
            }
            return null;
        }
        public List<Student> Search(string name)
        {
            var listSearch = _listOfStudent.ToList().FindAll(s => s.FullName.Contains(name));
            if (listSearch != null)
            {
                return listSearch;
            }
            return _listOfStudent.ToList();
        }
        public Student SearchSingle(string name)
        {
            return _listOfStudent.ToList().Find(s => s.FullName.Contains(name));
        }
        public void Add(Student newStudent)
        {
            if (_listOfStudent != null)
            {
                newStudent.Id = _listOfStudent.Max(s => s.Id) + 1;
                _listOfStudent.Add(newStudent);
               
            }
        }
    }
}
