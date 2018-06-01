using MmosCourseProject.DAL;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.BLL.Services.DomainConstraintsValidatiotors
{
    //stratagy pattern ConcreteBehavior

    internal class ChannelConstraintsValidator : IDomainConstraintsValidator<Channel>
    {
        public void ValidateDomainConstraints(Channel entity, IUnitOfWork uow)
        {
            throw new System.NotImplementedException();
        }
    }
}