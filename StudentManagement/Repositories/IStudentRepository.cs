using StudentManagement.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Repositories
{
    interface IStudentRepository
    {
        List<Student> GetStudents();
    }
}
