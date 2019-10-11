using System;
using System.Collections.Generic;
using System.Text;

namespace VCAngular.Data.Repositories
{
    public class VennCuisineRepository : IVennCuisineRepository
    {
        private VennCuisineContext _dbContext;

        public VennCuisineRepository(VennCuisineContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
