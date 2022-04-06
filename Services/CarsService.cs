using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gregslistSharpAuth.Models;
using gregslistSharpAuth.Repositories;

namespace gregslistSharpAuth.Services
{
    public class CarsService
    {
        private readonly CarsRepository _repo;

        public CarsService(CarsRepository repo)
        {
            _repo = repo;
        }

        internal List<Car> Get()
        {
            return _repo.Get();
        }
        internal Car Get(int id)
        {
            Car found = _repo.Get(id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }

        internal Car Create(Car carData)
        {
            return _repo.Create(carData);
        }

        internal Car Edit(Car update)
        {
            Car original = Get(update.Id);
            original.Description = update.Description ?? original.Description;
            original.Price = update.Price;
            original.Name = update.Name ?? original.Name;
            _repo.Update(original);
            return original;

        }

        internal void Delete(int id)
        {
            Get(id);
            _repo.Delete(id);
        }
    }



}