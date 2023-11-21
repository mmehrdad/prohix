using Prohix.Application.Services.Students.Students.GetUseCase;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Students.GetUseCase
{
    public class StudentGetUseCase : IStudentGetUseCase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentGetUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public IQueryable<Student> GetStudent()
        {
            var result = _studentRepository.GetAllAsNoTracking();
            return result;
        }
        public async Task< Student> Get_Student_By_Id(Guid Id)
        {
            var result = await _studentRepository.Get_By_StudentId(Id);
            return result;
        }
    }
}