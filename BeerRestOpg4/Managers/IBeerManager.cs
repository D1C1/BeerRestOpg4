using BeerMorten;
using System.Collections.Generic;

namespace BeerRestOpg4.Managers
{
    public interface IBeerManager
    {
        void Add(Beer value);
        void Delete(int id);
        IEnumerable<Beer> Getall();
        Beer getById(int id);
        void Update(int id, Beer value);
    }
}