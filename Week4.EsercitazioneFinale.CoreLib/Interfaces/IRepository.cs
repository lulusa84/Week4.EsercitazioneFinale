using System;
using System.Collections.Generic;
using System.Text;

namespace Week4.EsercitazioneFinale.CoreLib.Interfaces
{
    public interface IRepository<T>
    {
        List<T> Fetch();
        T GetByID(int id);
        bool Add(T item);
        bool Update(T item);
        bool DeleteById(int id);
    }
}
