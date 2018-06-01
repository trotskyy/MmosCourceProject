using MmosCourseProject.DAL;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.BLL.Services.DomainConstraintsValidatiotors
{
    //stratagy pattern ConcreteBehavior
    internal class CommentConstraintsValidator : IDomainConstraintsValidator<Comment>
    {
        public CommentConstraintsValidator()
        {
        }
    }
}