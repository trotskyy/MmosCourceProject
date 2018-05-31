using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    [DataContract]
	public class TeamDto
    {
        [DataMember]
		public int Id { get; set; }
        [DataMember]
		public string Name { get; set; }
        [DataMember]
		public string Description { get; set; }
        [DataMember]
		public int TeamLeadId { get; set; }
        [DataMember]
		public int? ParentTeamId { get; set; }

        [DataMember]
		public List<TeamDto> FirstLevelSubteams { get; set; }
        [DataMember]
		public TeamDto ParentTeam { get; set; }
        [DataMember]
		public UserDto TeamLead { get; set; }
        [DataMember]
		public List<UserTeamDto> UserTeams { get; set; }
    }
}
