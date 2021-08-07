using GymLive.Domain.Entities;
using System.Collections.Generic;

namespace GymLive.Domain.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        List<Student> GetAll();
    }
}
