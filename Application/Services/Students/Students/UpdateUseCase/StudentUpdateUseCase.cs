using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Students.Students.UpdateUseCase.Models;
using Prohix.Application.Services.Students.Students.UpdateUseCase;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Prohix.Application.Services.Students.Students.UpdateUseCase
{
    public class StudentUpdateUseCase : IStudentUpdateUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;

        public StudentUpdateUseCase(

            IUserInformationProvider userInformationProvider,
            IStudentRepository studentRepository,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public async Task<StudentUpdateOutputModel> UpdateStudent(StudentUpdateInputModel inputModel)
        {
            var studentEntity = await _studentRepository.FindAsync(inputModel.Id);
            if (studentEntity == null)
                return new StudentUpdateOutputModel { HasError = true, Message = "Student not found !!" };

            var studentUpForUpdate = _mapper.Map<StudentUpdateInputModel, Student>(inputModel, studentEntity);

            await _studentRepository.UpdateAsync(studentUpForUpdate);

            var result = await _studentRepository.SaveChangesAsync();

            return result > 0 ? new StudentUpdateOutputModel { OutputModelFields = _mapper.Map<StudentUpdateOutputModelFields>(studentUpForUpdate) } :
                                new StudentUpdateOutputModel { HasError = true, Message = "Somthing went wrong !!" };

        }
    }
}