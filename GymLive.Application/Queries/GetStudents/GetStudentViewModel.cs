using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLive.Application.Queries.GetStudents
{
    public class GetStudentViewModel
    {
        public GetStudentViewModel(string fullName)
        {
            FullName = fullName;
        }

        public string FullName { get; set; }
    }
}
