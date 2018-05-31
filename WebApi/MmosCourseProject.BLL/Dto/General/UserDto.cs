using MmosCourseProject.BLL.Dto.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    [DataContract]
	public class UserDto
    {
        [DataMember]
		public int Id { get; set; }
        [DataMember]
		public string Email { get; set; }
        [DataMember]
		public string PasswordHash { get; set; }
        [DataMember]
		public string PasswordSalt { get; set; }
        [DataMember]
		public string FirstName { get; set; }
        [DataMember]
		public string LastName { get; set; }
        [DataMember]
		public UserPositionDto Position { get; set; }
        [DataMember]
		public string Specialization { get; set; }
        [DataMember]
		public UserLevelDto Level { get; set; }

        [DataMember]
		public List<ChatMessageDto> ChatMessages { get; set; }
        [DataMember]
		public List<CommentDto> Comments { get; set; }
        [DataMember]
		public List<TaskDto> TasksRespondFor { get; set; }
        [DataMember]
		public List<TeamDto> TeamsUnderLead { get; set; }
        [DataMember]
		public List<UserTeamDto> UserTeams { get; set; }
        [DataMember]
		public List<ChannelDto> Channels { get; set; }
        [DataMember]
		public List<TaskDto> TaskList { get; set; }
    }
}
