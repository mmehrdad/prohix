using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Students.Students.AddUseCase.Models;
using Prohix.Application.Services.Students.Students.AddUseCase;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Azure.Core;
using System.Text.Encodings.Web;

namespace Prohix.Application.Services.Students.Students.AddUseCase
{
    public class StudentAddUseCase : IStudentAddUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;

        public StudentAddUseCase(

            IUserInformationProvider userInformationProvider,
            IStudentRepository studentRepository,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<StudentAddOutputModel> AddStudent(StudentAddInputModel inputModel)
        {
            var newStudent = _mapper.Map<Student>(inputModel);
            var user = _mapper.Map<IdentityUser>(inputModel);

            await _studentRepository.AddAsync(newStudent);
            

            var result = _studentRepository.SaveChanges();
            if (result > 0)
                return new StudentAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<StudentAddOutputModelFields>(newStudent)
                };

            return new StudentAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}