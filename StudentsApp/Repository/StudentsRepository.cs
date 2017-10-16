using StudentsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.Repository
{
    public abstract class StudentsRepository
    {
        public abstract IList<IStudent> GetStudents();
        public abstract void AddStudent(IStudent student);
        public abstract void UpdateStudent(IStudent student);
        public abstract void DeleteStudent(IStudent student);
    }
}
