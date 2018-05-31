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
    public class TaskDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int CreatorId { get; set; }
        [DataMember]
        public DateTime CreationDateTime { get; set; }
        [DataMember]
        public int TeamId { get; set; }
        [DataMember]
        public TaskStateDto State { get; set; }
        [DataMember]
        public TaskPriorityDto Priority { get; set; }
        [DataMember]
        public bool IsUrgent { get; set; }
        [DataMember]
        public DateTime? LastChangeDateTime { get; set; }
        [DataMember]
        public int? ParentTaskId { get; set; }
        [DataMember]
        public int ResponsibleId { get; set; }

        [DataMember]
        public List<CommentDto> Comments { get; set; }
        [DataMember]
        public UserTeamDto CreatorUserTeam { get; set; }
        [DataMember]
        public List<TaskDto> FirstLevelSubtasks { get; set; }
        [DataMember]
        public TaskDto ParentTask { get; set; }
        [DataMember]
        public UserDto ResponsibleUser { get; set; }
        [DataMember]
        public List<UserDto> Executors { get; set; }
    }
}
