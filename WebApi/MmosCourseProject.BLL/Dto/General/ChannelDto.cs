using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    [DataContract]
    public class ChannelDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int CreatorId { get; set; }
        [DataMember]
        public int TeamId { get; set; }

        [DataMember]
        public UserTeamDto CreatorUserTeam { get; set; }
        [DataMember]
        public List<ChatMessageDto> ChatMessages { get; set; }
        [DataMember]
        public List<UserDto> Users { get; set; }
    }
}
