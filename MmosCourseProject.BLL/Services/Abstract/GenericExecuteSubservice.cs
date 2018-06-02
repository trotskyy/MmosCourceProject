using AutoMapper;
using MmosCourseProject.BLL.Exceptions;
using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Services.Abstract
{
    public class GenericExecuteSubservice<TDtoEntity, TDbEntity>
        where TDbEntity : class
    {
        protected IUnitOfWorkFactory _unitOfWorkFactory;

        public GenericExecuteSubservice(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        #region ExecuteSelect overloads

        private TMapped GeneralExecuteSelect<TMapped, TOriginal>(Func<IUnitOfWork, TOriginal> query)
        {
            try
            {
                TOriginal result;
                using (var uow = _unitOfWorkFactory.GetUnitOfWork())
                {
                    result = query.Invoke(uow);
                }
                return Mapper.Map<TMapped>(result);
            }
            catch (Exception ex)
            {
                throw new DomainModelException(ex);
            }
        }

        /// <summary>
        /// Select List of Dto entities. Don't Saves Changes() !!!
        /// </summary>
        /// <typeparam name="DtoEntity">method result В какой тип замаппить результат запроса</typeparam>
        /// <typeparam name="DbEntity">repository method result</typeparam>
        /// <param name="query">uow => uow.ChannelRepository.GetChannelsByTeam(team.Id)</param>
        /// <returns>List of Dto entities</returns>
        public List<DtoEntity> Select<DtoEntity, DbEntity>(Func<IUnitOfWork, List<DbEntity>> query)
        {
            return GeneralExecuteSelect<List<DtoEntity>, List<DbEntity>>(query);
        }

        /// <summary>
        /// Select List of Dto entities. Don't Saves Changes() !!!
        /// </summary>
        /// <typeparam name="DtoEntity">method result В какой тип замаппить результат запроса</typeparam>
        /// <param name="query">uow => uow.ChannelRepository.GetChannelsByTeam(team.Id)</param>
        /// <returns>List of Dto entities</returns>
        public List<DtoEntity> Select<DtoEntity>(Func<IUnitOfWork, List<TDbEntity>> query)
        {
            return GeneralExecuteSelect<List<DtoEntity>, List<TDbEntity>>(query);
        }

        /// <summary>
        /// Select List of Dto entities. Don't Saves Changes() !!!
        /// </summary>
        /// <param name="query">uow => uow.ChannelRepository.GetChannelsByTeam(team.Id)</param>
        /// <returns>List of Generic Dto entities</returns>
        public List<TDtoEntity> Select(Func<IUnitOfWork, List<TDbEntity>> query)
        {
            return GeneralExecuteSelect<List<TDtoEntity>, List<TDbEntity>>(query);
        }

        ///////////////////////// single Dto

        /// <summary>
        /// Select Dto entity. Don't Saves Changes() !!!
        /// </summary>
        /// <typeparam name="DtoEntity">method result В какой тип замаппить результат запроса</typeparam>
        /// <typeparam name="DbEntity">repository method result</typeparam>
        /// <param name="query">uow => uow.ChannelRepository.GetChannelsByTeam(team.Id)</param>
        /// <returns>Dto entity</returns>
        public DtoEntity Select<DtoEntity, DbEntity>(Func<IUnitOfWork, DbEntity> query)
        {
            return GeneralExecuteSelect<DtoEntity, DbEntity>(query);
        }

        /// <summary>
        /// Select Dto entity. Don't Saves Changes() !!!
        /// </summary>
        /// <typeparam name="DtoEntity">method result В какой тип замаппить результат запроса</typeparam>
        /// <param name="query">uow => uow.ChannelRepository.GetChannelsByTeam(team.Id)</param>
        /// <returns>Dto entity</returns>
        public DtoEntity Select<DtoEntity>(Func<IUnitOfWork, TDbEntity> query)
        {
            return GeneralExecuteSelect<DtoEntity, TDbEntity>(query);
        }

        /// <summary>
        /// Select Dto entity. Don't Saves Changes() !!!
        /// </summary>
        /// <param name="query">uow => uow.ChannelRepository.GetChannelsByTeam(team.Id)</param>
        /// <returns>Generic Dto entity</returns>
        public TDtoEntity Select(Func<IUnitOfWork, TDbEntity> query)
        {
            return GeneralExecuteSelect<TDtoEntity, TDbEntity>(query);
        }
        #endregion

        /// <summary>
        /// For queries returnin NON table values. NOT MAPPED !!! Don't Saves Changes() !!!
        /// </summary>
        /// <typeparam name="T">actual return param. no mapping</typeparam>
        /// <param name="query">uow => uow.GetString / ListInt / ...</param>
        /// <returns>NON table value</returns>
        public T ScalarSelect<T>(Func<IUnitOfWork, T> query)
        {
            try
            {
                T result;
                using (var uow = _unitOfWorkFactory.GetUnitOfWork())
                {
                    result = query.Invoke(uow);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new DomainModelException(ex);
            }
        }

        /// <summary>
        /// Execute NON select query and SaveChanges()
        /// </summary>
        /// <param name="query">uow => uow.Repo.Delete(...)</param>
        /// <returns>Number of affected rows</returns>
        public int NonQuery(Action<IUnitOfWork> query)
        {
            try
            {
                int result;
                using (var uow = _unitOfWorkFactory.GetUnitOfWork())
                {
                    query.Invoke(uow);
                    result = uow.SaveChanges();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new DomainModelException(ex);
            }
        }
    }
}
