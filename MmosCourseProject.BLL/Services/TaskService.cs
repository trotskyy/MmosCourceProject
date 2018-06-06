using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Services.Abstract;
using MmosCourseProject.DAL;
using MmosCourseProject.BLL.Utils;
using MmosCourseProject.DAL.Abstract;
using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto.Parameters.Creational;
using MmosCourseProject.BLL.Dto.Parameters.Selectional;
using MmosCourseProject.BLL.Dto.Parameters.Updational;

namespace MmosCourseProject.BLL.Services
{
    public class TaskService : GenericService<Dto.General.TaskDto, DAL.Task>, ITaskService
    {
        public TaskService(IUnitOfWorkFactory ouwFactory) : base(ouwFactory) { }

        public ITaskSelectService Get => throw new NotImplementedException();

        public void CreateTask(Dto.Parameters.Creational.TaskDto task)
        {
            throw new NotImplementedException();
        }

        public void CreateTaskComment(Dto.Parameters.Creational.CommentDto comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteTaskComment(Dto.Parameters.Selectional.CommentDto comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteTaskTree(Dto.Parameters.Selectional.TaskDto parentTask)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(Dto.Parameters.Updational.TaskDto task)
        {
            throw new NotImplementedException();
        }

        public void UpdateTaskGraphState(TaskStateDto taskState, int taskId)
        {
            throw new NotImplementedException();
        }
    }
}
