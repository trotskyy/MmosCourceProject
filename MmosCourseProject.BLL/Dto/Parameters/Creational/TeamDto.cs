using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.Parameters.Creational
{
    [DataContract]
	public class TeamDto
    {
        [DataMember]
        [Range(0, 0, ErrorMessage = "Id must be NOT specified in case of creation")]
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

