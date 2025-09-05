using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cls.DAL.DataAcess_Contracts
{

        public interface IBaseRepo<TEntity>
        {
            IEnumerable<TEntity> GetAll();
            TEntity FindById(int id);
            void Insert(TEntity entity);
            void Update(TEntity entity);
            void Delete(int id);
        }
    
} 
