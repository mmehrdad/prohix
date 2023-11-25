using Prohix.Infrastracture.Repositories.Commons;
using Prohix.Infrastracture.Repositories.Identity;
using Prohix.Infrastracture.Repositories.Proposals;
using Prohix.Infrastracture.Repositories.Students;
using Prohix.Infrastracture.Repositories.Subjects;
using Prohix.Infrastracture.Repositories.Teachers;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Identity;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Subjects;
using Prohix.Infrastracture.RepositoryInterfaces.Teachers;

namespace Prohix.Api.Injections
{
    public static class ScopedRepositories
    {
        public static void RegisterScopeds(this IServiceCollection services)
        {
            RegisterRepositories(services);
            ScopedUseCases.RegisterUseCases(services);
        }
        static void RegisterRepositories(this IServiceCollection services)
        {
            #region Common //--------------------------------------------
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IUniversityRepository, UniversityRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<IGradeOfStudyRepository, GradeOfStudyRepository>();
            services.AddScoped<IFieldOfStudyRepository, FieldOfStudyRepository>();
            #endregion
            #region Identity //--------------------------------------------
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion
            #region Proposal //--------------------------------------------
            services.AddScoped<IProposalInSubjectRepository, ProposalInSubjectRepository>();
            services.AddScoped<IProposalRepository, ProposalRepository>();
            services.AddScoped<IProposalStatusRepository, ProposalStatusRepository>();

            #endregion
            #region Student //--------------------------------------------
            services.AddScoped<IEducationRepository, EducationRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IStudentInLanguageRepository, StudentInLanguageRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();

            #endregion
            #region Teacher //--------------------------------------------
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<ITeacherInProposalRepository, TeacherInProposalRepository>();
            services.AddScoped<ITeacherInSubjectRepository, TeacherInSubjectRepository>();
            services.AddScoped<ITeacherInUniversityRepository, TeacherInUniversityRepository>();

            #endregion
            #region Subject //--------------------------------------------
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            

            #endregion
        }
    }
}
