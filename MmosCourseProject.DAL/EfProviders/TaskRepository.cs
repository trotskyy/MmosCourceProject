using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.EfProviders
{
    public class TaskRepository : GenericRepository<Task, int>, ITaskRepository
    {
        public TaskRepository(DbContext dbContext) : base(dbContext) { }

        public override void Delete(Task entity)
        {
            MyTrelloContext myTrelloContext = _dbContext as MyTrelloContext;
            if (myTrelloContext == null)
                throw new Exception("Invalid dbContext type");
            myTrelloContext.DeleteTaskGraph(entity.Id);
        }
    }
}
