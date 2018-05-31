using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    public class ChannelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatorId { get; set; }
        public int TeamId { get; set; }

        public UserTeamDto CreatorUserTeam { get; set; }
        public List<ChatMessageDto> ChatMessages { get; set; }
        public List<UserDto> Users { get; set; }
    }
}
