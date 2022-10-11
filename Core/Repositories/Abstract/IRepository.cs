using BookShop.Domain.Entities.BaseEntities;

namespace Core.Repositories.Abstract;

public interface IRepository<TEntity> where TEntity : BaseEntity, new()
{
    
}
