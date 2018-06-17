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
        private ITeamSelectService _teamSelectService;

        public TeamService(IUnitOfWorkFactory ouwFactory) : base(ouwFactory) { }

        public ITeamSelectService Get
        {
            get
            {
                if (_teamSelectService == null)
                    _teamSelectService = new TeamSelectService(_unitOfWorkFactory);
                return _teamSelectService;
            }
        }

        public void CreateTeam(Dto.Parameters.Creational.TeamDto team)
        {
            Execute.NonQuery(uow => uow.Repository<ITeamRepository>().Create(team.MapToDbEntity()));
        }

        public void DeleteTeam(Dto.Parameters.Selectional.TeamDto team)
        {
            Execute.NonQuery(uow => uow.Repository<ITeamRepository>().Delete(team.MapToDbEntity()));
        }

        public void DeleteUserFromTeam(Dto.Parameters.Selectional.UserDto user, Dto.Parameters.Selectional.TeamDto team)
        {
            Execute.NonQuery(uow => uow.Repository<IUserTeamRepository>().Delete(new UserTeam() { User_Id = user.Id, Team_Id = team.Id }));
        }

        public void InviteUserToTeam(Dto.Parameters.Selectional.TeamDto team, string userEmail)
        {
            Execute.NonQuery(uow =>
            {
                var user = uow.Repository<IUserRepository>().GetFirst(u => u.Email == userEmail);
                uow.Repository<IUserTeamRepository>().Create(new UserTeam() { User_Id = user.Id, Team_Id = team.Id });
            });
        }
    }
}
