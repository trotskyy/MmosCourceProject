using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL
{
    public class TaskRepository : GenericRepository<Task, int>, ITaskRepository
    {
        public TaskRepository(MyTrelloContext dbContext) : base(dbContext)
        {
        }
    }
}
