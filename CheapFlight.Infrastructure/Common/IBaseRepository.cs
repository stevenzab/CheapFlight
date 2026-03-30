using CheapFlight.Domain.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapFlight.Infrastructure.Common
{
    public interface IBaseRepository
    {
        Task AddAsync<T>(T entity) where T : RepositoryCollection;

        IQueryable<T> AsQueryable<T>();

        IMongoCollection<T> GetCollection<T>(string name);
    }
}
