using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.DAL.EfProviders
{
    public class TaskInfoViewRepository : GenericViewRepository<TaskInfoView, int>, ITaskInfoViewRepository
    {
        public TaskInfoViewRepository(MyTrelloContext dbContext) : base(dbContext)
        {
        }
    }
}
