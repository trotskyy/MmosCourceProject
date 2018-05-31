using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    [DataContract]
    public class ChatMessageDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int AuthorId { get; set; }
        [DataMember]
        public int ChannelId { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public DateTime? SentDateTime { get; set; }

        [DataMember]
        public ChannelDto Channel { get; set; }
        [DataMember]
        public UserDto Author { get; set; }
    }
}
