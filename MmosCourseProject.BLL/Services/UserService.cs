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
            throw new NotImplementedException();
        }

        public int CreateAccount(Dto.Parameters.Creational.UserDto user)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(Dto.Parameters.Selectional.UserDto user)
        {
            throw new NotImplementedException();
        }

        public void EditBio(Dto.Parameters.Updational.UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
