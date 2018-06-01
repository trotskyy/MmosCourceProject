using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto;
using General = MmosCourseProject.BLL.Dto.General;
using Selectional = MmosCourseProject.BLL.Dto.Parameters.Selectional;
using Creational = MmosCourseProject.BLL.Dto.Parameters.Creational;
using Updational = MmosCourseProject.BLL.Dto.Parameters.Updational;

namespace MmosCourseProject.BLL.Services.Abstract
{
    public interface IUserService
    {
        /// <summary>
        /// Don't dare define email OR(separately) password validness 
        /// </summary>
        /// <returns>true, if valid. false if there is no such user or password invalid</returns>
        bool AreEmailAndPasswordValid(string email, string password);

        /// <summary>
        /// Добавление/изменение персональной инфо
        /// </summary>
        /// <param name="user"></param>
        void EditBio(Updational.UserDto user);

        /// <summary>
        /// Создать новый аккаунт
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Id нового аккаунта</returns>
        int CreateAccount(Creational.UserDto user);

        /// <summary>
        /// Удалить аккаунт
        /// </summary>
        /// <param name="user"></param>
        void DeleteAccount(Selectional.UserDto user);
    }
}