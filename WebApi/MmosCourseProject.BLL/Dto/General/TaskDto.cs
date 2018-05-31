using MmosCourseProject.BLL.Dto.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int TeamId { get; set; }
        public TaskStateDto State { get; set; }
        public TaskPriorityDto Priority { get; set; }
        public bool IsUrgent { get; set; }
        public DateTime? LastChangeDateTime { get; set; }
        public int? ParentTaskId { get; set; }
        public int ResponsibleId { get; set; }

        public List<CommentDto> Comments { get; set; }
        public UserTeamDto CreatorUserTeam { get; set; }
        public List<TaskDto> FirstLevelSubtasks { get; set; }
        public TaskDto ParentTask { get; set; }
        public UserDto ResponsibleUser { get; set; }
        public List<UserDto> Executors { get; set; }
    }
}
