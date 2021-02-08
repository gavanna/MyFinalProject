using Core.DataAccess.EntityFramwork;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : IFEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
  
    }
}
