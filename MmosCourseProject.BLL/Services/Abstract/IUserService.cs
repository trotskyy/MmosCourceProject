using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Dto;

namespace MmosCourseProject.BLL.Services.Abstract
{
    public interface IUserService
    {
        /// <summary>
        /// Don't dare define login OR(separately) password validness 
        /// </summary>
        /// <returns>true, if valid. false if there is no such user or password invalid</returns>
        bool IsLoginAndPasswordValid(string login, string password);

        /// <summary>
        /// Добавление/изменение персональной инфо
        /// </summary>
        /// <param name="user"></param>
        void EditBio(UserDto user);

        /// <summary>
        /// Создать новый аккаунт
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Id нового аккаунта</returns>
        int CreateAccount(UserDto user);

        /// <summary>
        /// Удалить аккаунт
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Id нового аккаунта</returns>
        int DeleteAccount(UserDto user);
    }
}