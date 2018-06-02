using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL;
using MmosCourseProject.DAL.Abstract;
using MmosCourseProject.BLL.Utils.DomainModelValidation;

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

            DomainModelValidator<IUnitOfWork>.Configure(cfg => {
                cfg.ConfigureOnCreate(rulesSet =>
                {
                    rulesSet.AddValidationRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null);


                    rulesSet.AddValidationRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null);
                    rulesSet.AddValidationRule<Channel>((channel, uow) => uow.ChannelRepository.GetById(channel.Id) == null);
                });
                cfg.ConfigureOnUpdate(rulesSet => { });
            });
        }
    }
}
