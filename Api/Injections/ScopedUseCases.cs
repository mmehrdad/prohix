using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Prohix.Application.Services.Commons.Countries.AddUseCase;
using Prohix.Application.Services.Commons.Countries.DeleteUseCase;
using Prohix.Application.Services.Commons.Countries.GetUseCase;
using Prohix.Application.Services.Commons.Countries.UpdateUseCase;
using Prohix.Application.Services.Commons.FieldOfStudies.AddUseCase;
using Prohix.Application.Services.Commons.FieldOfStudies.DeleteUseCase;
using Prohix.Application.Services.Commons.FieldOfStudies.GetUseCase;
using Prohix.Application.Services.Commons.FieldOfStudies.UpdateUseCase;
using Prohix.Application.Services.Commons.GradeOfStudies.AddUseCase;
using Prohix.Application.Services.Commons.GradeOfStudies.DeleteUseCase;
using Prohix.Application.Services.Commons.GradeOfStudies.GetUseCase;
using Prohix.Application.Services.Commons.GradeOfStudies.UpdateUseCase;
using Prohix.Application.Services.Commons.Languages.AddUseCase;
using Prohix.Application.Services.Commons.Languages.DeleteUseCase;
using Prohix.Application.Services.Commons.Languages.GetUseCase;
using Prohix.Application.Services.Commons.Languages.UpdateUseCase;
using Prohix.Application.Services.Commons.Publics.EmailService;
using Prohix.Application.Services.Commons.Universities.AddUseCase;
using Prohix.Application.Services.Commons.Universities.DeleteUseCase;
using Prohix.Application.Services.Commons.Universities.GetUseCase;
using Prohix.Application.Services.Commons.Universities.UpdateUseCase;
using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Proposals.ProposalInSubjects.AddUseCase;
using Prohix.Application.Services.Proposals.ProposalInSubjects.DeleteUseCase;
using Prohix.Application.Services.Proposals.ProposalInSubjects.GetUseCase;
using Prohix.Application.Services.Proposals.ProposalInSubjects.UpdateUseCase;
using Prohix.Application.Services.Proposals.Proposals.AddUseCase;
using Prohix.Application.Services.Proposals.Proposals.DeleteUseCase;
using Prohix.Application.Services.Proposals.Proposals.GetUseCase;
using Prohix.Application.Services.Proposals.Proposals.UpdateUseCase;
using Prohix.Application.Services.Proposals.ProposalStatuses.AddUseCase;
using Prohix.Application.Services.Proposals.ProposalStatuses.DeleteUseCase;
using Prohix.Application.Services.Proposals.ProposalStatuses.GetUseCase;
using Prohix.Application.Services.Proposals.ProposalStatuses.UpdateUseCase;
using Prohix.Application.Services.Students.Account.ConfirmEmail;
using Prohix.Application.Services.Students.Account.ForgotPassword;
using Prohix.Application.Services.Students.Account.Login;
using Prohix.Application.Services.Students.Account.Register;
using Prohix.Application.Services.Students.Account.ResetPassword;
using Prohix.Application.Services.Students.Educations.AddUseCase;
using Prohix.Application.Services.Students.Educations.DeleteUseCase;
using Prohix.Application.Services.Students.Educations.GetUseCase;
using Prohix.Application.Services.Students.Educations.UpdateUseCase;
using Prohix.Application.Services.Students.Jobs.AddUseCase;
using Prohix.Application.Services.Students.Jobs.DeleteUseCase;
using Prohix.Application.Services.Students.Jobs.GetUseCase;
using Prohix.Application.Services.Students.Jobs.UpdateUseCase;
using Prohix.Application.Services.Students.Payments.AddUseCase;
using Prohix.Application.Services.Students.Payments.DeleteUseCase;
using Prohix.Application.Services.Students.Payments.GetUseCase;
using Prohix.Application.Services.Students.Payments.UpdateUseCase;
using Prohix.Application.Services.Students.StudentInLanguages.AddUseCase;
using Prohix.Application.Services.Students.StudentInLanguages.DeleteUseCase;
using Prohix.Application.Services.Students.StudentInLanguages.GetUseCase;
using Prohix.Application.Services.Students.StudentInLanguages.UpdateUseCase;
using Prohix.Application.Services.Students.Students.AddUseCase;
using Prohix.Application.Services.Students.Students.DeleteUseCase;
using Prohix.Application.Services.Students.Students.GetUseCase;
using Prohix.Application.Services.Students.Students.UpdateUseCase;
using Prohix.Application.Services.Subjects.Subjects.AddUseCase;
using Prohix.Application.Services.Subjects.Subjects.DeleteUseCase;
using Prohix.Application.Services.Subjects.Subjects.GetUseCase;
using Prohix.Application.Services.Subjects.Subjects.UpdateUseCase;
using Prohix.Application.Services.Teachers.Account.ConfirmEmail;
using Prohix.Application.Services.Teachers.Account.ForgotPassword;
using Prohix.Application.Services.Teachers.Account.Register;
using Prohix.Application.Services.Teachers.Account.ResetPassword;
using Prohix.Application.Services.Teachers.TeacherInProposals.AddUseCase;
using Prohix.Application.Services.Teachers.TeacherInProposals.DeleteUseCase;
using Prohix.Application.Services.Teachers.TeacherInProposals.GetUseCase;
using Prohix.Application.Services.Teachers.TeacherInProposals.UpdateUseCase;
using Prohix.Application.Services.Teachers.TeacherInSubjects.AddUseCase;
using Prohix.Application.Services.Teachers.TeacherInSubjects.DeleteUseCase;
using Prohix.Application.Services.Teachers.TeacherInSubjects.GetUseCase;
using Prohix.Application.Services.Teachers.TeacherInSubjects.UpdateUseCase;
using Prohix.Application.Services.Teachers.TeacherInUniversities.AddUseCase;
using Prohix.Application.Services.Teachers.TeacherInUniversities.DeleteUseCase;
using Prohix.Application.Services.Teachers.TeacherInUniversities.GetUseCase;
using Prohix.Application.Services.Teachers.TeacherInUniversities.UpdateUseCase;
using Prohix.Application.Services.Teachers.Teachers.AddUseCase;
using Prohix.Application.Services.Teachers.Teachers.DeleteUseCase;
using Prohix.Application.Services.Teachers.Teachers.GetUseCase;
using Prohix.Application.Services.Teachers.Teachers.UpdateUseCase;
using Prohix.Core.Entities.Students;
using Prohix.Core.Entities.Teachers;
using Prohix.Infrastracture.Repositories.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;

