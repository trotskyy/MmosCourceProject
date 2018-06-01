using MmosCourseProject.BLL.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General = MmosCourseProject.BLL.Dto.General;
using Selectional = MmosCourseProject.BLL.Dto.Parameters.Selectional;
using Creational = MmosCourseProject.BLL.Dto.Parameters.Creational;
using Updational = MmosCourseProject.BLL.Dto.Parameters.Updational;

namespace MmosCourseProject.BLL.Services.Abstract
{
    /// <summary>
    /// Provides entry point to SELECT operations
    /// </summary>
    public interface ITeamSelectService
    {
        /// <summary>
        /// Получить команды верхнего уровня по имени
        /// </summary>
        /// <param name="name"></param>
        /// <param name="strictlyMatching">false = LIKE '%name%'</param>
        /// <returns></returns>
        List<General.TeamDto> RootTeamsByName(string name, bool strictlyMatching);

        /// <summary>
        /// Получение списка команд верхнего уровня для пользователя
        /// </summary>
        /// <param name="member">Id required</param>
        /// <returns></returns>
        List<General.TeamDto> TeamsByMember(Selectional.UserDto member);

        /// <summary>
        /// All subteams and their subteans and ...
        /// </summary>
        /// <param name="rootTeam"></param>
        /// <returns>TREE!</returns>
        Tree<General.TeamDto> SubteamsTree(Selectional.TeamDto rootTeam);

        /// <summary>
        /// Получение учасников команды включая (или нет) участников подкоманд
        /// </summary>
        /// <param name="team"></param>
        /// <param name="includingSubteams">включая участников подкоманд</param>
        /// <returns></returns>
        List<General.UserDto> TeamParticipants(Selectional.TeamDto team, bool includingSubteams);
    }
}
