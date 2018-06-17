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
        private ITaskSelectService _taskSelectService;

        public TaskService(IUnitOfWorkFactory ouwFactory) : base(ouwFactory) { }

        public ITaskSelectService Get
        {
            get
            {
                if (_taskSelectService == null)
                    _taskSelectService = new TaskSelectService(_unitOfWorkFactory);
                return _taskSelectService;
            }
        }

        public void CreateTask(Dto.Parameters.Creational.TaskDto task)
        {
            Execute.NonQuery(uow => uow.Repository<ITaskRepository>().Create(task.MapToDbEntity()));
        }

        public void CreateTaskComment(Dto.Parameters.Creational.CommentDto comment)
        {
            Execute.NonQuery(uow => uow.Repository<ICommentRepository>().Create(comment.MapToDbEntity()));
        }

        public void DeleteTaskComment(Dto.Parameters.Selectional.CommentDto comment)
        {
            Execute.NonQuery(uow => uow.Repository<ICommentRepository>().Delete(comment.MapToDbEntity()));
        }

        public void DeleteTaskTree(Dto.Parameters.Selectional.TaskDto parentTask)
        {
            Execute.NonQuery(uow => uow.Repository<ITaskRepository>().Delete(parentTask.MapToDbEntity()));
        }

        public void UpdateTask(Dto.Parameters.Updational.TaskDto task)
        {
            Execute.NonQuery(uow => uow.Repository<ITaskRepository>().Update(task.MapToDbEntity()));
        }

        public void UpdateTaskGraphState(TaskStateDto taskState, int taskId)
        {
            var updateTaskDTO = new Dto.Parameters.Updational.TaskDto();
            updateTaskDTO.Id = taskId;
            updateTaskDTO.State = taskState;
            Execute.NonQuery(uow => uow.Repository<ITaskRepository>().Update(updateTaskDTO.MapToDbEntity()));
        }
    }
}
