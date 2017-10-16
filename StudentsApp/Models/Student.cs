namespace StudentsApp.Models
{
    public class Student : IStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Student(int id, string lname, string fname, int age, string gender)
        {
            Id = id;
            LastName = lname;
            FirstName = fname;
            Age = age;
            Gender = gender;
        }
    }
}
