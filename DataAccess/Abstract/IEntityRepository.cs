using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Generic Constraint : Generic kısıt
    //T:class = T sadece referans tip olabilir demektir.
    //,IEntity =T ya IEntity ya da IEntityden implemente olmuş olabilir demektir.
    //new = new'lenebilir olmalı demek. IEntity yazılmasını bu şekilde önledim.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
