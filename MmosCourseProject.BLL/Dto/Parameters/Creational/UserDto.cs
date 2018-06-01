using MmosCourseProject.BLL.Dto.Enum;
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
	public class UserDto
    {
        [DataMember]
        [Range(0, 0, ErrorMessage = "Id must be NOT specified in case of creation")]
        public int Id { get; set; }

        [DataMember]
        [Required]
		public string Email { get; set; }

        [DataMember]
        [Required]
        public string Password { get; set; }

        [DataMember]
        [Required]
		public string FirstName { get; set; }

        [DataMember]
        [Required]
        public string LastName { get; set; }

        [DataMember]
		public UserPositionDto Position { get; set; }

        [DataMember]
		public string Specialization { get; set; }

        [DataMember]
		public UserLevelDto Level { get; set; }
    }
}
