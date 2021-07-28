using System.Collections.Generic;

namespace MCSDeveloper
{
    public interface IStudent
    {
        IEnumerable<Student> Get();
        Student GetStudent(int id);
        Student Remove(int id);
        Student Update(Student stduentToUpdate);
        void Add(Student newStudent);
        int TotalStudentCount { get; }
        List<Student> Search(string name);
        Student SearchSingle(string name);


    }
}
