using Prohix.Application.Services.Commons.Countries.AddUseCase.Models;
using Prohix.Application.Services.Commons.Countries.AddUseCase;
using Prohix.Application.Services.Helper;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prohix.Application.Services.Commons.Universities.AddUseCase.Models;

namespace Prohix.Application.Services.Commons.Universities.AddUseCase
{
    public class UniversityAddUseCase : IUniversityAddUseCase
    {
        private readonly IMapper _mapper;
        private readonly IUniversityRepository _universityRepository;

        public UniversityAddUseCase(

            IUniversityRepository universityRepository,
            IMapper mapper)
        {
            _universityRepository = universityRepository;
            _mapper = mapper;
        }

        public async Task<UniversityAddOutputModel> AddUniversity(UniversityAddInputModel inputModel)
        {
            var newUniversity = _mapper.Map<University>(inputModel);

            await _universityRepository.AddAsync(newUniversity);

            var result = _universityRepository.SaveChanges();
            if (result > 0)
                return new UniversityAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<UniversityAddOutputModelFields>(newUniversity)
                };

            return new UniversityAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}