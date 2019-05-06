using BeerProduction.DAL.Repos;

namespace BeerProduction.DAL
{
    public class StateRepo<T> : BaseRepository<T> where T : class
    {
        public StateRepo(Context context) : base(context)
        {

        }
    }
}