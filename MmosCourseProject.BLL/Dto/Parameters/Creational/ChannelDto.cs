using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MmosCourseProject.BLL.Dto.Parameters.Creational
{
    [DataContract]
    public class ChannelDto
    {
        [DataMember]
        [Range(0,0, ErrorMessage = "Id must be NOT specified in case of creation")]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string Name { get; set; }

        [DataMember]
        public int CreatorId { get; set; }

        [DataMember]
        public int TeamId { get; set; }
    }
}
