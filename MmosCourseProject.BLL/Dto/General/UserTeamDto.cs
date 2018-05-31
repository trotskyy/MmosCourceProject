using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    /// <summary>
    /// defines relation Task - Executors List
    /// </summary>
    public class UserTeamDto
    {
        public int User_Id { get; set; }
        public int Team_Id { get; set; }

        public List<ChannelDto> Channels { get; set; }
        public List<TaskDto> Tasks { get; set; }
        public TeamDto Team { get; set; }
        public UserDto User { get; set; }
    }
}
