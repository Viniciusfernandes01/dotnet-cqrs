using GymLive.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GymLive.Application.Queries.GetStudents
{
    public class GetStudentQueryHandler : IRequestHandler<GetStudentQuery, List<GetStudentViewModel>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<List<GetStudentViewModel>> Handle(GetStudentQuery request, CancellationToken cancellationToken)
        {
            var students = _studentRepository.GetAll();
            var getStudentsViewModelList = students.Select(s => new GetStudentViewModel(s.FullName))
                .ToList();
            return Task.FromResult(getStudentsViewModelList);
        }
    }
}