namespace Prohix.Api.Injections
{
    public static class ScopedUseCases
    {
        internal static void RegisterUseCases(this IServiceCollection services)
        {
            #region Common //--------------------------------------------
            services.AddScoped<IUserInformationProvider, UserInformationProvider>();
            services.AddScoped<IHttpRequestInfo, HttpRequestInfo>();
            services.AddScoped<IEmailService, EmailService>();
            //services.AddScoped<UserManager<Teacher>, UserManager<Teacher>>();
            //services.AddScoped<IUserStore<Teacher>, UserStore<Teacher>;
            // services.AddScoped< HttpContext>();

            services.AddScoped<ICountryAddUseCase, CountryAddUseCase>();
            services.AddScoped<ICountryDeleteUseCase, CountryDeleteUseCase>();
            services.AddScoped<ICountryGetUseCase, CountryGetUseCase>();
            services.AddScoped<ICountryUpdateUseCase, CountryUpdateUseCase>();

            services.AddScoped<IFieldOfStudyAddUseCase, FieldOfStudyAddUseCase>();
            services.AddScoped<IFieldOfStudyDeleteUseCase, FieldOfStudyDeleteUseCase>();
            services.AddScoped<IFieldOfStudyGetUseCase, FieldOfStudyGetUseCase>();
            services.AddScoped<IFieldOfStudyUpdateUseCase, FieldOfStudyUpdateUseCase>();

            services.AddScoped<IGradeOfStudyAddUseCase, GradeOfStudyAddUseCase>();
            services.AddScoped<IGradeOfStudyDeleteUseCase, GradeOfStudyDeleteUseCase>();
            services.AddScoped<IGradeOfStudyGetUseCase, GradeOfStudyGetUseCase>();
            services.AddScoped<IGradeOfStudyUpdateUseCase, GradeOfStudyUpdateUseCase>();

            services.AddScoped<ILanguageAddUseCase, LanguageAddUseCase>();
            services.AddScoped<ILanguageDeleteUseCase, LanguageDeleteUseCase>();
            services.AddScoped<ILanguageGetUseCase, LanguageGetUseCase>();
            services.AddScoped<ILanguageUpdateUseCase, LanguageUpdateUseCase>();

            services.AddScoped<IUniversityAddUseCase, UniversityAddUseCase>();
            services.AddScoped<IUniversityDeleteUseCase, UniversityDeleteUseCase>();
            services.AddScoped<IUniversityGetUseCase, UniversityGetUseCase>();
            services.AddScoped<IUniversityUpdateUseCase, UniversityUpdateUseCase>();

            services.AddScoped<IProposalInSubjectAddUseCase, ProposalInSubjectAddUseCase>();
            services.AddScoped<IProposalInSubjectDeleteUseCase, ProposalInSubjectDeleteUseCase>();
            services.AddScoped<IProposalInSubjectGetUseCase, ProposalInSubjectGetUseCase>();
            services.AddScoped<IProposalInSubjectUpdateUseCase, ProposalInSubjectUpdateUseCase>();
            services.AddScoped<IProposalAddUseCase, ProposalAddUseCase>();
            services.AddScoped<IProposalDeleteUseCase, ProposalDeleteUseCase>();
            services.AddScoped<IProposalGetUseCase, ProposalGetUseCase>();
            services.AddScoped<IProposalUpdateUseCase, ProposalUpdateUseCase>();
            services.AddScoped<IProposalStatusAddUseCase, ProposalStatusAddUseCase>();
            services.AddScoped<IProposalStatusDeleteUseCase, ProposalStatusDeleteUseCase>();
            services.AddScoped<IProposalStatusGetUseCase, ProposalStatusGetUseCase>();
            services.AddScoped<IProposalStatusUpdateUseCase, ProposalStatusUpdateUseCase>();

            services.AddScoped<IEducationAddUseCase, EducationAddUseCase>();
            services.AddScoped<IEducationDeleteUseCase, EducationDeleteUseCase>();
            services.AddScoped<IEducationGetUseCase, EducationGetUseCase>();
            services.AddScoped<IEducationUpdateUseCase, EducationUpdateUseCase>();

            services.AddScoped<IJobAddUseCase, JobAddUseCase>();
            services.AddScoped<IJobDeleteUseCase, JobDeleteUseCase>();
            services.AddScoped<IJobGetUseCase, JobGetUseCase>();
            services.AddScoped<IJobUpdateUseCase, JobUpdateUseCase>();

            services.AddScoped<IPaymentAddUseCase, PaymentAddUseCase>();
            services.AddScoped<IPaymentDeleteUseCase, PaymentDeleteUseCase>();
            services.AddScoped<IPaymentGetUseCase, PaymentGetUseCase>();
            services.AddScoped<IPaymentUpdateUseCase, PaymentUpdateUseCase>();

            services.AddScoped<IStudentInLanguageAddUseCase, StudentInLanguageAddUseCase>();
            services.AddScoped<IStudentInLanguageDeleteUseCase, StudentInLanguageDeleteUseCase>();
            services.AddScoped<IStudentInLanguageGetUseCase, StudentInLanguageGetUseCase>();
            services.AddScoped<IStudentInLanguageUpdateUseCase, StudentInLanguageUpdateUseCase>();
            services.AddScoped<IStudentAddUseCase, StudentAddUseCase>();
            services.AddScoped<IStudentDeleteUseCase, StudentDeleteUseCase>();
            services.AddScoped<IStudentGetUseCase, StudentGetUseCase>();
            services.AddScoped<IStudentUpdateUseCase, StudentUpdateUseCase>();
            services.AddScoped<IStudentRegisterUseCase, StudentRegisterUseCase>();
            services.AddScoped<IStudentConfirmEmailUseCase, StudentConfirmEmailUseCase>();
            services.AddScoped<IStudentForgotPasswordUseCase, StudentForgotPasswordUseCase>();
            services.AddScoped<IStudentResetPasswordUseCase, StudentResetPasswordUseCase>();
            services.AddScoped<IStudentLoginUseCase, StudentLoginUseCase>();


            services.AddScoped<ISubjectAddUseCase, SubjectAddUseCase>();
            services.AddScoped<ISubjectDeleteUseCase, SubjectDeleteUseCase>();
            services.AddScoped<ISubjectGetUseCase, SubjectGetUseCase>();

            services.AddScoped<ISubjectUpdateUseCase, SubjectUpdateUseCase>();
            services.AddScoped<ITeacherInProposalAddUseCase, TeacherInProposalAddUseCase>();
            services.AddScoped<ITeacherInProposalDeleteUseCase, TeacherInProposalDeleteUseCase>();
            services.AddScoped<ITeacherInProposalGetUseCase, TeacherInProposalGetUseCase>();
            services.AddScoped<ITeacherInProposalUpdateUseCase, TeacherInProposalUpdateUseCase>();
            services.AddScoped<ITeacherInSubjectAddUseCase, TeacherInSubjectAddUseCase>();
            services.AddScoped<ITeacherInSubjectDeleteUseCase, TeacherInSubjectDeleteUseCase>();
            services.AddScoped<ITeacherInSubjectGetUseCase, TeacherInSubjectGetUseCase>();
            services.AddScoped<ITeacherInSubjectUpdateUseCase, TeacherInSubjectUpdateUseCase>();
            services.AddScoped<ITeacherInUniversityAddUseCase, TeacherInUniversityAddUseCase>();
            services.AddScoped<ITeacherInUniversityDeleteUseCase, TeacherInUniversityDeleteUseCase>();
            services.AddScoped<ITeacherInUniversityGetUseCase, TeacherInUniversityGetUseCase>();
            services.AddScoped<ITeacherInUniversityUpdateUseCase, TeacherInUniversityUpdateUseCase>();
            services.AddScoped<ITeacherAddUseCase, TeacherAddUseCase>();
            services.AddScoped<ITeacherDeleteUseCase, TeacherDeleteUseCase>();
            services.AddScoped<ITeacherGetUseCase, TeacherGetUseCase>();
            services.AddScoped<ITeacherUpdateUseCase, TeacherUpdateUseCase>();
            services.AddScoped<ITeacherRegisterUseCase, TeacherRegisterUseCase>();
            services.AddScoped<ITeacherConfirmEmailUseCase, TeacherConfirmEmailUseCase>();
            services.AddScoped<ITeacherForgotPasswordUseCase, TeacherForgotPasswordUseCase>();
            services.AddScoped<ITeacherResetPasswordUseCase, TeacherResetPasswordUseCase>();

            #endregion

        }
    }
}
