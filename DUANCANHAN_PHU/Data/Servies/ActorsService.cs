using DUANMVC.Data;
using DUANMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DUANCANHAN_PHU.Data.Servies
{
    public class ActorsService : IActorsService
    {

        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddO(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<Actor>> GetAll()
        {
           var result = await _context.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor NewActor)
        {
            throw new NotImplementedException();
        }

      
    }
}
