using MmosCourseProject.BLL.DataStructures;
using MmosCourseProject.BLL.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        List<TeamDto> RootTeamsByName(string name, bool strictlyMatching);

        /// <summary>
        /// Получение списка команд верхнего уровня для пользователя
        /// </summary>
        /// <param name="member">Id required</param>
        /// <returns></returns>
        List<TeamDto> TeamsByMember(UserDto member);

        /// <summary>
        /// All subteams and their subteans and ...
        /// </summary>
        /// <param name="rootTeam"></param>
        /// <returns>TREE!</returns>
        Tree<TeamDto> SubteamsTree(TeamDto rootTeam);

        /// <summary>
        /// Получение учасников команды включая (или нет) участников подкоманд
        /// </summary>
        /// <param name="team"></param>
        /// <param name="includingSubteams">включая участников подкоманд</param>
        /// <returns></returns>
        List<UserDto> TeamParticipants(TeamDto team, bool includingSubteams);
    }
}
