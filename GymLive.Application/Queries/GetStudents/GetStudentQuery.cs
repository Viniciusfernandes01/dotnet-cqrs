using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLive.Application.Queries.GetStudents
{
    public class GetStudentQuery : IRequest<List<GetStudentViewModel>>
    {
    }
}
