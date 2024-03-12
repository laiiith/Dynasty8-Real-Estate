using Dynasty8.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynasty8.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Task d()
        {
            throw new NotImplementedException();
        }
    }
}
