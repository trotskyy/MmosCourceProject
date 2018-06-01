using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Dto;
using System.Collections.Generic;
using System;
using MmosCourseProject.BLL.DataStructures;

namespace MmosCourseProject.BLL.Services.Abstract
{
    public interface ITaskService
    {
        ITaskSelectService Get { get; }

        void CreateTask(TaskDto task);

        void UpdateTask(TaskDto task);
        /// <summary>
        /// Change state of task including subtasks
        /// </summary>
        /// <param name="taskState"></param>
        void UpdateTaskGraphState(TaskStateDto taskState);

        /// <summary>
        /// Notice! Deleting one task, you delete all it's subtasks
        /// </summary>
        /// <param name="parentTask"></param>
        void DeleteTaskTree(TaskDto parentTask);

        void CreateTaskComment(CommentDto comment);
        void DeleteTaskComment(CommentDto comment);
    }
}