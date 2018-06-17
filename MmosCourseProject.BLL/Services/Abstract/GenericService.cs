using AutoMapper;
using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.BLL.Exceptions;
using System.ComponentModel.DataAnnotations;
using DomainModelValidation;

namespace MmosCourseProject.BLL.Services.Abstract
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TDtoEntity">Generic DTO</typeparam>
    /// <typeparam name="TDbEntity">Corresponding DB entity</typeparam>
    public abstract class GenericService<TDtoEntity, TDbEntity>
        where TDbEntity : class
    {
        protected IUnitOfWorkFactory _unitOfWorkFactory;
        private GenericExecuteSubservice<TDtoEntity, TDbEntity> _genericExecuteSubservice;

        protected GenericService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        /// <summary>
        /// Operations with DB encapsulated here
        /// </summary>
        protected GenericExecuteSubservice<TDtoEntity, TDbEntity> Execute
        {
            get
            {
                if (_genericExecuteSubservice == null)
                    _genericExecuteSubservice = new GenericExecuteSubservice<TDtoEntity, TDbEntity>(_unitOfWorkFactory);
                return _genericExecuteSubservice;
            }
        }

        /// <summary>
        /// Throws ArgumentNullException / DtoValidationException or inherited exceptions if DTO is not valid
        /// </summary>
        /// <param name="dto">Any DTO with DataAnnotations attributes</param>
        protected void ValidateDto(object dto)
        {
            if (dto is null)
                throw new ArgumentNullException();

            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(dto, null, null);
            var validationResults = new List<ValidationResult>();
            bool isDtoValid = Validator.TryValidateObject(dto, validationContext, validationResults);

            if (isDtoValid)
                return;

            //foreach (var vr in validationResults)
            //    foreach (var mn in vr.MemberNames)
            //        if (mn.Contains("Id"))
            //            throw new IdNotSpecifiedException(dto);

            throw new DtoValidationFailedException(validationResults);
        }

        ///// <summary>
        ///// Validate using DomainModelValidationLibrary. Throws definied by you exceptions in case of validation failure
        ///// </summary>
        ///// <typeparam name="DbEntity"></typeparam>
        ///// <param name="entity"></param>
        //protected void ValidateDbEntity<DbEntity>(DbEntity entity, IUnitOfWork uow, ValidationType validationType)
        //    where DbEntity : class
        //{
        //    DomainModelValidator<IUnitOfWork>.Validate(entity, uow, validationType);
        //}
    }
}
