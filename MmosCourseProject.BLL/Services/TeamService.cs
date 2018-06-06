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

namespace MmosCourseProject.BLL.Services
{
    public class TeamService : GenericService<Dto.Parameters.Selectional.TeamDto, Team>, ITeamService
    {
        public TeamService(IUnitOfWorkFactory ouwFactory) : base(ouwFactory) { }

        public ITeamSelectService Get => throw new NotImplementedException();

        public Dto.General.TeamDto CreateTeam(Dto.Parameters.Creational.TeamDto team)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeam(Dto.Parameters.Selectional.TeamDto team)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserFromTeam(Dto.Parameters.Selectional.UserDto user, Dto.Parameters.Selectional.TeamDto team)
        {
            throw new NotImplementedException();
        }

        public void InviteUserToTeam(Dto.Parameters.Selectional.TeamDto team, string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}
