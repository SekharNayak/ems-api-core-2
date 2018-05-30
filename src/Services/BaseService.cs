using Microsoft.EntityFrameworkCore;

namespace ems.services.implementation{

    public abstract class BaseService
    {

        private readonly DbContext _dbContext ;
        public BaseService(DbContext dbContext) => this._dbContext = dbContext;
        
    }
}