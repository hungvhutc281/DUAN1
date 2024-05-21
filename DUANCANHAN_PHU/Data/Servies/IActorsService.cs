using DUANMVC.Models;

namespace DUANCANHAN_PHU.Data.Servies
{
    public interface IActorsService 
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);

        void AddO(Actor actor);
        Actor Update(int id ,Actor NewActor);  
        void Delete(int id);






    }
}
