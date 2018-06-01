using AutoMapper;
using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.BLL.Exceptions;

namespace MmosCourseProject.BLL.Services.Abstract
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TDtoEntity">Generic DTO</typeparam>
    /// <typeparam name="TDbEntity">Corresponding DB entity</typeparam>
    public abstract class GenericService<TDtoEntity, TDbEntity>
    {
        protected IUnitOfWorkFactory _unitOfWorkFactory;

        protected GenericService(IUnitOfWorkFactory unitOfWorkFactory)
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
        protected List<DtoEntity> ExecuteSelect<DtoEntity, DbEntity>(Func<IUnitOfWork, List<DbEntity>> query)
        {
            return GeneralExecuteSelect<List<DtoEntity>, List<DbEntity>>(query);
        }

        /// <summary>
        /// Select List of Dto entities. Don't Saves Changes() !!!
        /// </summary>
        /// <typeparam name="DtoEntity">method result В какой тип замаппить результат запроса</typeparam>
        /// <param name="query">uow => uow.ChannelRepository.GetChannelsByTeam(team.Id)</param>
        /// <returns>List of Dto entities</returns>
        protected List<DtoEntity> ExecuteSelect<DtoEntity>(Func<IUnitOfWork, List<TDbEntity>> query)
        {
            return GeneralExecuteSelect<List<DtoEntity>, List<TDbEntity>>(query);
        }

        /// <summary>
        /// Select List of Dto entities. Don't Saves Changes() !!!
        /// </summary>
        /// <param name="query">uow => uow.ChannelRepository.GetChannelsByTeam(team.Id)</param>
        /// <returns>List of Generic Dto entities</returns>
        protected List<TDtoEntity> ExecuteSelect(Func<IUnitOfWork, List<TDbEntity>> query)
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
        protected DtoEntity ExecuteSelect<DtoEntity, DbEntity>(Func<IUnitOfWork, DbEntity> query)
        {
            return GeneralExecuteSelect<DtoEntity, DbEntity>(query);
        }

        /// <summary>
        /// Select Dto entity. Don't Saves Changes() !!!
        /// </summary>
        /// <typeparam name="DtoEntity">method result В какой тип замаппить результат запроса</typeparam>
        /// <param name="query">uow => uow.ChannelRepository.GetChannelsByTeam(team.Id)</param>
        /// <returns>Dto entity</returns>
        protected DtoEntity ExecuteSelect<DtoEntity>(Func<IUnitOfWork, TDbEntity> query)
        {
            return GeneralExecuteSelect<DtoEntity, TDbEntity>(query);
        }

        /// <summary>
        /// Select Dto entity. Don't Saves Changes() !!!
        /// </summary>
        /// <param name="query">uow => uow.ChannelRepository.GetChannelsByTeam(team.Id)</param>
        /// <returns>Generic Dto entity</returns>
        protected TDtoEntity ExecuteSelect(Func<IUnitOfWork, TDbEntity> query)
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
        public T ExecuteScalarSelect<T>(Func<IUnitOfWork, T> query)
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
        protected int ExecuteNonQuery(Action<IUnitOfWork> query)
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
