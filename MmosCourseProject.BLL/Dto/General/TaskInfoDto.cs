using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    /// <summary>
    /// Provides integral characteristics of tasks. Via recursion. Dto for TaskInfo VIEW ! Only Get() operations
    /// </summary>
    public class TaskInfoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TeamLeadId { get; set; }
        public int? ParentTeamId { get; set; }
        public int? TotalPeopleCount { get; set; }
        public int? SuperiorsCount { get; set; }
        public int? SubteamsCount { get; set; }
        public int? TotalTasksCount { get; set; }
        public int? NewTasksCount { get; set; }
        public int? TasksInProgressCount { get; set; }
        public int? DoneTasksCount { get; set; }
        public int? ApprovedTasksCount { get; set; }
        public int? TasksWithBugsCount { get; set; }
        public int? DebuggingTasksCount { get; set; }
        public int? HighestPriorityTasksCount { get; set; }
        public DateTime? FirstActivityDateTime { get; set; }
        public DateTime? LastActivityDateTime { get; set; }
    }
}
