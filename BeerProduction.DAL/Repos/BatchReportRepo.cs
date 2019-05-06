using BeerProduction.DAL.Repos;

namespace BeerProduction.DAL
{
    public class BatchReportRepo<T> : BaseRepository<T> where T : class
    {
        public BatchReportRepo(Context context) : base(context)
        {

        }
    }
}