using MmosCourseProject.BLL.Dto.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserPositionDto Position { get; set; }
        public string Specialization { get; set; }
        public UserLevelDto Level { get; set; }

        public List<ChatMessageDto> ChatMessages { get; set; }
        public List<CommentDto> Comments { get; set; }
        public List<TaskDto> TasksRespondFor { get; set; }
        public List<TeamDto> TeamsUnderLead { get; set; }
        public List<UserTeamDto> UserTeams { get; set; }
        public List<ChannelDto> Channels { get; set; }
        public List<TaskDto> TaskList { get; set; }
    }
}
