using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.EfProviders
{
    public class TaskRepository : EfGenericRepository<Task, int>, ITaskRepository
    {
        public TaskRepository(MyTrelloContext dbContext) : base(dbContext) { }

        public override void Delete(Task entity)
        {
            _dbContext.DeleteTaskGraph(entity.Id);
        }
    }
}
