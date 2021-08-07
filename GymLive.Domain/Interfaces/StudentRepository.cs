using GymLive.Domain.Entities;
using GymLive.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace GymLive.Infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public void Add(Student student)
        {
            
        }

        public List<Student> GetAll()
        {
            return new List<Student>
            {
                new Student("bebeto", DateTime.Now)
            };
        }
    }
}
