using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.Parameters.Updational
{
    [DataContract]
	public class TeamDto
    {
        [DataMember]
        [Range(1, Int32.MaxValue, ErrorMessage = "Id not specified")]
        public int Id { get; set; }

        [DataMember]
        [Required]
		public string Name { get; set; }

        [DataMember]
        [Required]
		public string Description { get; set; }

        [DataMember]
		public int TeamLeadId { get; set; }

        [DataMember]
		public int? ParentTeamId { get; set; }
    }
}

