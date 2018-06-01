using MmosCourseProject.DAL;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.BLL.Services.DomainConstraintsValidatiotors
{
    internal class TeamConstraintsValidator : IDomainConstraintsValidator<Team>
    {
        public TeamConstraintsValidator()
        {
        }

        public void ValidateDomainConstraints(Team entity, IUnitOfWork uow)
        {
            //TODO продумать ограничения
        }
    }
}