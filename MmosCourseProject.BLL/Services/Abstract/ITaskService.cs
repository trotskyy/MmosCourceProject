using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto;
using System.Collections.Generic;
using System;
using MmosCourseProject.BLL.DataStructures;
using General = MmosCourseProject.BLL.Dto.General;
using Selectional = MmosCourseProject.BLL.Dto.Parameters.Selectional;
using Creational = MmosCourseProject.BLL.Dto.Parameters.Creational;
using Updational = MmosCourseProject.BLL.Dto.Parameters.Updational;

namespace MmosCourseProject.BLL.Services.Abstract
{
    public interface ITaskService
    {
        ITaskSelectService Get { get; }

        void CreateTask(Creational.TaskDto task);

        void UpdateTask(Updational.TaskDto task);
        /// <summary>
        /// Change state of task including subtasks
        /// </summary>
        /// <param name="taskState"></param>
        void UpdateTaskGraphState(TaskStateDto taskState, int taskId);

        /// <summary>
        /// Notice! Deleting one task, you delete all it's subtasks
        /// </summary>
        /// <param name="parentTask"></param>
        void DeleteTaskTree(Selectional.TaskDto parentTask);

        void CreateTaskComment(Creational.CommentDto comment);
        void DeleteTaskComment(Selectional.CommentDto comment);
    }
}