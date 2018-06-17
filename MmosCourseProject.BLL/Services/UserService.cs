using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Services.Abstract;
using MmosCourseProject.DAL;
using MmosCourseProject.BLL.Utils;
using MmosCourseProject.DAL.Abstract;
using MmosCourseProject.BLL.Dto.Parameters.Creational;
using MmosCourseProject.BLL.Dto.Parameters.Selectional;
using MmosCourseProject.BLL.Dto.Parameters.Updational;

namespace MmosCourseProject.BLL.Services
{
    public class UserService : GenericService<Dto.Parameters.Selectional.UserDto, User>, IUserService
    {
        public UserService(IUnitOfWorkFactory ouwFactory) : base(ouwFactory) { }

        public bool AreEmailAndPasswordValid(string email, string password)
        {
            var hash = CalculatePasswordHash(password);
            var user = Execute.Select(uow => uow.Repository<IUserRepository>().GetFirst(u => u.Email == email && u.PasswordHash == hash));
            return user != null;
        }

        public int CreateAccount(Dto.Parameters.Creational.UserDto user)
        {
            var createUser = user.MapToDbEntity();
            Execute.NonQuery(uow => uow.Repository<IUserRepository>().Create(createUser));
            return createUser.Id;
        }

        public void DeleteAccount(Dto.Parameters.Selectional.UserDto user)
        {
            Execute.NonQuery(uow => uow.Repository<IUserRepository>().Delete(user.MapToDbEntity()));
        }

        public void EditBio(Dto.Parameters.Updational.UserDto user)
        {
            Execute.NonQuery(uow => uow.Repository<IUserRepository>().Update(user.MapToDbEntity()));
        }

        private string CalculatePasswordHash(string password)
        {
            return string.Empty;
        }
    }
}
