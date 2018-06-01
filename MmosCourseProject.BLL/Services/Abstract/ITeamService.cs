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
    public interface ITeamService
    {
        ITeamSelectService Get { get; }

        //TODO if team is a root team (no parentTeamId) teamName must be unique among all root teams
        General.TeamDto CreateTeam(Creational.TeamDto team);

        /// <summary>
        /// Удаление команды (только тимлид)
        /// </summary>
        void DeleteTeam(Selectional.TeamDto team);

        /// <summary>
        /// Пригласить пользова-теля в команду. На са-мом деле сразу добав-ляет его, но можно написать что шлётся приглашение на мыло и тд.
        /// </summary>
        void InviteUserToTeam(Selectional.TeamDto team, string userEmail);

        /// <summary>
        /// Убрать пользователя из команды (только тим-лид или самого себя)
        /// </summary>
        void DeleteUserFromTeam(Selectional.UserDto user, Selectional.TeamDto team);
    }
}