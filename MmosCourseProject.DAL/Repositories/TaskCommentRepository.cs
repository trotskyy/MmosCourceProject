using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL
{
    public class TaskCommentRepository : GenericRepository<TaskComment, int>, ICommentRepository
    {
        public TaskCommentRepository(MyTrelloContext dbContext) : base(dbContext)
        {
        }
    }
}
