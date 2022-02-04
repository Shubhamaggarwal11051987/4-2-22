using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApi.Models
{
    public interface IStudent
    {
        Student AddStudent(Student student);
        List<Student> GetStudents();
        bool DeleteStudent(int id);
        Student StudentGetById(int id);
        Student UpdateStudent(Student student);
    }
}
