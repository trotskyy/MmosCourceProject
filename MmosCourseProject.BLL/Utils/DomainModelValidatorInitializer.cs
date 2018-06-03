using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL;
using MmosCourseProject.DAL.EfProviders;
using MmosCourseProject.DAL.Abstract;
using DomainModelValidation;

namespace MmosCourseProject.BLL.Utils
{
    /// <summary>
    /// aka Domain Model Constraints Initializer
    /// </summary>
    public static class DomainModelValidatorInitializer
    {
        public static void InitializeDomainModelConstraints()
        {
            //TODO finish domain model validation logic


            //DomainModelValidator<IUnitOfWork>.Configure(cfg =>
            //{
            //    cfg.ConfigureOnCreate(ruleSet => {
            //        ruleSet.AddRule<Team>((team, uow) => {
            //            uow.TeamRepository.GetAll().con
            //        }).ThrowingException(new Exception())
            //        .Including()
            //        .Including()
            //        .ThrowingException()
            //    });
            //});

            //DomainModelValidator<T1>.Validate<T2>(new Team(), uow, ValidationType.OnCreate);

            //DomainModelValidator<IUnitOfWork>.Configure(cfg => {
            //    cfg.ConfigureOnCreate(ruleSet =>
            //    {
            //        ruleSet.AddRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null)
            //            .Including((user, uow) => true)
            //            .ThrowingException(new Exception())
            //            .Including((user, uow) => false);

            //        ruleSet.AddRule<Channel>((user, uow) => true)
            //            .ThrowingException(new ArgumentNullException());
            //    });
            //    cfg.ConfigureOnUpdate(rulesSet => { });
            //});

            //DomainModelValidator<IUnitOfWork>.Validate(new Channel(), new UnitOfWork(), ValidationType.OnCreate);
        }
    }
}
