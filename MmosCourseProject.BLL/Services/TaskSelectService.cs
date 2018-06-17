using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Services.Abstract;
using MmosCourseProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.BLL.Utils;
using MmosCourseProject.BLL.Dto.Parameters.Selectional;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.BLL.Services
{
    public class TaskSelectService : GenericService<Dto.Parameters.Selectional.TaskDto, DAL.Task>, ITaskSelectService
    {
        public TaskSelectService(IUnitOfWorkFactory uowFactory) : base(uowFactory) { }

        public List<Dto.General.TaskDto> TasksByExecutor(Dto.Parameters.Selectional.UserDto executor)
        {
            ValidateDto(executor);

            return Execute.Select(uow => uow.Repository<ITaskRepository>().Get(t => t.Executors.Contains(executor.MapToDbEntity())));
        }
    }
}
