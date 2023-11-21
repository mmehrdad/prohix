using Prohix.Application.Services.Commons.Countries.UpdateUseCase.Models;
using Prohix.Application.Services.Commons.Countries.UpdateUseCase;
using Prohix.Application.Services.Helper;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prohix.Application.Services.Commons.Universities.UpdateUseCase.Models;

namespace Prohix.Application.Services.Commons.Universities.UpdateUseCase
{
    public class UniversityUpdateUseCase : IUniversityUpdateUseCase
    {
        private readonly IMapper _mapper;
        private readonly IUniversityRepository _countryRepository;

        public UniversityUpdateUseCase(

            IUniversityRepository countryRepository,
            IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }
        public async Task<UniversityUpdateOutputModel> UpdateUniversity(UniversityUpdateInputModel inputModel)
        {
            var countryEntity = await _countryRepository.FindAsync(inputModel.Id);
            if (countryEntity == null)
                return new UniversityUpdateOutputModel { HasError = true, Message = "University not found !!" };

            var countryUpForUpdate = _mapper.Map<UniversityUpdateInputModel, University>(inputModel, countryEntity);

            await _countryRepository.UpdateAsync(countryUpForUpdate);

            var result = await _countryRepository.SaveChangesAsync();

            return result > 0 ? new UniversityUpdateOutputModel { OutputModelFields = _mapper.Map<UniversityUpdateOutputModelFields>(countryUpForUpdate) } :
                                new UniversityUpdateOutputModel { HasError = true, Message = "Somthing went wrong !!" };

        }
    }
}