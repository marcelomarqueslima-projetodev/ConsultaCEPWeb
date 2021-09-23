﻿using System.Collections.Generic;

namespace ConsultaCEPWeb.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
        void Add(T obj);
        void Remove(T obj);
        void Update(T obj);
    }
}
