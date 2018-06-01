using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Dto;
using System.Collections.Generic;
using System;
using MmosCourseProject.BLL.DataStructures;

namespace MmosCourseProject.BLL.Services.Abstract
{
    public interface ITeamService
    {
        ITeamSelectService Get { get; }

        //TODO if team is a root team (no parentTeamId) teamName must be unique among all root teams
        TeamDto CreateTeam(TeamDto team);

        /// <summary>
        /// Удаление команды (только тимлид)
        /// </summary>
        /// <param name="teamId"></param>
        void DeleteTeam(int teamId);

        /// <summary>
        /// Пригласить пользова-теля в команду. На са-мом деле сразу добав-ляет его, но можно написать что шлётся приглашение на мыло и тд.
        /// </summary>
        void InviteUserToTeam(int teamId, string userLogin);

        /// <summary>
        /// Убрать пользователя из команды (только тим-лид или самого себя)
        /// </summary>
        /// <param name="teamlead">null для самоудаления</param>
        /// <param name="teamId"></param>
        /// <param name="deletedUserId"></param>
        void DeleteUserFromTeam(UserDto teamlead, int teamId, int deletedUserId);
    }
}