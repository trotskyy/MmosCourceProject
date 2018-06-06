using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Services.Abstract;
using MmosCourseProject.DAL;
using MmosCourseProject.BLL.Utils;
using MmosCourseProject.BLL.DataStructures;
using MmosCourseProject.BLL.Dto.Parameters.Selectional;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.BLL.Services
{
    public class TeamSelectService : GenericService<Dto.Parameters.Selectional.TeamDto, Team>, ITeamSelectService
    {
        public TeamSelectService(IUnitOfWorkFactory uowFactory) : base(uowFactory) { }

        public List<Dto.General.TeamDto> RootTeamsByName(string name, bool strictlyMatching)
        {
            throw new NotImplementedException();
        }

        public Tree<Dto.General.TeamDto> SubteamsTree(Dto.Parameters.Selectional.TeamDto rootTeam)
        {
            throw new NotImplementedException();
        }

        public List<Dto.General.UserDto> TeamParticipants(Dto.Parameters.Selectional.TeamDto team, bool includingSubteams)
        {
            throw new NotImplementedException();
        }

        public List<Dto.General.TeamDto> TeamsByMember(Dto.Parameters.Selectional.UserDto member)
        {
            throw new NotImplementedException();
        }
    }
}
