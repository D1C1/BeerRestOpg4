using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerMorten;

namespace BeerRestOpg4.Managers
{
    public class BeerManager : IBeerManager
    {
        private static int _nextId = 1;

        private static List<Beer> _beers = new List<Beer>()
        {
            new Beer(_nextId++,0,"beer1",1),
            new Beer(_nextId++,0,"beer2",1),
            new Beer(_nextId++,0,"beer3",1)
        };

        public IEnumerable<Beer> Getall()
        {
            return _beers;
        }

        public Beer getById(int id)
        {
            return _beers.Find(beer => beer.Id == id);
        }

        public void Add(Beer value)
        {
            value.Id = _nextId++;
            _beers.Add(value);
        }

        public void Update(int id, Beer value)
        {
            Beer beer = _beers.Find(beer1 => beer1.Id == id);
            if (beer == null) return;
            beer.Abv = value.Abv;
            beer.Name = value.Name;
            beer.Price = value.Price;

        }

        public void Delete(int id)
        {
            Beer beer = _beers.Find(beer1 => beer1.Id == id);
            if (beer == null) return;
            _beers.Remove(beer);
        }
    }
}
