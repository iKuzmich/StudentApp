using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.Models
{
    public interface IStudent
    {
         int Id { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }
         int Age { get; set; }
         string Gender { get; set; }
    }
}
