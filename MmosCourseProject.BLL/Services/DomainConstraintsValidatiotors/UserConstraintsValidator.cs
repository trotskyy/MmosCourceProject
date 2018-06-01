using MmosCourseProject.DAL;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.BLL.Services.DomainConstraintsValidatiotors
{
    internal class UserConstraintsValidator : IDomainConstraintsValidator<User>
    {
        public UserConstraintsValidator()
        {
        }

        public void ValidateDomainConstraints(User entity, IUnitOfWork uow)
        {
            //TODO продумать ограничения
        }
    }
}