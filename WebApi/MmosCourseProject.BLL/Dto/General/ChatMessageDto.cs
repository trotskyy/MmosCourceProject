using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    public class ChatMessageDto
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int ChannelId { get; set; }
        public string Text { get; set; }
        public DateTime? SentDateTime { get; set; }

        public ChannelDto Channel { get; set; }
        public UserDto Author { get; set; }
    }
}
