using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Students.StudentInLanguages.AddUseCase.Models;
using Prohix.Application.Services.Students.StudentInLanguages.AddUseCase;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Prohix.Application.Services.Students.StudentInLanguages.AddUseCase
{
    public class StudentInLanguageAddUseCase : IStudentInLanguageAddUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly IStudentInLanguageRepository _studentInLanguageRepository;

        public StudentInLanguageAddUseCase(

            IUserInformationProvider userInformationProvider,
            IStudentInLanguageRepository studentInLanguageRepository,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _studentInLanguageRepository = studentInLanguageRepository;
            _mapper = mapper;
        }

        public async Task<StudentInLanguageAddOutputModel> AddStudentInLanguage(StudentInLanguageAddInputModel inputModel)
        {
            var newStudentInLanguage = _mapper.Map<StudentInLanguage>(inputModel);

            inputModel.CreatedTime = DateTime.Now.Date;
            inputModel.StudentId = userInformationProvider.CurrentUserId;

            await _studentInLanguageRepository.AddAsync(newStudentInLanguage);

            var result = _studentInLanguageRepository.SaveChanges();
            if (result > 0)
                return new StudentInLanguageAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<StudentInLanguageAddOutputModelFields>(newStudentInLanguage)
                };

            return new StudentInLanguageAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}