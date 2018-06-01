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
    public class CommentDto
    {
        [DataMember]
        [Range(0, 0, ErrorMessage = "Id must be NOT specified in case of creation")]
        public int Id { get; set; }

        [DataMember]
        public int AuthorId { get; set; }

        [DataMember]
        public int TaskId { get; set; }

        [DataMember]
        [Required]
        public string Text { get; set; }

        [DataMember]
        public DateTime? SentDateTime { get; set; }
    }
}
