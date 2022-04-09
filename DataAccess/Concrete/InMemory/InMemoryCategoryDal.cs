using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryCategoryDal : ICategoryDal
    {

        List<Category> _categories;
        public InMemoryCategoryDal()
        {
            _categories = new List<Category>()
            {
                new Category(){CategoryId=1,CategoryName="Telefon"},
                new Category(){CategoryId=2,CategoryName="Televizyon"},
                new Category(){CategoryId=3,CategoryName="Klavye"},
                new Category(){CategoryId=4,CategoryName="Mouse"},
                new Category(){CategoryId=5,CategoryName="Laptop"}
            };
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _categories;
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        
    }
}
