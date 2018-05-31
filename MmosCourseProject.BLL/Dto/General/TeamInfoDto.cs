using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    /// <summary>
    /// Provides integral characteristics of teams. Via recursion. Dto for TeamInfo VIEW ! Only Get() operations
    /// </summary>
    [DataContract]
	public class TeamInfoDto
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
		public int? TotalPeopleCount { get; set; }
        [DataMember]
		public int? SuperiorsCount { get; set; }
        [DataMember]
		public int? SubteamsCount { get; set; }
        [DataMember]
		public int? TotalTasksCount { get; set; }
        [DataMember]
		public int? NewTasksCount { get; set; }
        [DataMember]
		public int? TasksInProgressCount { get; set; }
        [DataMember]
		public int? DoneTasksCount { get; set; }
        [DataMember]
		public int? ApprovedTasksCount { get; set; }
        [DataMember]
		public int? TasksWithBugsCount { get; set; }
        [DataMember]
		public int? DebuggingTasksCount { get; set; }
        [DataMember]
		public int? HighestPriorityTasksCount { get; set; }
        [DataMember]
		public DateTime? FirstActivityDateTime { get; set; }
        [DataMember]
		public DateTime? LastActivityDateTime { get; set; }
    }
}
