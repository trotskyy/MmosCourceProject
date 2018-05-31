using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.General
{
    public class CommentDto
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int TaskId { get; set; }
        public string Text { get; set; }
        public DateTime? SentDateTime { get; set; }

        public UserDto Author { get; set; }
        public TaskDto Task { get; set; }
    }
}
