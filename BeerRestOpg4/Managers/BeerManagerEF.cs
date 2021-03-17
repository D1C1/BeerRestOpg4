using BeerMorten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerRestOpg4.Managers
{
    public class BeerManagerEF : IBeerManager
    {
        private readonly BeerContext _context;
        public BeerManagerEF(BeerContext context)
        {
            _context = context;
        }

        public void Add(Beer value)
        {
            _context.Beers.Add(value);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Beer> Getall()
        {
            return _context.Beers;
        }

        public Beer getById(int id)
        {
            return _context.Beers.Find(id);
        }

        public void Update(int id, Beer value)
        {
            throw new NotImplementedException();
        }
    }
}
