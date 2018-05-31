using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    /// <summary>
    /// defines relation Task - Executors List
    /// </summary>
    [DataContract]
	public class UserTeamDto
    {
        [DataMember]
		public int User_Id { get; set; }
        [DataMember]
		public int Team_Id { get; set; }

        [DataMember]
		public List<ChannelDto> Channels { get; set; }
        [DataMember]
		public List<TaskDto> Tasks { get; set; }
        [DataMember]
		public TeamDto Team { get; set; }
        [DataMember]
		public UserDto User { get; set; }
    }
}
