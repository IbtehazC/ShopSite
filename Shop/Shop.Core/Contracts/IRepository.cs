﻿using Shop.Core.Models;
using System.Linq;

namespace Shop.Core.Contracts
{
    public interface IRepository<T> where T : BaseEnitity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T t);
        void Update(T t);
    }
}