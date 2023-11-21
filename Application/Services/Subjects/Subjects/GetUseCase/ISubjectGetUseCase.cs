using Prohix.Core.Entities.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Subjects.Subjects.GetUseCase
{
    public interface ISubjectGetUseCase
    {
      IQueryable<Subject> GetSubject(); 
    }
}