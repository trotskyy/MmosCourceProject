using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MmosCourseProject.BLL.Dto.Parameters.Selectional
{
    [DataContract]
    public class ChannelDto
    {
        [DataMember]
        [Range(1,int.MaxValue, ErrorMessage = "Id not specified")]
        public int Id { get; set; }
    }
}
