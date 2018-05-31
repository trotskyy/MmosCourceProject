using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    public class TeamDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TeamLeadId { get; set; }
        public int? ParentTeamId { get; set; }

        public List<TeamDto> FirstLevelSubteams { get; set; }
        public TeamDto ParentTeam { get; set; }
        public UserDto TeamLead { get; set; }
        public List<UserTeamDto> UserTeams { get; set; }
    }
}
