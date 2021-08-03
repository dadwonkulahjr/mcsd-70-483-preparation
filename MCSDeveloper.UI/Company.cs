using System;
using System.Collections.Generic;

namespace MCSDeveloper.UI
{
    public record Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Salary { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public Company(int id, string name, Gender? gender)
        {
            Id = id;
            Name = name;
            Gender = gender;
        }
        public Company(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Company(int id, string name, decimal? salary, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            Salary = salary;
            DateOfBirth = dateOfBirth;
        }
        public Company(int id, string name, Gender? gender, DateTime? dateOfBirth)
        {
            Id = id;
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }
        public Company()
        {
            Id = 17019;
            Name = "Hello,World!";
            Salary = 450000;
            Gender = UI.Gender.Male;
            DateOfBirth = new(1996, 5, 2);
        }
        public Company(int id, string name, decimal? salary, Gender? gender)
        {
            Name = name;
            Salary = salary;
            Gender = gender;
            Id = id;
        }
        public static List<Company> Companies
        {
            get
            {
                return new List<Company>()
                {
                    new(id:105,name:"Test",gender:UI.Gender.Unknown,dateOfBirth:new(1988, 5, 02)),
                    new(id:104,name:"Mike",salary:3500,dateOfBirth:new(1977, 10, 18)),
                    new(id:102,name:"Sara", salary:14000, gender:UI.Gender.Female, new(1988,3,2)),
                    new(id:103,name:"Rose", salary:2000,gender:UI.Gender.Female,new(1977, 2, 9)),
                    new(id:101,name:"James",gender:UI.Gender.Male),
                    new(id:107,name:"Test2",gender:UI.Gender.Unknown),
                    new(id:108,name:"Alex",gender:UI.Gender.Male),
                    new(id:111,name:"Ben",gender:UI.Gender.Male),
                    new(id:110,name:"Carr",gender:UI.Gender.Male)
                };
            }
        }
        public Company(int id, string name, decimal? salary, DateTime? dateOfBirth)
        {
            Id = id;
            Name = name;
            Salary = salary;
            DateOfBirth = dateOfBirth;
        }
        public Company(int id, string name, decimal? salary, Gender? gender, DateTime? dateOfBirth)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"Id: {(Id == 0 ? "No Id" : Id)}\nName: {(Name == null ? "No name" : Name)}\nSalary: {(Salary == null ? "No salary assigned." : Salary.Value.ToString("c"))}\ndob: {(DateOfBirth == null ? "No dob assigned yet" : DateOfBirth.Value.ToLongDateString())}\nGender: {(Gender == null ? "No gender assigned." : Gender)}";
        }
    }
}
