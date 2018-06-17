using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;
using DomainModelValidation;

namespace MmosCourseProject.DAL.EfProviders
{
    public abstract class EfGenericRepository<TEntity, TKey> : GenericRepository<TEntity, TKey, MyTrelloContext>
        where TEntity : class
    {
        public EfGenericRepository(MyTrelloContext dbContext) : base(dbContext)
        {
        }

        protected override void ValidateOnCreate(TEntity entity)
        {
            DomainModelValidator<MyTrelloContext>.Validate(entity, _dbContext, ValidationType.OnCreate);
        }

        protected override void ValidateOnDelete(TEntity entity)
        {
            DomainModelValidator<MyTrelloContext>.Validate(entity, _dbContext, ValidationType.OnDelete);
        }

        protected override void ValidateOnUpdate(TEntity entity)
        {
            DomainModelValidator<MyTrelloContext>.Validate(entity, _dbContext, ValidationType.OnUpdate);
        }
    }
}
