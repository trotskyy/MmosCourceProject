using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MmosCourseProject.DAL;

namespace MmosCourseProject.DAL.Abstract
{
    public interface ITaskRepository : IRepository<Task, int>
    {
    }
}
